using System;

namespace Console._0___TipoValor
{
    internal class TipoNumerico3
    {
        public static void Executa()
        {
            float floatMin = float.MinValue;
            float floatMax = float.MaxValue;
            System.Console.WriteLine($"Float Min: {floatMin}");
            System.Console.WriteLine($"Float Max: {floatMax}\n");

            Single singleMin = Single.MinValue;
            Single singleMax = Single.MaxValue;
            System.Console.WriteLine($"Single Min: {singleMin}");
            System.Console.WriteLine($"Single Max: {singleMax}\n");

            double doubleMin = double.MinValue;
            double doubleMax = double.MaxValue;
            System.Console.WriteLine($"Double Min: {doubleMin}");
            System.Console.WriteLine($"Double Max: {doubleMax}\n");

            decimal decimalMin = decimal.MinValue;
            decimal decimalMax = decimal.MaxValue;
            System.Console.WriteLine($"Decimal Min: {decimalMin}");
            System.Console.WriteLine($"Decimal Max: {decimalMax} \n");

            double n1 = 10.10;
            double n2 = 20.20;
            double result = 30.3;

            System.Console.WriteLine($"{n1 + n2} é igual a {result}");
            System.Console.WriteLine(((n1 + n2) == result) + "\n");

            decimal n1d = 10.10m;
            decimal n2d = 20.20m;
            decimal resultd = 30.3m;

            System.Console.WriteLine($"{n1d + n2d} é igual a {resultd}");
            System.Console.WriteLine((n1d + n2d) == resultd);
        }
    }
}