
using System.Security.Cryptography.X509Certificates;

namespace PruebaUnitaria

{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void averiguar_nombre(Vino vino)
        {
            string esperado = "Tinto";
            Assert.AreEqual(esperado,)
            Console.WriteLine("Tipo de vino: "+vino.Tipo);


        }

    }
}