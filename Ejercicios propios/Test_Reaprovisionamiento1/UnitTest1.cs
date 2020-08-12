using NUnit.Framework;
using Reaprovisionamiento;
using System.Collections.Generic;
using System.Linq;

namespace Test_Reaprovisionamiento1
{
    public class Tests
    {
        private static string _path = @"C:\Users\Adam\Desktop\TestCase1.json";



        [Test]
        public void GetCustomerTest()
        {
            var jsonString = Program.GetJson(_path);
            List<Product> products = new List<Product>();
            products.Add(new Product() { name = "Tidy Cats 2KG", sku = "102" });
            products.Add(new Product() { name = "Cat Chow 1KG", sku = "101" });
            var test = Program.GetCustomer(jsonString);
            var testProducts = test.SelectMany(x => x.purchases).ToList().SelectMany(y => y.products).ToList();
            Assert.IsTrue(testProducts.Any(x => x.name == products.First().name && x.sku == products.First().sku));
            Assert.IsTrue(testProducts.Any(x => x.name == products.Last().name && x.sku == products.Last().sku));
        }
        [Test]
        public void calcularFechaTest()
        {
            var jsonString = Program.GetJson(_path);
            var purchasesTest = new List<Purchase>();
            var producto1 = new Product() { name = "Cat Chow 1KG", sku = "101" };
            var producto2 = new Product() { name = "Tidy Cats 2KG", sku = "102" };
            var purchase1 = new Purchase() { date = "3/30/2020", number = "0", products = new List<Product>() };
            purchase1.products.Add(producto1);
            var purchase2 = new Purchase() { date = "4/30/2020", number = "0", products = new List<Product>() };
            purchase2.products.Add(producto2);
            purchasesTest.Add(purchase1);
            purchasesTest.Add(purchase2);

            var test = Program.calcularFecha(jsonString);
            var testJson = Newtonsoft.Json.JsonConvert.SerializeObject(test);
            var testJson2 = Newtonsoft.Json.JsonConvert.SerializeObject(purchasesTest);
            Assert.AreEqual(testJson, testJson2);
        }
     
    }
}




