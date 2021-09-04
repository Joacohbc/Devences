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

    }
}
