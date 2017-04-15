using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class TipoViaje
    {
        public string _nombre { get; set; }

        //contructor
        public TipoViaje(string nombre)
        {
            this._nombre = nombre;

        }
    }
}
