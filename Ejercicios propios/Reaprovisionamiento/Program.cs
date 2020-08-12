using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Reflection.Metadata.Ecma335;

namespace Reaprovisionamiento
{
    public class Program
    {
        public static string path = Directory.GetCurrentDirectory();
        public static string _path = $"{path}\\json1.json";


        static void Main(string[] args)
        {

            var contacts = GetJson(_path);
            
            
            var proximasCompras = calcularFecha(contacts);
            foreach (var compra in proximasCompras)
            {
                Console.WriteLine($"La proxima compra para el producto: {compra.products.First().sku}: {compra.products.First().name}\n" +
                        $"Sera el dia {compra.date} ");
            }

        }
        public static string GetJson(string camino)
        {
            string contacsFromFile;
            using (var reader=new StreamReader(camino))
            {
                contacsFromFile = reader.ReadToEnd();
                
                
            }
            return contacsFromFile;
        }
        public static List<Customer>  GetCustomer(string contacsFromFile)
        {
            
            Root contacts = JsonConvert.DeserializeObject<Root>(contacsFromFile);
         
            var customers = JsonConvert.DeserializeObject<Root>(contacsFromFile).customer;
            return customers;
                
        }

        public static List<Purchase> calcularFecha(string contacsFromFile)
        {
            var customers = GetCustomer(contacsFromFile);  // Lista de clientes con compras
            var proximasCompras = new List<Purchase>();  // La lista de las proximas compras

            foreach (Customer customer in customers)  // Iterar cliente
            {
                var purchases = customer.purchases;
                var productos = new List<Products2>();
                foreach (var item in purchases)
                {
                    foreach (var pr in item.products)
                    {
                        productos.Add(new Products2()
                        {
                            date = item.date,
                            number = item.number,
                            sku = pr.sku,
                            name = pr.name
                        }) ;
                    }
                }   // Generar una lista que tenga los datos que necesito
                var productos2 = productos.ToList();

                var result = productos2.Where(p2 => productos.Any(p1 => p1.number != p2.number && p1.sku == p2.sku)).ToList();
                // Guardo en result los productos repetidos en sku pero con diferente number
                
                var ultimaCompra = result.GroupBy(x => x.sku);  // Agrupo productos por sku ordenados por fecha
                foreach (var products in ultimaCompra)    // Comparar entre sku agrupados
                {
                    var ultimo = products.Last();
                    var anteultimo = products.SkipLast(1).Last();     

                    if(ultimo != anteultimo)            
                    {
                        
                        var ultimafecha = DateTime.Parse(ultimo.date);
                        var anteultimafecha = DateTime.Parse(anteultimo.date);
                        var totalDays = (ultimafecha-anteultimafecha).TotalDays;   // Cantidad dias de diferencia
                        var proxCompra = ultimafecha.AddDays(totalDays);           /* La ultima fecha mas la cantidad
                                                                                    * de dias de diferencia */
                        proximasCompras.Add(new Purchase()   // Agrego la proxima compra
                        {
                            products = new List<Product>()
                            {
                                new Product()
                                {
                                    sku = ultimo.sku,
                                    name = ultimo.name,
                                }

                            },
                            date = proxCompra.ToShortDateString(),
                            number = "0",
                        });
                    }
                }
            }

            return proximasCompras;
        }
       
    }

    public class Products2
    {
        public string sku { get; set; }
        public string name { get; set; }
        public string number { get; set; }
        public string date { get; set; }
    }

   
    public class Product
    {
        public string sku { get; set; }
        public string name { get; set; }
    }

    public class Purchase
    {
        public string number { get; set; }
        public string date { get; set; }
        public List<Product> products { get; set; }
    }

    public class Customer
    {
        public List<Purchase> purchases { get; set; }
    }

    public class Root
    {
        public List<Customer> customer { get; set; }
    }
}






  