using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Transporte : Servicio
    {
        public Cliente _cliente { get; set; }
        public TipoViaje _tipoViaje { get; set; }

        public Transporte(string nombre, LugarViaje lugarViaje, Bus bus)
        {
            this._cliente = new Cliente(nombre);
            this._lugarViaje = lugarViaje;
            this._bus = bus;
            this._tipoViaje = new TipoViaje("");
            
        }
        public override void GenerarServicio() {
            if (_bus._tipo == "NORMAL")
            {
                _tipoViaje._nombre = "Normal";
            }
            else if (_bus._tipo == "CAMA")
            {
                _tipoViaje._nombre = "VIP";
            }
            else
            {

            }
        }
    }
}
