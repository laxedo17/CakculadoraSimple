using System;
using System.Collections.Generic;
using System.Text;

namespace CakculadoraSimple
{
    public class ConversorEntrada
    {
        public double ConvertirEntradaANumerica(string entradaUsuario)
        {
            double numeroConvertido;
            if (!double.TryParse(entradaUsuario, out numeroConvertido))
            {
                throw new ArgumentException("O valor que entra o/a usuario/a debe ser numerico");
            }
            return numeroConvertido;
        }
    }
}
