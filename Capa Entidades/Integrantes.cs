using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Integrantes
    {
        private int ci;
        private String tipoDeIngreso;

        public Integrantes(int ci, string tipoDeIngreso)
        {
            this.Ci = ci;
            this.TipoDeIngreso = tipoDeIngreso;
        }

        public int Ci { get => ci; set => ci = value; }
        public string TipoDeIngreso { get => tipoDeIngreso; set => tipoDeIngreso = value; }
    }
}
