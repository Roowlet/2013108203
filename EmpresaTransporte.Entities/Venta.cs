using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmpresaTransporte.Entities
{
    public class Venta
    {
        List<Cliente> _Clientes;
        public Administrativo _administrativo;
        public TipoComprobante _tipoComprobante;
        public TipoPago _tipoPago;

        public Transporte _servicio;
        public Encomienda _servicio2;

        public Venta(Transporte servicio)
        {
            this._servicio = servicio;
            _Clientes = new List<Cliente>();
        }

        public Venta(Encomienda servicio2)
        {
            this._servicio2 = servicio2;
            _Clientes = new List<Cliente>();
        }

        public void GenerarVentaTransporte(string nomCliente, string nomAdmin, string tipoCompr, string tipoPago, string numVenta)
        {
            if (nomCliente != "")
            {
                _Clientes.Add(new Cliente(nomCliente));
            }
            this._administrativo = new Administrativo(nomAdmin);
            this._tipoComprobante = new TipoComprobante(tipoCompr);
            this._tipoPago = new TipoPago(tipoPago);
            Console.WriteLine("DATOS DE VENTA DE PASAJES N°"+numVenta);
            Console.WriteLine("Cliente:  "+nomCliente);
            Console.WriteLine("Administrador:  " + nomAdmin);
            Console.WriteLine("Tipo de Comprobante:  " + tipoCompr);
            Console.WriteLine("Tipo de Pago:  " + tipoPago);
            Console.WriteLine("SERVICIO DE TRANSPORTE");
            Console.WriteLine("Lugar de viaje:  " + _servicio._lugarViaje._nombre);
            Console.WriteLine("Tipo de lugar:  " + _servicio._lugarViaje._tipolugar._nombre);
            Console.WriteLine("Tipo de viaje:  " + _servicio._tipoViaje._nombre);
            Console.WriteLine("BUS:");
            Console.WriteLine("Tipo de bus:  BUS " + _servicio._bus._tipo);
            Console.WriteLine("Placa:  " + _servicio._bus._placa);
            Console.WriteLine("Tripulacion:  ");
            foreach (var trip in _servicio._bus._Tripulantes) {
                Console.WriteLine("Nombre: " +  trip._nombre + "     Tipo:  "+trip._tipotripulacion._nombre);
            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
        }
        public void GenerarVentaEncomienda(string nomCliente, string nomAdmin, string tipoCompr, string tipoPago, string numVenta)
        {
            if (nomCliente != "")
            {
                _Clientes.Add(new Cliente(nomCliente));
            }
            this._administrativo = new Administrativo(nomAdmin);
            this._tipoComprobante = new TipoComprobante(tipoCompr);
            this._tipoPago = new TipoPago(tipoPago);
            Console.WriteLine("DATOS DE SERVICIO DE ENCOMIENDA VENDIDO N°" + numVenta);
            Console.WriteLine("Cliente:  " + nomCliente);
            Console.WriteLine("Administrador:  " + nomAdmin);
            Console.WriteLine("Tipo de Comprobante:  " + tipoCompr);
            Console.WriteLine("Tipo de Pago:  " + tipoPago);
            Console.WriteLine("SERVICIO DE ENCOMIENDA");
            Console.WriteLine("Destinatario:  " + _servicio2._destinatario);
            Console.WriteLine("Peso en Kilos:  " + _servicio2._pesoKilo);
            Console.WriteLine("Precio total:  " + _servicio2._precio);
            Console.WriteLine("Lugar de viaje:  " + _servicio2._lugarViaje._nombre);
            Console.WriteLine("Tipo de lugar:  " + _servicio2._lugarViaje._tipolugar._nombre);
            Console.WriteLine("BUS:");
            Console.WriteLine("Tipo de bus:  BUS " + _servicio2._bus._tipo);
            Console.WriteLine("Placa:  " + _servicio2._bus._placa);
            Console.WriteLine("Tripulacion:  ");
            foreach (var trip in _servicio2._bus._Tripulantes)
            {
                Console.WriteLine("Nombre: " + trip._nombre + "     Tipo:  " + trip._tipotripulacion._nombre);
            }
            Console.WriteLine("  ");
            Console.WriteLine("  ");
            if (numVenta == "2")
            {
                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }

        }
    }
}
