using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class TipoComprobante
    {
        public string _nombre { get; set; }


        public TipoComprobante(string nombre)
        {
            this._nombre = nombre;
        }
    }
}
