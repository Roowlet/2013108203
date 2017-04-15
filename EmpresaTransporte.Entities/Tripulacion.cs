using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Tripulacion:Empleado
    {
        
        public TipoTripulacion _tipotripulacion { get; set; }

        
        public Tripulacion(string nombre, string tipotripulacion):base(nombre)
        {
            
            this._tipotripulacion = new TipoTripulacion(tipotripulacion);
        }
    }
}
