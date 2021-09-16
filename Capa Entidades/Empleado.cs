using System.Collections.Generic;

namespace Capa_Entidades
{
    public class Empleado : Persona
    {
        private int ci;
        private string usuario;
        private string contra;
        private int tipo;
        private bool estado;

        #region Constructores
        public Empleado() : base()
        {
            Telefonos = new List<string>();
            estado = true;
        }
        #endregion

        #region Getters y Setters
        public string Usuario { get => usuario; set => usuario = value; }
        public string Contra { get => contra; set => contra = value; }
        public int Tipo { get => tipo; set => tipo = value; }
        public bool Estado { get => estado; set => estado = value; }
        #endregion

    }
}
