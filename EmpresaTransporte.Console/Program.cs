using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmpresaTransporte.Entities;



namespace EmpresaTransporte.Console
{
    class Program
    {
        
        static void Main(string[] args)
        {
            var cliente1 = "Andres Salazar";
            var cliente2 = "Katia Perez";
            var cliente3 = "Marcelo Luca";
            var cliente4 = "Manuel Herrera";
            var cliente5 = "Luis Villegas";

            var admin = "Antonio Rosales";

            var tipoComprobante1 = "Boleta";
            var tipoComprobante2 = "Factura";

            var tipoPago1 = "Efectivo";
            var tipoPago2 = "Tarjeta";


            var lugar1 =new LugarViaje( "Lima", "Nacional");
            var lugar2 = new LugarViaje("Arica", "Extrangero");


            var bus1 = new Bus("A6Y-123", "NORMAL");
            bus1.AgregarTripulacion("Ana Rosales", "Terramoza");
            bus1.AgregarTripulacion("Gabriel Benites", "Chofer1");

            var bus2 = new Bus("H6O-173", "CAMA");
            bus2.AgregarTripulacion("Florencia Martinez", "Terramoza");
            bus2.AgregarTripulacion("Juan Patricio", "Chofer2");

            //PASAJE 1:
            var transporte1 = new Transporte(cliente1,lugar1,bus1);
            transporte1.GenerarServicio();
            var venta1 = new Venta(transporte1);
            venta1.GenerarVentaTransporte(transporte1._cliente._nombre, admin, tipoComprobante1, tipoPago1,"1");

            //PASAJE 2:
            var transporte2 = new Transporte(cliente2, lugar2, bus2);
            transporte2.GenerarServicio();
            var venta2 = new Venta(transporte2);
            venta2.GenerarVentaTransporte(transporte2._cliente._nombre, admin, tipoComprobante2, tipoPago2, "2");

            //PASAJE 3:
            var transporte3 = new Transporte(cliente3, lugar1, bus2);
            transporte3.GenerarServicio();
            var venta3 = new Venta(transporte3);
            venta3.GenerarVentaTransporte(transporte3._cliente._nombre, admin, tipoComprobante1, tipoPago2, "3");

            //ENCOMIENDA 1:
            var destinatario1 = "Juana Maria Porras";
            var peso1 = 12.00;

            var encomienda1 = new Encomienda(destinatario1,peso1,lugar1,bus2);
            encomienda1.GenerarServicio();
            var venta4 = new Venta(encomienda1);
            venta4.GenerarVentaEncomienda(cliente4,admin,tipoComprobante1, tipoPago2,"1");

            //ENCOMIENDA 2:
            var destinatario2 = "Liliana Perez";
            var peso2 = 6.00;

            var encomienda2 = new Encomienda(destinatario2, peso2, lugar2,bus1);
            encomienda2.GenerarServicio();
            var venta5 = new Venta(encomienda2);
            venta5.GenerarVentaEncomienda(cliente5, admin, tipoComprobante2, tipoPago1, "2");
        }
        
    }
}
