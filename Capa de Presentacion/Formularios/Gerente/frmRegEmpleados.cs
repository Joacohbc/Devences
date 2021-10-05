using Capa_Entidades;
using Capa_Logica;
using Capa_Logica.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Presentacion.Formularios
{
    public partial class frmRegEmpleados : Form
    {
        public frmRegEmpleados()
        {
            InitializeComponent();
        }

        private void frmRegEmpleados_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;

            //Checkeo el rdbHombre para simpre haya uno chekeado
            rdbHombre.Checked = true;

            //Que tenga uno seleccionado
            cmbTipo.SelectedIndex = 0;

            //Que tenga contrasenia activada
            txtContra.UseSystemPasswordChar = true;
            txtConfContra.UseSystemPasswordChar = true;

            //Logo del ErrorProvider
            errorProvider.Icon = Properties.Resources.ErrorProvider;
        }
       
        #region Validaciones de Ingreso 
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
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, ". /");
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
                    Mensaje.MostrarError("El telefono que quiere agregar ya existe", "Agregar telefono");
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
                    if (Mensaje.MostraPreguntaSiNo("¿Quiere eliminar el telefono seleccionado?", "Eliminar telefono"))
                    {
                        //Borro el telefono seleccionado
                        listTelefonos.Items.Remove(listTelefonos.SelectedItem);
                    }
                }
                else
                {
                    Mensaje.MostrarError("Seleccione un telefono", "Eliminar telefono");
                }
            }
            else
            {
                Mensaje.MostrarError("Primero ingrese un telefono", "Eliminar telefono");
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
                    Mensaje.MostrarError("Seleccione un telefono", "Editar telefono");
                }
            }
            else
            {
                Mensaje.MostrarError("Primero ingrese un telefono", "Editar telefono");
            }
        }

        #endregion

        #region Validacion de Ingreso de Usu, Contra y Contra2
        //Nombre de usaurio
        private void txtNomUsu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "");
        }

        private void txtNomUsu_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtNomUsu, "");
        }

        //Contrasenia
        private void txtContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "_ - ? / * # @ % & !");
        }

        private void txtContra_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtContra, "");
        }

        //Confirmar contrasenia
        private void txtConfContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "_ - ? / * # @ % & !");
        }

        private void txtConfContra_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtConfContra, "");
        }
        #endregion

        //Borrar los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos los campos?", "Borrar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, txtTelefono, dtpNacimiento, rdbHombre, rdbMujer, rdbNoBinario, listTelefonos };
                validar.limpiarControles(controles);

                //Checkeo el rdbHombre para simpre haya uno chekeado
                rdbHombre.Checked = true;

                //Y borro el error provider
                errorProvider.Clear();
            }
        }

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            if (validaciones.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacios ¿Quieres cerrar igual?", "Cerrar"))
                {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        //Registra la Reserva
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);
            Empleado empleado = metodos.validarEmpleado(txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos, txtNomUsu, cmbTipo, txtContra, txtConfContra, errorProvider);

            if (empleado != null)
            {
                if (Mensaje.MostraPreguntaSiNo("¿Quiere dar de alta a empleado " + empleado.PrimerNombre + " " + empleado.PrimerApellido + "?", "Alta de Empleado"))
                {
                    //Creo un objeto Persona a partir de un objeto de su clase Hija Cliente
                    Persona persona = empleado;

                    //Hago el alta de esa Persona
                    int retorno = metodos.darAltaPersona(persona);

                    //Si es mayor 0, osea que se dio de alta la Persona
                    if (retorno > 0)
                    {
                        //Si es True, osea todos los telefonos se dieron de altas correctamente
                        if (metodos.darAltaTelefonos(persona))
                        {
                            retorno = metodos.buscarEmpleado(empleado.Ci);
                            if(retorno == 0)
                            {
                                retorno = metodos.altaEmpleado(empleado);
                                if(retorno > 0)
                                {
                                    Mensaje.MostrarInfo("El Empleado " + empleado.PrimerNombre + " " + empleado.PrimerApellido + " se dio de alta con exito", "Alta exitosa");
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrio un error a dar de alta el Empleado", Mensaje.ErrorBD);
                                }
                            }
                            else if(retorno == 0)
                            {
                                Mensaje.MostrarInfo("El Empleado que intenta dar de Alta ya existe", "Aviso en alta de Empleado");
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrio un error al buscar el Empleado", Mensaje.ErrorBD);
                            }
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrio un error a dar de alta los Telefonos de la Persona", Mensaje.ErrorBD);
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
                        Mensaje.MostrarError("Ocurrio un error al dar de Alta a la Persona", Mensaje.ErrorBD);
                    }
                }
            }
        }
    }
}
