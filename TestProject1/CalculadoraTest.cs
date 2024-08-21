using AulasPOO.uteis;
using System.Net.Http.Headers;

namespace TestProject1
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void SomaTest()
        {
            //cen�rio
            var calc = new Calculadora();
            int num1 = 20;
            int num2 = 22;
            int result;
            //a��o
            result = calc.Soma(num1, num2);
            //teste
            Assert.AreEqual(42, result);
        }

        [TestMethod]
        public void MultTest()
        {
            //cen�rio
            int num1 = 20;
            int num2 = 2;
            int result;
            //a��o
            result = Calculadora.Mult(num1, num2);
            //teste
            Assert.AreEqual(40, result);
        }

        [TestMethod]
        public void ImcTest()
        {
            //cen�rio
            float peso = 87.5f;
            float altura = 1.8f;
            float imc;
            //a��o
            imc = Calculadora.IMC(peso, altura);
            //test
            Assert.AreEqual(27.01,Math.Round(imc,2));
        }
    }
}