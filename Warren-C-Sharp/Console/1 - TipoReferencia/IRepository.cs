using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1___TipoReferencia
{
    internal interface IRepository
    {
        string Create(Pessoa pessoa);
        string Update(Pessoa pessoa);
        string Delete(int id);
        List<Pessoa> Read();
    }
}
