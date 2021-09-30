using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Persona
    {
        private int ci;
        private String primerNombre;
        private String segundoNombre;
        private String primerApellido;
        private String segundoApellido;
        private String genero;
        private DateTime fechaNacimiento;
        private String mail;
        private String direccion;
        private List<String> telefonos;

        #region Contructores
        /// <summary>
        /// Contructor vacio
        /// </summary>
        public Persona()
        {
            this.telefonos = new List<string>();
        }
        #endregion

        #region Getters y Setters
        public int Ci { get => ci; set => ci = value; }
        public string PrimerNombre { get => primerNombre; set => primerNombre = value; }
        public string SegundoNombre { get => segundoNombre; set => segundoNombre = value; }
        public string PrimerApellido { get => primerApellido; set => primerApellido = value; }
        public string SegundoApellido { get => segundoApellido; set => segundoApellido = value; }
        public string Genero { get => genero; set => genero = value; }
        public DateTime FechaNacimiento { get => fechaNacimiento; set => fechaNacimiento = value; }
        public string Mail { get => mail; set => mail = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public List<string> Telefonos { get => telefonos; set => telefonos = value; }
        #endregion

    }
}
