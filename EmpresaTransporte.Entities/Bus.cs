using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Bus
    {
        public string _placa { get; set; }
        public string _tipo { get; set; }

        public List<Tripulacion> _Tripulantes;

        public Bus(string placa, string tipo)
        {
            this._placa = placa;
            this._tipo = tipo;
            _Tripulantes = new List<Tripulacion>();
        }

        public void AgregarTripulacion(string nom, string tipotripulacion)
        {

            _Tripulantes.Add(new Tripulacion(nom, tipotripulacion));
        }

        
    }
}
