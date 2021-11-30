using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Logica;
using Capa_Logica.Clases;
using Capa_Entidades;

namespace Capa_Presentacion.Formularios
{
    public partial class frmRegClientes : Form
    {
        public frmRegClientes()
        {
            InitializeComponent();
            errorProvider.Icon = Properties.Resources.IconoError;
        }

        #region Eventos del Form
        private void frmRegClientes_Load(object sender, EventArgs e)
        {
            //Pongo el MaxDate del DatePicker, eviatar que la Fec.Nac sea la misma
            dtpNacimiento.MaxDate = DateTime.Now;
            
            //Checkeo el rdbHombre para simpre haya uno chekeado
            rdbHombre.Checked = true;
            
            //Logo del ErrorProvider
            errorProvider.Icon = Properties.Resources.IconoError;
        }

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            if (validaciones.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacíos, ¿Quieres cerrar igual?", "Cerrar"))
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }
        #endregion

        #region Validaciones de Ingreso(TextBoxes)

        Validaciones validar = new Validaciones();

        //Cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedula, "");
        }

        //Primer Nombre
        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPrimerNombre, "");
        }

        //Segundo Nombre
        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSegundoNombre, "");
        }

        //Primer Apellido
        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPrimerApellido, "");
        }

        //Segundo Apellido
        private void txtSegudoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtSegudoApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSegundoApellido, "");
        }

        //Mail
        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Los mail solo aceptan numeros 0-9 letras A-Z y los simbolos "@",".","-" y "_"
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "@ . - _");
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMail, "");
        }

        //Telefono
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "+ -");
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtTelefono, "");
        }

        //Direccion
        private void txtDireccion_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, true, ". /");
        }
        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDireccion, "");
        }

        #endregion

        #region Eventos de Botones de Telefono

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (ValidarPersona.ValidarTelefono(txtTelefono, errorProvider))
            {
                ///Si el telefono no esta en la lista
                if (!listTelefonos.Items.Contains(txtTelefono.Text))
                {
                    //Lo agrego a la lista y borro el texto del TextBox
                    listTelefonos.Items.Add(txtTelefono.Text);
                    txtTelefono.Clear();
                    txtTelefono.Focus();
                }
                else
                {
                    Mensaje.MostrarError("El teléfono que quiere agregar ya existe", "Agregar teléfono");
                }
            }
        }

        private void btnBorrarTelefono_Click(object sender, EventArgs e)
        {
            //Que alla telefonos en la lista
            if (listTelefonos.Items.Count > 0)
            {
                //Que algun telefono este seleccionado
                if (listTelefonos.SelectedItem != null)
                {
                    if (Mensaje.MostraPreguntaSiNo("¿Quiere eliminar el teléfono seleccionado?", "Eliminar teléfono"))
                    {
                        //Borro el telefono seleccionado
                        listTelefonos.Items.Remove(listTelefonos.SelectedItem);
                    }
                }
                else
                {
                    Mensaje.MostrarError("Seleccione un teléfono", "Eliminar teléfono");
                }
            }
            else
            {
                Mensaje.MostrarError("Primero ingrese un teléfono", "Eliminar teléfono");
            }
        }

        private void listTelefonos_DoubleClick(object sender, EventArgs e)
        {
            //Que alla telefonos en la lista
            if (listTelefonos.Items.Count > 0)
            {
                //Que algun telefono este seleccionado
                if (listTelefonos.SelectedItem != null)
                {
                    //Paso el telefono seleccionado al textBox
                    txtTelefono.Text = listTelefonos.SelectedItem.ToString();

                    //Y lo remuevo
                    listTelefonos.Items.Remove(listTelefonos.SelectedItem);
                }
                else
                {
                    Mensaje.MostrarError("Seleccione un teléfono", "Editar teléfono");
                }
            }
            else
            {
                Mensaje.MostrarError("Primero ingrese un teléfono", "Editar teléfono");
            }
        }

        #endregion

        //Validar y registrar
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //Instnacio el objeto de MetodoEmpleado
            MetodosEmpleado alta = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            //Creo el Objeto cliente
            Cliente cliente = alta.validarCliente(txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, 
                txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos, errorProvider);

            //Si no es Null, osea que todo sus atributos fueron validados con exito
            if (cliente != null)
            {
                if (Mensaje.MostraPreguntaSiNo("¿Quiere dar de alta al cliente "+ cliente.PrimerNombre +" " + cliente.PrimerApellido +"?", "Alta de cliente"))
                {
                    //Creo un objeto Persona a partir de un objeto de su clase Hija Cliente
                    Persona persona = cliente;

                    //Hago el alta de esa Persona
                    int retorno = alta.darAltaPersona(persona);

                    //Si es mayor 0, osea que se dio de alta la Persona
                    if (retorno > 0)
                    {
                        //Si es True, osea todos los telefonos se dieron de altas correctamente
                        if (alta.darAltaTelefonos(persona))
                        {
                            //Hago alta del Cliente
                            retorno = alta.darAltaCliente(cliente);
                            //Si fue un alta exitosa
                            if (retorno > 0)
                            {
                                Mensaje.MostrarInfo("Se dio de alta el cliente: " + txtPrimerNombre.Text + " " + txtPrimerApellido.Text + " con éxito", "Alta de cliente exitosa");
                                dgvRegistrarClientes.Rows.Add(persona.Ci, persona.PrimerNombre, persona.PrimerApellido, persona.Genero);
                                btnCancelar.PerformClick();
                            }
                            //Si ese Cliente ya existia
                            else if (retorno == 1)
                            {
                                Mensaje.MostrarInfo("El Cliente que intenta dar de alta ya existe", "Aviso en alta Cliente");
                            }
                            //Si dio Error
                            else
                            {
                                Mensaje.MostrarError("Ocurrió un error al dar de alta al Cliente", Mensaje.ErrorBD);
                            }
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrió un error al dar de alta los Teléfonos de la Persona", Mensaje.ErrorBD);
                        }
                    }
                    //Si es igual a 0, osea que la persona existe
                    else if (retorno == 0)
                    {
                        Mensaje.MostrarInfo("La Persona que intenta dar de alta ya existe", "Aviso en alta Persona");
                    }
                    //Y -1 si es error
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al dar de Alta a la Persona", Mensaje.ErrorBD);
                    }
                }
            }
        }

        //Borrar los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere vaciar todos los campos?", "Vaciar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail,
                    txtDireccion, txtTelefono, dtpNacimiento, rdbHombre, rdbMujer, rdbNoBinario, listTelefonos };

                //Le pongo la MaxDate nuevamente en Hoy
                dtpNacimiento.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                
                validar.limpiarControles(controles);

                //Checkeo el rdbHombre para simpre haya uno chekeado
                rdbHombre.Checked = true;
  
                //Y borro el error provider
                errorProvider.Clear();
            }
        }
        
        //Limpia el DataGrid
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            if(dgvRegistrarClientes.Rows.Count > 0)
            {
                if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos las filas de la tabla", "Borrar tabla"))
                {
                    //Limpio los componenetes
                    dgvRegistrarClientes.Rows.Clear();
                }
            }
            else
            {
                Mensaje.MostrarError("La tabla no contiene registros", Mensaje.ErrorIngreso);
            }
        }
    }
}