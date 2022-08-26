using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Console._1___TipoReferencia
{
    internal class Animal : BaseModel
    {
        public Animal(string espécie, string raca, char sexo, string som)
        {
            Espécie = espécie;
            Raca = raca;
            Sexo = sexo;
            Som = som;
        }
        public string Espécie { get; set; }
        public string Raca { get; set; }
        public char Sexo { get; set; }
        public string Som { get; set; }
        
        
        public string SomQueFaz()
        {
            return this.Som;
        }
    }
}
