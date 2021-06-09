using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1e2inyeccionDependencias.Modelo;

namespace tp1e2inyeccionDependencias
{
    class Program
    {
        static void Main(string[] args)
        {
            RegistroAutomotor registroAutomotor = new RegistroAutomotor();
            Aseguradora aseguradora = new Aseguradora();
            Consesionaria consesionaria = new Consesionaria(registroAutomotor, aseguradora);
            Cliente cliente = new Cliente();
            Vehiculo vehiculo = new Vehiculo();

            cliente.nombre = "Fabrizio";
            cliente.apellido = "D'Eramo";
            cliente.dni = "41066928";

            vehiculo.marca = "Chevrolet";
            vehiculo.modelo = "Corsa";
            vehiculo.patente = "HRO 112";

            Console.WriteLine(registroAutomotor.GenerarAltaTitular(cliente));
            Console.WriteLine(registroAutomotor.GenerarPatentamiento(vehiculo));
            Console.WriteLine(consesionaria.TramitarAltaTitular(cliente,vehiculo));
            Console.WriteLine(consesionaria.TramitarAltaVehiculo(vehiculo));
            Console.ReadLine();

            
        }


        }
    }

