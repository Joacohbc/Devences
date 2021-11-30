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

        public Conexion(int rol)
        {
            if (rol == 2)
            {
                //conexion joaco
                //conexionBD = new MySqlConnection("server=167.57.106.13; port=3306; database=proyectoprueba; uid=login; pwd=login;");

                //conexion local
                conexionBD = new MySqlConnection("server=" + Properties.Settings.Default.Server + "; port=" + Properties.Settings.Default.Puerto + "; database=" + Properties.Settings.Default.Database + "; uid=" + Properties.Settings.Default.User1 + "; pwd=" + Properties.Settings.Default.Pass1 + ";");

                //Conexion para la UTU
                //conexionBD = new MySqlConnection("server=192.168.2.53; port=3306; database=Devences; uid=jgenova; pwd=53626663;");
            }
            else if (rol == 1)
            {
                //Conexion joaco
                //conexionBD = new MySqlConnection("server=167.57.106.13; port=3306; database=proyectoprueba; uid=gerente; pwd=gerente;");

                //conexion local
                conexionBD = new MySqlConnection("server=" + Properties.Settings.Default.Server + "; port=" + Properties.Settings.Default.Puerto + "; database=" + Properties.Settings.Default.Database + "; uid=" + Properties.Settings.Default.User2 + "; pwd=" + Properties.Settings.Default.Pass2 + ";");

                //Conexion para la UTU
                //conexionBD = new MySqlConnection("server=192.168.2.53; port=3306; database=Devences; uid=jgenova; pwd=53626663;");
            }
            else
            {
                //conexion joaco
                //conexionBD = new MySqlConnection("server=167.57.106.13; port=3306; database=proyectoprueba; uid=administrativo; pwd=administrativo;");

                //conexion local
                conexionBD = new MySqlConnection("server=" + Properties.Settings.Default.Server + "; port=" + Properties.Settings.Default.Puerto + "; database=" + Properties.Settings.Default.Database + "; uid=" + Properties.Settings.Default.User3 + "; pwd=" + Properties.Settings.Default.Pass3 + ";");
                
                //Conexion para la UTU
                //conexionBD = new MySqlConnection("server=192.168.2.53; port=3306; database=Devences; uid=jgenova; pwd=53626663;");
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
