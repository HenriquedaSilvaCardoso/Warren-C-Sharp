using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1___TipoReferencia
{
    internal class BaseRepository : IRepository
    {
        List<Pessoa> pessoas;
        
        public BaseRepository()
        {
            this.pessoas = new List<Pessoa>();
        }
        public string Create(Pessoa pessoa)
        {
            this.pessoas.Add(pessoa);
            return $"Pessoa: {pessoa.Nome}, Salva com sucesso";
        }

        public string Delete(int id)
        {
            this.pessoas.RemoveAt(id);  
            return $"Pessoa de id: {id} deletada com sucesso";
        }

        public List<Pessoa> Read()
        {
            return this.pessoas;
        }

        public string Update(Pessoa pessoa)
        {
            return $"Pessoa: {pessoa.Nome} alterada com sucesso!";
        }
     }
}
