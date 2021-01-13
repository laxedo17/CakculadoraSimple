using System;
using System.Collections.Generic;
using System.Text;

namespace CakculadoraSimple
{
    public class CalculadoraEngine
    {
        public double Calcular(string argOperacion, double argPrimeiroNumero, double argSegundoNumero)
        {
            double resultado;

            switch (argOperacion.ToLower())
            {
                case "sumar":
                case "+":
                    resultado = argPrimeiroNumero + argSegundoNumero;
                    break;
                case "restar":
                case "-":
                    resultado = argPrimeiroNumero - argSegundoNumero;
                    break;
                case "multiplicar":
                case "*":
                case "x":
                    resultado = argPrimeiroNumero * argSegundoNumero;
                    break;
                case "dividir":
                case "/":
                case ":":
                    resultado = argPrimeiroNumero / argSegundoNumero;
                    break;
                default:
                    throw new InvalidOperationException("Non se recoñece a operacion");

            }

            return resultado;
        }
    }
}
