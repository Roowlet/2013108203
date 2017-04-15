using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public abstract class Servicio
    {
        public Bus _bus { get; set; }

        public LugarViaje _lugarViaje { get; set; }


        public abstract void GenerarServicio();
    }
}
