using System;

namespace CoversorDolarEEuro062020
{
    class Program
    {
        static void Main(string[] args)
        {   
            System.Console.WriteLine("Dolar Para Real");
            System.Console.WriteLine(Conversor.ConverterDolarParaReal(72));
            System.Console.WriteLine("Real Para Dolar");
            System.Console.WriteLine(Conversor.ConverterRealParaDolar(100));
            System.Console.WriteLine("Euro Para Real");
            System.Console.WriteLine(Conversor.ConverterEuroParaReal(25));
            System.Console.WriteLine("Real Para Euro");
            System.Console.WriteLine(Conversor.ConverterRealParaEuro(87));
        }
    }
}
