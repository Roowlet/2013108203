using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class LugarViaje
    {
        public string _nombre { get; set; }
         public TipoLugar _tipolugar { get; set; }

        //contructor
        public LugarViaje(string nombre, string nombreTipoLugar)
        {
            this._nombre = nombre;
            this._tipolugar = new TipoLugar(nombreTipoLugar);
        }

    }
}
