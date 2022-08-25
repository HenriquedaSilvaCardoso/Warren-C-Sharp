namespace Console._99_Exercícios
{
    internal class _000Cadastro
    {
        // Crie um sistema de cadsatro de pessoas
        // 1 - O sistema deve exibir uma mensagem de boas vindas
        // 2 - Deve solicitar as seguintes informações ao usuário:
        //      Nome, Sobrenome e Idade
        // 3 - Ao fim da execução, deve exibir o nome completo e idade, juntamente com mensagem
        // de despedida 
        public static void cadastroDePessoas()
        {
            System.Console.WriteLine("Boas Vindas!");

            System.Console.WriteLine("Insira seu primeiro nome: ");
            string nome = System.Console.ReadLine();
            System.Console.WriteLine("Insira seu segundo nome ou sobrenome: ");
            string sobrenome = System.Console.ReadLine();
            System.Console.WriteLine("Insira a sua idade: ");
            byte idade = System.Convert.ToByte(System.Console.ReadLine());

            System.Console.WriteLine($@"
Seu nome completo é {nome} {sobrenome}.
Sua idade é {idade} anos.
Obrigado e volte sempre!");
        }
    }
}