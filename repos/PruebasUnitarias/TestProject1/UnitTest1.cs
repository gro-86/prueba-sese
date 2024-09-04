
using PruebasUnitarias;
namespace TestProject1


{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Mostrar_Prueba()
        {
            Vino vino1 = new Vino("Bernal", "Rosado");
            String tipo = "Rosado";
           
            string resultado = vino1.MostrarInformacion(vino1);
            
            Assert.AreEqual(tipo, resultado);

            
        }

       


    }
}