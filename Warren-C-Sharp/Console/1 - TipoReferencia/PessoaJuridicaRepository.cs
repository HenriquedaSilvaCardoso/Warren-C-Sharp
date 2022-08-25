using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal class PessoaJuridicaRepository
    {
        // CRUD - Create, Read, Update, Delete

        private List<PessoaJuridica> pessoas;

        public PessoaJuridicaRepository()
        {
            this.pessoas = new List<PessoaJuridica>();
        }

        public string Create(PessoaJuridica pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Pessoa: {pessoa.Nome}, Salva com sucesso";
        }

        public List<PessoaJuridica> Read()
        {
            return this.pessoas;
        }

        public string Update(PessoaJuridica pessoa)
        {
            return $"Pessoa: {pessoa.Nome} alterada com sucesso!";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} deletada com sucesso";
        }
    }
}
