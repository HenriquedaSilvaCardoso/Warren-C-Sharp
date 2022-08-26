using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1___TipoReferencia
{
    internal class BaseRepository<T> : IRepository<T> where T : BaseModel
    {
        List<T> objetos;

        public BaseRepository()
        {
            this.objetos = new List<T>();
        }

        virtual public string Create(T objeto)
        {
            this.objetos.Add(objeto);
            return $"O dado de id : {objeto.Id}, Salva com sucesso";
        }

        virtual public string Delete(int id)
        {
            this.objetos.RemoveAt(id);
            return $"O dado de id: {id} deletada com sucesso";
        }

        virtual public List<T> Read()
        {
            return this.objetos;
        }

        virtual public string Update(T objeto)
        {
            return $"O dado de id: {objeto.Id} alterada com sucesso!";
        }

    }
}
