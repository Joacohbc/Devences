using Capa_de_Datos;
using Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Logica
{
    public class CreacionObjeto
    {
        public static Cliente CrearCliente(int ci, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido,
            TextBox txtMail, TextBox txtDireccion, DateTimePicker dtpNacimiento, RadioButton rdbHombre, RadioButton rdbMujer, ListBox listTelefonos)
        {
            Cliente cliente = new Cliente();
            cliente.Ci = ci;
            cliente.PrimerNombre = txtPrimerNombre.Text;
            if (!String.IsNullOrWhiteSpace(txtSegundoNombre.Text))
            {
                cliente.SegundoNombre = txtSegundoNombre.Text;
            }
            cliente.PrimerApellido = txtPrimerApellido.Text;
            cliente.SegundoApellido = txtSegundoApellido.Text;
            cliente.Mail = txtMail.Text;
            cliente.Direccion = txtDireccion.Text;
            cliente.FechaNacimiento = DateTime.Parse(dtpNacimiento.Value.ToShortDateString());

            if (rdbHombre.Checked)
            {
                cliente.Genero = "Masculino";
            }
            else if (rdbMujer.Checked)
            {
                cliente.Genero = "Femenino";
            }
            else
            {
                cliente.Genero = "No Binario";
            }

            if (listTelefonos.Items.Count > 0)
            {
                //Casteo la listTelefonos a un List de Strings
                cliente.Telefonos = listTelefonos.Items.Cast<String>().ToList();
            }

            return cliente;
        }

        public static Reserva CrearReserva(List<String[]> tiposDeIngresosTraidosDB, int ci, DateTimePicker dtpFechaInicio, DateTimePicker dtpFechaFin, 
            ComboBox cmbTipoDeIngreso, ComboBox cmbFormaDePago, CheckBox chkConfirmada)
        {
            Reserva reserva = new Reserva();
            reserva.Ci = ci;
            reserva.Inicio = dtpFechaInicio.Value;
            reserva.Fin = dtpFechaFin.Value;
            reserva.FormaDePago = cmbFormaDePago.SelectedItem.ToString();

            //Agrego el tipo de Ingreso pero sin el ($Precio) para que se igual que en la BD
            String tipoDeIngresoTitular = cmbTipoDeIngreso.SelectedItem.ToString();
            reserva.TipoDeIngreso = tipoDeIngresoTitular.Substring(0, tipoDeIngresoTitular.IndexOf('('));

            //Le doy un valor inicial
            reserva.PrecioTotal = 0;

            //Recorro lo que traje de la base de datos(Contiene un Array donde en [0] guardo el nombre y en [1] guardo el precio
            foreach (String[] tipoDeIngreso in tiposDeIngresosTraidosDB)
            {
                //Donde el tipo de ingreso sea igual al del Titular que le sume el precio
                if (reserva.TipoDeIngreso == tipoDeIngreso[0])
                {
                    reserva.PrecioTotal += Convert.ToInt32(tipoDeIngreso[1]);
                }
            }
            
            if (chkConfirmada.Checked)
            {
                reserva.Estado = "Confirmada";
            }
            else
            {
                reserva.Estado = "No Confirmada";
            }

            return reserva;
        }

        public static Empleado CrearEmpleado(int ci, TextBox txtPrimerNombre, TextBox txtSegundoNombre, TextBox txtPrimerApellido, TextBox txtSegundoApellido,
          TextBox txtMail, TextBox txtDireccion, DateTimePicker dtpNacimiento, RadioButton rdbHombre, RadioButton rdbMujer, ListBox listTelefonos, TextBox txtUsuario, ComboBox cmbTipo, TextBox txtContra)
        {
            Empleado empleado = new Empleado();
            empleado.Ci = ci;
            empleado.PrimerNombre = txtPrimerNombre.Text;

            if (!String.IsNullOrWhiteSpace(txtSegundoNombre.Text))
            {
                empleado.SegundoNombre = txtSegundoNombre.Text;
            }
            empleado.PrimerApellido = txtPrimerApellido.Text;
            empleado.SegundoApellido = txtSegundoApellido.Text;
            empleado.Mail = txtMail.Text;
            empleado.Direccion = txtDireccion.Text;
            empleado.FechaNacimiento = DateTime.Parse(dtpNacimiento.Value.ToShortDateString());

            if (rdbHombre.Checked)
            {
                empleado.Genero = "Masculino";
            }
            else if (rdbMujer.Checked)
            {
                empleado.Genero = "Femenino";
            }
            else
            {
                empleado.Genero = "No Binario";
            }

            if (listTelefonos.Items.Count > 0)
            {
                //Casteo la listTelefonos a un List de Strings
                empleado.Telefonos = listTelefonos.Items.Cast<String>().ToList();
            }

            empleado.Usuario = txtUsuario.Text;
            empleado.Contra = txtContra.Text;
            empleado.Tipo = cmbTipo.SelectedItem.ToString() == "Gerente" ? 1 : 0;
            return empleado;
        }
    }
}
