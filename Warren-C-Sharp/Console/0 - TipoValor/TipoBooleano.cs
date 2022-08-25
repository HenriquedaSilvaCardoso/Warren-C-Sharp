namespace Console._0___TipoValor
{
    internal class TipoBooleano
    {
        public static void Executa()
        {
            bool gostaDeCalypso = true;
            bool naoGostaDeSteven = false;

            bool emaior = 10 > 11;
            bool eigual = 10 + 11 == 21;
            if (emaior)
            {
                System.Console.WriteLine("É maior");
            }
            else
            {
                System.Console.WriteLine("É menor");
            }
        }
    }
}