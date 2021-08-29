using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capa_de_Datos
{
    public class Conexion
    {
        private MySqlConnection conexionBD;

        public Conexion(String rol)
        {
            if (rol == "login")
            {
                conexionBD = new MySqlConnection("server=localhost; port=3306; database=proyectoprueba; uid=login; pwd=login;");
            }
            else if (rol == "gerente")
            {
                //conexion para gerente
            }
            else
            {
                //conexion para administrativo
            }
        }

        public MySqlConnection AbrirConexion()
        {
            //Si esta cerrada, que la abra
            if(conexionBD.State == ConnectionState.Closed)
                conexionBD.Open();
            return conexionBD;
        }

        public MySqlConnection CerrarConexion()
        {
            //Si esta abierta que la cierre
            if (conexionBD.State == ConnectionState.Open)
                conexionBD.Close();
            return conexionBD;
        }

    }
}
