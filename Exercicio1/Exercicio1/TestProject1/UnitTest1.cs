using Exercicio1;

namespace TestProject1
{
    [TestClass]
    public class CalculoTest
    {
        [TestMethod]
        public void TestSomaCorreta()
        {
            var calc = new Calculos();
            Assert.AreEqual(3, calc.Somar(1, 2));
        }

        [TestMethod]
        public void TestSubtracaoCorreta()
        {
            var calc = new Calculos();
            Assert.AreEqual(1, calc.Subtrair(1, 2));
        }

        [TestMethod]
        public void TestDivisaoCorreta()
        {
            var calc = new Calculos();
            Assert.AreEqual(2, calc.Dividir(1, 2));
        }

        [TestMethod]
        public void TestMultiplicacaoCorrete()
        {
            var calc = new Calculos();
            Assert.AreEqual(2, calc.Multiplicar(1, 2));
        }

        [TestMethod]
        public void TestValorParImparPar()
        {
            var calc = new Calculos();
            Assert.AreEqual("par", calc.ValorParImpar(2));
        }

        [TestMethod]
        public void TestValorParImparImpar()
        {
            var calc = new Calculos();
            Assert.AreEqual("impar", calc.ValorParImpar(1));
        }
    }
}