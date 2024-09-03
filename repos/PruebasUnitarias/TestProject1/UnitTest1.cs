
using PruebasUnitarias;
namespace TestProject1


{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void sumar_devolver_resultado_suma()
        {

            //ARRANGE == variables
            int num1 = 10;
            int num2 = 20;
            int resultado = 30;
            //ACT == métodos a probar
            int suma_resultado = Calculadura.sumar(num1, num2);
            //ASSERT == comprobación de los métodos
            Assert.AreEqual(resultado, suma_resultado);

            
        }

        [TestMethod]
        public void restar_devolver_resultado_resta() {
            int num1 = 10;
            int num2 = 20;
            int resultado2 = -10;
            int resta_resultado = Calculadura.restar(num1, num2);
            Assert.AreEqual(resultado2, resta_resultado);

        }

        [TestMethod]
        public void es_nulo()
        {
            string texto = "Jamoncito";
            bool nulo_resultado = Calculadura.nulo(texto);
            Assert.AreEqual(resultado, nulo_resultado);

        }

        //-------------------------

        [TestMethod]
        public void divi_devolver_resultado_divi()
        {
            int num1 = 14;
            int num2 = 2;
            double resultado = 7;
            int divi_resultado = Calculadura.dividir(num1, num2);
            Assert.AreEqual(resultado, divi_resultado);

        }

        [TestMethod]
        public void es_par()
        {
            int num1 = 14;
            bool resultado = true;
            bool divi_resultado = Calculadura.par(num1);
            Assert.AreEqual(resultado, divi_resultado);

        }








    }
}