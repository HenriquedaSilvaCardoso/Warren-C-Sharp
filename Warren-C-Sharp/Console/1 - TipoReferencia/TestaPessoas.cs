using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1___TipoReferencia
{
    internal class TestaPessoas
    {

        public static void ExecutaPessoa()
        {
            Pessoa p1 = new Pessoa("Henrique", "da Silva Cardoso");
            Pessoa pf1 = new PessoaFisica("A", "B", "C");
            Pessoa pj1 = new PessoaJuridica("D", "E", "F");

            // Não é possível atribuir sem de declarar explicitamente porque Pessoa se encontra mais alta na árvore de herança
            // Mesmo que os dados estejam presentes é necessário explicar ao C# que o Pessoa que se encontra ali realmente cumprirá
            // os requisitos para a classe que se encontra mais baixo na árvore de herança
            PessoaFisica pf2 = (PessoaFisica)pf1;
            PessoaJuridica pj2 = (PessoaJuridica)pj1;

            BaseRepository repo = new BaseRepository();
            repo.Create(p1);
            repo.Create(pf2);
            repo.Create(pj2);

            foreach(var p in repo.Read())
            {
                System.Console.WriteLine(p.Saudacao());
            }

        }
        public static void ExecutaFisica()
        {
            PessoaFisica pessoaFisica0 = new PessoaFisica("Henrique", "da Silva Cardoso", "09391020992");
            PessoaFisica pessoaFisica1 = new PessoaFisica("Pimbas", "Juras", "12345678910");
            PessoaFisica pessoaFisica2 = new PessoaFisica("A", "AA", "AAA");
            PessoaFisica pessoaFisica3 = new PessoaFisica("B", "BB", "BBB");
            PessoaFisica pessoaFisica4 = new PessoaFisica("C", "CC", "CCC");

            //pessoaFisica.GetType();

            //string msg = typeof().Name ;
            //System.Console.WriteLine(msg);

            var pessoaFisicaRepository = new PessoaFisicaRepository();
            pessoaFisicaRepository.Create(pessoaFisica0);
            pessoaFisicaRepository.Create(pessoaFisica1);
            pessoaFisicaRepository.Create(pessoaFisica2);
            pessoaFisicaRepository.Create(pessoaFisica3);
            pessoaFisicaRepository.Create(pessoaFisica4);

            List<PessoaFisica> pessoaFisicaList = pessoaFisicaRepository.Read();
            foreach (var pessoa in pessoaFisicaList)
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }
        }

        public static void ExecutaJuridica()
        {
            var pessoaJuridica0 = new PessoaJuridica("Henrique", "da Silva Cardoso", "12345678910111");
            var pessoaJuridica1 = new PessoaJuridica("Dale", "meu", "Parceiro");
            var pessoaJuridicaRepository = new PessoaJuridicaRepository();
            pessoaJuridicaRepository.Create(pessoaJuridica0);
            pessoaJuridicaRepository.Create(pessoaJuridica1);

            foreach (var pessoa in pessoaJuridicaRepository.Read())
            {
                System.Console.WriteLine(pessoa.Saudacao());
            }
        }
    }
}
