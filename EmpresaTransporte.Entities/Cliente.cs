using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Cliente
    {
        public string _nombre { get; set; }
        
        //contructor
        public Cliente(string nombre)
        {
            this._nombre = nombre;
         
        }
    }
}
