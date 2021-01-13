using CakculadoraSimple;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraSimple.Test.Unit
{
    [TestClass]
    public class CalculadoraEngineTest
    {
        private readonly CalculadoraEngine _calculadoraEngine = new CalculadoraEngine();

        [TestMethod]
        public void SumaDousNumerosEDevolveResultadoValidoEnOperacionsSenSimbolo()
        {
            int numero1 = 1;
            int numero2 = 2;
            double resultado = _calculadoraEngine.Calcular("sumar", numero1, numero2);
            Assert.AreEqual(3, resultado);
        }

        [TestMethod]
        public void SumaDousNumerosEDevolveResultadoValidoEnOperacionsConSimbolo()
        {
            int numero1 = 1;
            int numero2 = 2;
            double resultado = _calculadoraEngine.Calcular("+", numero1, numero2);
            Assert.AreEqual(3, resultado);
        }
    }
}
