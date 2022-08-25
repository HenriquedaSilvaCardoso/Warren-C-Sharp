using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace Console._0___TipoValor
{
    internal class Estruturas
    {
        public static void Executa()
        {
            PessoaClasse p1 = new PessoaClasse();
            p1.Nome = "Chimbinha";
            PessoaStruct p2 = new PessoaStruct();
            p2.Nome = "Joelma";
            System.Console.WriteLine(p1.Nome);                    
            System.Console.WriteLine(p2.Nome);                    

            PessoaClasse p3 = p1;
            PessoaStruct p4 = p2;
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);

            p1.Nome = "Chimbinha melhor guitarrista do mundo";
            p2.Nome = "Joelma melhor dançarina > Shakira";
            System.Console.WriteLine("Valores alterados:");
            System.Console.WriteLine(p1.Nome);
            System.Console.WriteLine(p2.Nome);
            System.Console.WriteLine(p3.Nome);
            System.Console.WriteLine(p4.Nome);
        }
    }

    struct PessoaStruct
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public byte Idade { get; set; }
    }
    class PessoaClasse
    {
        public string Nome { get; set; } 
        public string Sobrenome { get; set; }
        public int Id { get; set; }


    }
}
