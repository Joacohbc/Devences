using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class Bajas
    {
        private Conexion conexion;

        private readonly int ci;

        //Para el alta de un Nuevo Registro
        private Altas altas;

        public Bajas(int rol, int ci)
        {
            this.conexion = new Conexion(rol);
            this.ci = ci;
            this.altas = new Altas(rol, ci);
        }

        /// <summary>
        /// Cancela la reserva indicada
        /// </summary>
        /// <param name="id"> El id de la reserva</param>
        /// <returns> +0 si la dio de baja y -1 si ocurrio un error</returns>
        public int cancelarReserva(int id)
        {
            //Sentecia decalra fuera del try-catch para poder enviarla al NuevoRegistro
            String sentencia = String.Format("UPDATE reserva SET estado='Cancelada' WHERE id='{0}'", id);

            //Esta variable si esta en false no dara ingresara el nuevo resgistro y si es true 
            //si lo hara. SI es false si entre al catch, osea que hubo un error
            bool ingresoRegistro = true;

            try
            {
                MySqlCommand update = new MySqlCommand(sentencia, conexion.AbrirConexion());
                return update.ExecuteNonQuery();
            }
            catch
            {
                ingresoRegistro = false;
                return -1;
            }
            finally
            {
                //Cierro la conexion antes de dar(o no) el nuevo registro, para evitar problemas
                conexion.CerrarConexion();

                if (ingresoRegistro) altas.nuevoRegistro(sentencia, "Baja reserva: " + id);
            }
        }
    }
}
