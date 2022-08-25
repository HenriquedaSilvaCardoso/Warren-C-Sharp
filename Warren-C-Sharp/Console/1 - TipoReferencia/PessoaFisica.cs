using System.Runtime.CompilerServices;

namespace Console._1___TipoReferencia
{
    internal class PessoaFisica : Pessoa
    {
        
        public PessoaFisica(string nome, string sobrenome, string cpf) : base(nome, sobrenome)
        {
            this.Cpf = cpf;
        }
        public string Cpf { get; set; }

        override
        public string Saudacao()
        {
            return $"{base.Saudacao()} - {this.Cpf}";
        }
    }
}
