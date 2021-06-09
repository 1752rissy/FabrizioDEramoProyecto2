using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1e2inyeccionDependencias.Modelo;

namespace tp1e2inyeccionDependencias
{
    public class RegistroAutomotor
    {
        public string NombreRegistro { get;set; }

        public string GenerarPatentamiento(Vehiculo vehiculo)
        {
            return "Patentamiento generado: " + vehiculo.marca + " "  + vehiculo.patente;
        }

        public string GenerarAltaTitular(Cliente cliente)
        {
            return " Titular Dado de Alta:  " + cliente.apellido + " " + cliente.dni;
        }


        }
    }
