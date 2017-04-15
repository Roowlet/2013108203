using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Encomienda : Servicio
    {
        public string _destinatario { get; set; }
        public double _pesoKilo { get; set; }

        public double _precio { get; set; }

        public static double precioxkilo = 5.00;

    //contructor
    public Encomienda(string destinatario, double peso,LugarViaje lugarViaje, Bus bus)
        {
            this._destinatario = destinatario;
            this._lugarViaje = lugarViaje;
            this._pesoKilo = peso;
            this._bus = bus;
        }

        public override void GenerarServicio()
        {
            this._precio = precioxkilo * _pesoKilo;
        }
    }
}
