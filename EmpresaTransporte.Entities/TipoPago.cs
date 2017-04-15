using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class TipoPago
    {
        public string _nombre { get; set; }


        public TipoPago(string nombre)
        {
            this._nombre = nombre;
        }
    }
}
