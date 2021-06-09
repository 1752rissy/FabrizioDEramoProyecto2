using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tp1e2inyeccionDependencias.Modelo;

namespace tp1e2inyeccionDependencias
{
    public class Aseguradora
    {
        public string nombreAseguradora { get; set; }

        public string MostrarPoliza(Vehiculo vehiculo)
        {
            return vehiculo.marca + " " + vehiculo.modelo +" "+ vehiculo.patente; //nombreAseguradora;

        }
    }
}
