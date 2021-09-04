using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Integrantes
    {
        private String ci;
        private String tipoDeIngreso;

        public Integrantes(string ci, string tipoDeIngreso)
        {
            this.Ci = ci;
            this.TipoDeIngreso = tipoDeIngreso;
        }

        public string Ci { get => ci; set => ci = value; }
        public string TipoDeIngreso { get => tipoDeIngreso; set => tipoDeIngreso = value; }
    }
}
