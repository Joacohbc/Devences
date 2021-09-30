using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Reserva
    {
        private int id;
        private int ci;
        private DateTime inicio;
        private DateTime fin;
        private String tipoDeIngreso;
        private int precioTotal;
        private String estado;
        private String formaDePago;

        #region Constructores
        public Reserva() { }
        #endregion

        #region Getters y Setters
        public int Id { get => id; set => id = value; }
        public int Ci { get => ci; set => ci = value; }
        public DateTime Inicio { get => inicio; set => inicio = value; }
        public DateTime Fin { get => fin; set => fin = value; }
        public string TipoDeIngreso { get => tipoDeIngreso; set => tipoDeIngreso = value; }
        public int PrecioTotal { get => precioTotal; set => precioTotal = value; }
        public string FormaDePago { get => formaDePago; set => formaDePago = value; }
        public string Estado { get => estado; set => estado = value; }
        #endregion
    }
}
