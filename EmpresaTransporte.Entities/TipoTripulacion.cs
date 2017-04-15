using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class TipoTripulacion
    {
        public string _nombre { get; set; }

       
        public TipoTripulacion(string nombre)
        {
            this._nombre = nombre;
        }
    }
}
