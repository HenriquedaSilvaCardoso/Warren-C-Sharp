using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1___TipoReferencia
{
    internal class PessoaJuridica : Pessoa
    {
        public PessoaJuridica(string nome, string sobrenome, string cnpj) : base(nome, sobrenome)
        {
            this.Cnpj = cnpj;
        }

        public string Cnpj { get; set; }

        public override string Saudacao()
        {
            return $"{base.Saudacao()} + {this.Cnpj}";
        }
    }
}
