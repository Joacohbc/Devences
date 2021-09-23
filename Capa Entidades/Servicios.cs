using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Servicios
    {
        private String nombre;
        private TimeSpan duracion;
        private int capacidadMaxima;
        private int cantidad;
        private int precio;

        public Servicios(string nombre, TimeSpan duracion, int capacidadMaxima, int cantidad, int precio)
        {
            this.nombre = nombre;
            this.Duracion = duracion;
            this.capacidadMaxima = capacidadMaxima;
            this.cantidad = cantidad;
            this.precio = precio;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public TimeSpan Duracion { get => duracion; set => duracion = value; }
        public int CapacidadMaxima { get => capacidadMaxima; set => capacidadMaxima = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public int Precio { get => precio; set => precio = value; }
    }
}
