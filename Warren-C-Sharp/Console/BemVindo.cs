namespace Console
{
    internal class BemVindo
    {
        // Passo argumentos e recebo parâmetros
        public static void Mensagem()
        {
            System.Console.WriteLine("Seja bem-vindo");
            System.Console.WriteLine("Digite seu nome:");
            string name = System.Console.ReadLine();
            System.Console.WriteLine($"Olá {name}");
            System.Console.ReadLine();
        }
    }
}