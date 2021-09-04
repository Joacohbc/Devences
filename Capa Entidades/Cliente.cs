using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_Entidades
{
    public class Cliente : Persona
    {
        private bool estado;
        private DateTime fechaRegistro;

        #region Constructores
        public Cliente() : base()
        {
            //Instacio los telefonos para que no sea null
            Telefonos = new List<string>();

            //Predeterninadamente esta dado de alta
            estado = true;
        }
        #endregion

        #region Getters y Setters
        public bool Estado { get => estado; set => estado = value; }
        public DateTime FechaRegistro { get => fechaRegistro; set => fechaRegistro = value; }
        #endregion
    }
}
