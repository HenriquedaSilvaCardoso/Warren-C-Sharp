﻿using System.Collections.Generic;

namespace Console._1___TipoReferencia
{
    internal class PessoaFisicaRepository
    {
        // CRUD - Create, Read, Update, Delete

        private List<PessoaFisica> pessoas;

        public PessoaFisicaRepository()
        {
            this.pessoas = new List<PessoaFisica>();
        }

        public string Create(PessoaFisica pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Pessoa: {pessoa.Nome}, Salva com sucesso";
        }

        public List<PessoaFisica> Read()
        {
            return this.pessoas;
        }

        public string Update(PessoaFisica pessoa)
        {
            return $"Pessoa: {pessoa.Nome} alterada com sucesso!";
        }

        public string Delete(int id)
        {
            return $"Pessoa de id: {id} deletada com sucesso";
        }
    }
}
