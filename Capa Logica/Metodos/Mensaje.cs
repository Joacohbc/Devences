using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_de_Datos
{
    public class Mensaje
    {
        private const string errorBd = "Error al conectarse con la Base de Datos";
        /// <summary>
        /// Tiene el valor: "Error al conectarse con la Base de Datos"
        /// </summary>
        public static string ErrorBD => errorBd;

        private const string errorIngreso = "Error de ingreso";
        /// <summary>
        /// Tiene el valor: "Error de ingreso"
        /// </summary>
        public static string ErrorIngreso => errorIngreso;

        #region Metodos
        /// <summary>
        /// Muestra un mensaje de Si o No, si se clickea Si retorna true, sino retorna false
        /// </summary>
        /// <param name="texto"> El texto que se va a mostrar </param>
        /// <param name="titulo"> El titulo del mensaje</param>
        /// <returns>Retorna true si el usuario selecciono Si, y false si selecciono No</returns>
        public static bool MostraPreguntaSiNo(String texto, String titulo)
        {
            DialogResult op = MessageBox.Show(texto, titulo, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(op == DialogResult.Yes)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Muestra un mensaje de error
        /// </summary>
        /// <param name="texto"> El texto que se va a mostrar </param>
        /// <param name="titulo"> El titulo del error </param>
        public static void MostrarError(String texto, String titulo)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        /// <summary>
        /// Muestra un mensaje de informacion
        /// </summary>
        /// <param name="texto"> El texto que se va a mostrar </param>
        /// <param name="titulo"> El titulo del mensaje </param>
        public static void MostrarInfo(String texto, String titulo)
        {
            MessageBox.Show(texto, titulo, MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        #endregion
    }
}
