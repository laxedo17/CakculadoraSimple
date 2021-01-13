using CakculadoraSimple;

using Microsoft.VisualStudio.TestTools.UnitTesting;

using System;
using System.Collections.Generic;
using System.Text;

namespace CalculadoraSimple.Test.Unit
{
    [TestClass]
    public class ConversorEntradaTest
    {
        private readonly ConversorEntrada conversorEntrada = new ConversorEntrada();

        [TestMethod]
        public void ConvertirEntradaDeStringValidaADouble()
        {
            string numeroEntrada = "5";
            double numeroConvertido = conversorEntrada.ConvertirEntradaANumerica(numeroEntrada);
            Assert.AreEqual(5, numeroConvertido);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))] //atributo que espera algun tipo de excepcion, que queremos saber se se cumple
        public void FallaConversionDeEntradaDeStringNonValidaANumeroDouble()
        {
            string numeroEntrada = "*";
            double numeroConvertido = conversorEntrada.ConvertirEntradaANumerica(numeroEntrada);
        }
    }
}
