using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;

namespace Ejercicio_aberturas
{
    class Program            //RECORDATORIO: FALTA HACER EXEPCIONES
    {
        static void Main(string[] args)
        {


            Puerta puerta1 = new Puerta(1, "aluminio", "medio vidrio", 80, 200);
            Console.WriteLine(puerta1.getInfoPuerta());
            List<Puerta> arrayPuertas = new List<Puerta>();
            arrayPuertas.Add(puerta1);
            
            
            
            List<Puerta> arrayPuertasFabrica = new List<Puerta>();    /* ACA ESTOY HACIENDO OTRA LISTA DE 
                                                                       * DE OBJETOS "PUERTA" pero para la fabrica
                                                                       * AHORA SI LO PENSE BIEN LA PUTA MADRE 
                                                                       * Antes no se me ocurria como hacer, porque estaba
                                                                       * tratando de meter objetos tipo "PUERTA" en un array
                                                                       * de objetos de tipo "FABRICA", CUANDO SOLO QUERIA
                                                                       * HACER OTRO ARRAY DIFERENTE DE OBJETOS DE TIPO "PUERTA"
                                                                       * */
            arrayPuertasFabrica.Add(puerta1);

            
            
            Fabrica fabrica1 = new Fabrica("LDO", 15);
            Console.WriteLine(fabrica1.contadorPuertas(arrayPuertas));
            Console.WriteLine(fabrica1.getInfoFabrica());


           
            Console.WriteLine(fabrica1.contadorPuertas(arrayPuertas));
            Console.WriteLine(fabrica1.getInfoFabrica());

            

            Console.WriteLine("\t***Bievenido a la aplicacion de fabricacion de aberturas TOLOSA***\n");
            
            while (true)
            {
                int opcion = 0;     // Esto lo hice por la exepcion
                    Console.WriteLine("Elija el numero de opcion deseada: ");
                    Console.WriteLine("1 Fabricar una puerta\n" +
                        "2 Vender una puerta\n" +
                        "3 Mostrar caracteristicas de una puerta\n" +
                        "4 Mostrar todas las puertas de la fabrica\n" +
                        "5 Informacion de la fabrica\n" +
                        "6 Cantidad de puertas en la fabrica\n" +
                        "7 Salir\n");

                try 
                { 


                    
                    int opcion2 = int.Parse(Console.ReadLine());
                    opcion = opcion2;
                }
                catch(Exception ex)
                {
                    Console.WriteLine("La opcion ingresada debe ser un numero");
                }

                /* Console.WriteLine("Introduce el numero del mes");
                 int NumeroMes = int.Parse(Console.ReadLine());
                 try
                 {
                     Console.WriteLine(NombreDelMes(NumeroMes));      Uso el metodo dentro del write
                 }
                 catch (Exception ex)
                 {
                     Console.WriteLine($"Mensaje de la exepcion: {ex.Message}");
                 }
                 Console.WriteLine("Aqui continuaria la ejecucion del programa"); */

                if (opcion == 1)
                {
                    Console.WriteLine("Ingrese los datos de la puerta");
                    Console.WriteLine("\t");
                    Console.WriteLine("id)");
                    double id = double.Parse(Console.ReadLine());
                    Console.WriteLine("material");
                    string material = Console.ReadLine();
                    Console.WriteLine("modelo");
                    string modelo = Console.ReadLine();
                    Console.WriteLine("ancho");
                    double ancho = double.Parse(Console.ReadLine());
                    Console.WriteLine("largo");
                    double largo = double.Parse(Console.ReadLine());
                    
                  
                    if (fabrica1.verificarId(id, arrayPuertas)) 
                    {
                        fabrica1.construirPuerta(new Puerta(id, material, modelo, ancho, largo), arrayPuertas);
                        Console.WriteLine("La puerta se fabrico  correctamente");
                    }
                    else
                    {
                        Console.WriteLine("La puerta ya existe");
                    }
          



                }
                else if (opcion == 2)
                {
                    double id = 0;
                    Console.WriteLine("Selecciona el id de la puerta que quiera vender");
                    try 
                    {
                        double id2 = double.Parse(Console.ReadLine());
                        id = id2;

                        if (fabrica1.verificarId(id, arrayPuertas))
                        {
                            Console.WriteLine("La puerta que quiere vender no se encuentra en el stock");
                        }
                        else
                        {

                            fabrica1.venderPuerta(id, arrayPuertas);
                            Console.WriteLine("La puerta se vendio correctamente");
                        }
                    }    
                    catch(Exception ex)
                    {
                        Console.WriteLine("El numero de id debe ser numerico" );

                    }
                    

                }
                else if (opcion == 3)
                {
                    Console.WriteLine("Selecciona el id de la puerta que quiera saber las caracteristicas");
                    double id = double.Parse(Console.ReadLine());
                    if (fabrica1.verificarId(id, arrayPuertas))
                    {
                        Console.WriteLine("La puerta que quiere saber las caracteristica no se encuentra en stock");
                    }
                    else
                    {
                        foreach (Puerta x in arrayPuertas)
                        {
                            if (id == x.id)
                            {
                                Console.WriteLine(x.getInfoPuerta());

                            }

                        }

                    }   

                }
                else if (opcion == 4)
                {
                    foreach(Puerta x in arrayPuertas)
                    {
                        Console.WriteLine(x.getInfoPuerta());
                    }
                }
                else if (opcion == 5)
                {
                    Console.WriteLine(fabrica1.getInfoFabrica());
                }
                else if (opcion == 6)
                {
                    Console.WriteLine("La ficabrica contiene: ", fabrica1.contadorPuertas(arrayPuertas)," puertas");
                }
                else if (opcion == 7)
                {
                    Console.WriteLine("Gracias por utilizar nuestra aplicacion");
                    break;
                }
                else
                {
                    Console.WriteLine("El numero de la opcion ingresada es incorrecta");
                }
            }
        }






        

    }
    class Puerta
    {
        public double id;
        private string material;
        private string modelo;
        private double ancho;
        private double largo;
        private string cerrojo;
        public string fabrica;



        public Puerta(double id, string material, string modelo,double ancho,double largo)     // CONSTRUCTOR
        {
            this.id = id;
            this.material = material;
            this.modelo = modelo;
            this.ancho = ancho;
            this.largo = largo;
            this.cerrojo = "cerrado";
        }


        
        public string getInfoPuerta()
        {
            return "La puerta: " + id + " " + "es de: " + material + " " + "modelo: " + modelo + " " + "con un ancho de: " + ancho + " " +
                "y un largo de: " + largo + " " + "con el cerrojo: " + cerrojo + " " + "fabricada en: " + fabrica;
        }
    
    }
    class Fabrica
    {
        public string nombre;
        private double cantEmpleados;
        private double cantPuertas;
        public Puerta puerta {get; set;}


        
        

        public Fabrica(string nombre, double cantEmpleados)    // Constructor de la fabrica
        {
            this.nombre = nombre;
            this.cantEmpleados = cantEmpleados;
            
        }
        
        public void construirPuerta(Puerta puerta, List<Puerta> arrayPuertas)
        {
            puerta.fabrica = this.nombre;   // arreglar la lista de fabrica
            
                
            arrayPuertas.Add(puerta);
            



        }
        public string getNombre()
        {
            return this.nombre;
        }


        public void venderPuerta(double id, List<Puerta> arrayPuertas)
        {
            for (int i = 0; i < (arrayPuertas.Count); i++)
            {
                Puerta x = arrayPuertas[i];
                
                if (id == x.id)
                {
                    arrayPuertas.Remove(x);
                }
            }
        }




        public bool verificarId(double id, List<Puerta> arrayPuertas)
        {
            bool verificacion = false;
            for (int i = 0; i < (arrayPuertas.Count); i++)
            {
                Puerta x = arrayPuertas[i];
                if (id != x.id)
                {

                    verificacion = true;
                    break;               // Para que deje de buscar
                }
               
                else
                {
                    verificacion =false;
                }

            }
            return verificacion;
            
        }
        // EN REALIDAD SE HACE ASI ( EXPLICADO POR ROBANDO)

                            /* public bool VerificarId(double id, List<Puerta> arrayPuertas)
                    {
                        //si lo encuentra devuelvo true
                        for(int i = 0; i<(arrayPuertas.Count); i++)
                        {
                            if(id == arrayPuertas[i].id)
                            {
                                return true;
                            }
                        }
                        //si no lo encuentra devuelvo false
                        return false;
                    }  */





        public string getInfoFabrica()
        {
            return "La fabrica: " + this.nombre + " " + "Tiene en stock: " + this.cantPuertas + " " + "puertas";
        }
        
        public  double contadorPuertas(List<Puerta> arrayPuertas)         // Contador de puertas
        {
            cantPuertas = arrayPuertas.Count;
            return cantPuertas;
        }
       
    }       
    
}
            
            

            
        
