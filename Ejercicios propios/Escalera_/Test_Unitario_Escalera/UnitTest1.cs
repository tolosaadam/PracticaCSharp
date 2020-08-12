using Microsoft;
using Escalera;
using System.Runtime.InteropServices.ComTypes;
using System.Runtime.InteropServices;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test_Unitario
{
    [TestClass]
    public class UnitTest1
    {
        
        [TestMethod]
        public void Testear2Escalones()
        {
            int escalones = 2;
            int resultadoEsperado = 2;

            int result = Program.Escalones(escalones);

            Assert.AreEqual(resultadoEsperado, result);

        }
       [TestMethod]
        public void Testar10Escalones() 
        {
            int escalones = 10;
            int resultadoEsperado = 89;
            
            int  result = Program.Escalones(escalones);

            Assert.AreEqual(resultadoEsperado, result);
        }

            [TestMethod]
        public void NoTestar10Escalones()
        {
            int escalones = 10;
            int resultadoEsperado = 100;
            
            int result = Program.Escalones(escalones);
            
            Assert.AreNotEqual(resultadoEsperado, result);

        }
    }
}
