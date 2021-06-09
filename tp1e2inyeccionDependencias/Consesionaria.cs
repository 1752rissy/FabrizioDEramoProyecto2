using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1e2inyeccionDependencias.Modelo;

namespace tp1e2inyeccionDependencias
{
    public class Consesionaria
    {
        private readonly RegistroAutomotor _registroAutomotor;
        private readonly Aseguradora _aseguradora;

        public string NombreConsesionaria { get; set; }

        public Consesionaria (RegistroAutomotor registroAutomotor, Aseguradora aseguradora)
        {
            _registroAutomotor = registroAutomotor;
            _aseguradora = aseguradora;
        }

        public string TramitarAltaVehiculo(Vehiculo vehiculo)
        {
            return _registroAutomotor.GenerarPatentamiento(vehiculo);

        }

        public string TramitarAltaTitular(Cliente cliente,Vehiculo vehiculo)
        {
            //return _registroAutomotor.GenerarAltaTitular(cliente);
            //return _aseguradora.MostrarPoliza(vehiculo);

            return _aseguradora.MostrarPoliza(vehiculo) + _registroAutomotor.GenerarAltaTitular(cliente);
        }

    }
}
