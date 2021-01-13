using System;

namespace CakculadoraSimple
{
    class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Usando o Single Responsibility Principle , principio de responsabilidade simple = cada clase cumple unha funcion moi clara e especifica e solo unha
                //Separamos o codigo en trozos de codigo coa sua propia funcion
                ConversorEntrada conversorEntrada = new ConversorEntrada();

                CalculadoraEngine motorCalculadora = new CalculadoraEngine();

                double primeiroNumero = conversorEntrada.ConvertirEntradaANumerica(Console.ReadLine());
                double segundoNumero = conversorEntrada.ConvertirEntradaANumerica(Console.ReadLine());

                string operation = Console.ReadLine();

                double resultado = motorCalculadora.Calcular(operation, primeiroNumero, segundoNumero);
                Console.WriteLine(resultado);
            }
            catch (Exception ex)
            {
                //No mundo real a quen lle importa esta mensaxe?
                //TODO: facer un log de excepcions
                Console.WriteLine(ex.Message);
            }


        }
    }
}
