namespace Console._0___TipoValor
{
    internal class TipoNumerico2
    {
        public static void Executa()
        {
            char letra = 'A';
            System.Console.WriteLine($"Char: {letra}");

            char charMin = char.MinValue;
            char charMax = char.MaxValue;

            System.Console.WriteLine($"Char min: {charMin}\nChar max: {charMax}");

            System.Console.WriteLine($"Letra A: {(byte)letra}");
        }
    }
}