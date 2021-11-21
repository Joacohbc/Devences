using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidades;
using Capa_Logica;
using Capa_Logica.Clases;

namespace Capa_Presentacion.Formularios
{
    public partial class frmModClientes : Form
    {
        public frmModClientes()
        {
            InitializeComponent();
        }

        #region Eventos del Form
        //Pongo el MaxDate del DatePicker, eviatar que la FechaNac sea la misma
        private void frmRegClientes_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;

            //Logo del ErrorProvider
            errorProvider.Icon = Properties.Resources.IconoError;
        }

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (validar.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacíos ¿Quieres cerrar igual?", "Cerrar")) Close();
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
            errorProvider.SetError(dtpNacimiento, "");
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
                }
                else
                {
                    Mensaje.MostrarError("El teléfono que quiere agregar ya se encuentra agregado", "Agregar teléfono");
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
                Mensaje.MostrarError("Seleccione un teléfono", "Eliminar teléfono");
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

        //Cargar cliente por cedula
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarPersona.ValidarCedula(txtCedula, errorProvider))
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                //Busco si existe y no si esta dado de Alta, porque puede que quiera modificar su
                //estado(alta/baja)
                int retorno = metodos.existeCliente(Convert.ToInt32(txtCedula.Text));

                //Cliente existe
                if (retorno == 1)
                {
                    //Cargo los datos del Cliente
                    Persona persona = metodos.traerPersona(Convert.ToInt32(txtCedula.Text));

                    if (persona != null)
                    {
                        //Cargo los datos en los TextBox de Modificar y en los de Info
                        txtModificarPrimerNombre.Text = persona.PrimerNombre;
                        txtPrimerNombre.Text = persona.PrimerNombre;

                        txtModificarSegundoNombre.Text = !String.IsNullOrWhiteSpace(persona.SegundoNombre) ? persona.SegundoNombre : "";
                        txtSegundoNombre.Text = !String.IsNullOrWhiteSpace(persona.SegundoNombre) ? persona.SegundoNombre : "";

                        txtModificarPrimerApellido.Text = persona.PrimerApellido;
                        txtPrimerApellido.Text = persona.PrimerApellido;

                        txtModificarSegundoApellido.Text = persona.SegundoApellido;
                        txtSegundoApellido.Text = persona.SegundoApellido;

                        txtModificarMail.Text = !String.IsNullOrWhiteSpace(persona.Mail) ? persona.Mail : "";
                        txtMail.Text = !String.IsNullOrWhiteSpace(persona.Mail) ? persona.Mail : "";

                        txtModificarDireccion.Text = persona.Direccion;
                        txtDireccion.Text = persona.Direccion;

                        dtpModificarNacimiento.Value = persona.FechaNacimiento;
                        dtpNacimiento.Value = persona.FechaNacimiento;

                        if (persona.Genero == "Masculino")
                        {
                            chkModificarHombre.Checked = true;
                            rdbHombre.Checked = true;
                        }
                        else if (persona.Genero == "Femenino")
                        {
                            chkModificarMujer.Checked = true;
                            rdbMujer.Checked = true;
                        }
                        else
                        {
                            chkModificarNoBinario.Checked = true;
                            rdbNoBinario.Checked = true;
                        }

                        if (persona.Telefonos.Count > 0)
                        {
                            //Los limpio para que no se repitan los telefonos
                            listTelefonos.Items.Clear();
                            listModificarTelefonos.Items.Clear();

                            foreach (String s in persona.Telefonos)
                            {
                                listModificarTelefonos.Items.Add(s);
                                listTelefonos.Items.Add(s);
                            }
                        }

                        //chkEstado.Checked = (alta == 1 ? true : false);
                        //chkEstado.Text = (alta == 1 ? "Alta" : "Baja");

                        //Deshabilito el poder ingresar la cedula
                        txtCedula.Enabled = false;
                        btnBuscar.Enabled = false;

                        //Habilito los campos que se pueden editar
                        txtPrimerNombre.Enabled = true;
                        txtSegundoNombre.Enabled = true;
                        txtMail.Enabled = true;
                        txtDireccion.Enabled = true;

                        rdbHombre.Enabled = true;
                        rdbMujer.Enabled = true;
                        rdbNoBinario.Enabled = true;

                        txtTelefono.Enabled = true;
                        listTelefonos.Enabled = true;
                        btnAgregarTelefono.Enabled = true;
                        btnBorrarTelefono.Enabled = true;

                        //Habilito los botones para Modificar y Cancelar
                        btnModificar.Enabled = true;
                        btnCancelar.Enabled = true;

                        MessageBox.Show("Cliente encontrado, puede empezar a modificarlo", "Modificar Clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al consultar la información del cliente", Mensaje.ErrorBD);
                    }
                }
                //Cliente no existe
                else if (retorno == 0)
                {
                    Mensaje.MostrarInfo("No existe un Cliente con esa Cédula", Mensaje.ErrorIngreso);
                }
                else
                {
                    Mensaje.MostrarError("Ocurrió un error al buscar al Cliente", Mensaje.ErrorBD);
                }

            }
        }
        
        //Valida que los campos no sean iguales
        public bool validarDatosNoIguales()
        {
            if (txtModificarPrimerNombre.Text == txtPrimerNombre.Text)
            {
                if (txtModificarSegundoNombre.Text == txtSegundoNombre.Text)
                {
                    if (txtModificarPrimerApellido.Text == txtPrimerApellido.Text)
                    {
                        if (txtModificarSegundoApellido.Text == txtSegundoApellido.Text)
                        {
                            if (txtModificarMail.Text == txtMail.Text)
                            {
                                if (txtModificarDireccion.Text == txtDireccion.Text)
                                {
                                    if (dtpModificarNacimiento.Value == dtpNacimiento.Value)
                                    {
                                        if (chkModificarHombre.Checked == rdbHombre.Checked && chkModificarMujer.Checked == rdbMujer.Checked && chkModificarNoBinario.Checked == rdbNoBinario.Checked)
                                        {
                                            bool iguales = true;
                                            
                                            //Recorror los 2 list para comprobar si son iguales
                                            for (int i = 0; i < listModificarTelefonos.Items.Count; i++)
                                            {
                                                //Si tienen cantidad de items diferente no son iguales
                                                if (listModificarTelefonos.Items.Count == listTelefonos.Items.Count)
                                                {
                                                    //Comparo si los items son diferentes
                                                    if (listModificarTelefonos.Items[i].ToString() != listTelefonos.Items[i].ToString())
                                                    {
                                                        //Si lo son, salgo y pongo igual = false
                                                        iguales = false;
                                                        break;
                                                    }
                                                }
                                                else
                                                {
                                                    //Salgo y pongo igual = false
                                                    iguales = false;
                                                    break;
                                                }
                                            }

                                            if (iguales)
                                            {
                                                Mensaje.MostrarError("Los datos son iguales, cambie algún dato antes de realizar la modificación", Mensaje.ErrorIngreso);
                                                return false;
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        //Modificar cliente
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarDatosNoIguales())
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                Cliente cliente = metodos.validarCliente(txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail,
                        txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos, errorProvider);

                if (cliente != null)
                {
                    if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar al cliente: " + txtModificarPrimerNombre.Text + " " + txtModificarPrimerApellido.Text + "?", "Modificar Cliente"))
                    {
                        //Busco si existe y no si esta dado de Alta, porque puede que quiera modificar su
                        //estado(alta/baja)
                        int retorno = metodos.existeCliente(cliente.Ci);

                        //Cliente existe
                        if (retorno == 1)
                        {
                            //Lo guardo en Persona, ya que lo que se modifica son los datos de una Persona
                            Persona persona = cliente;

                            retorno = metodos.modificarPersona(cliente);
                            if (retorno > 0)
                            {
                                retorno = metodos.modificarTelefonosPersona(persona.Ci, persona.Telefonos);

                                if (retorno == 1)
                                {
                                    Mensaje.MostrarInfo("Se modificó el cliente con éxito", "Modificar Cliente");
                                    btnCancelar.PerformClick();
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al modificar los teléfonos del cliente, pero la persona se ha modificado correctamente", Mensaje.ErrorBD);
                                }
                            }
                            else
                            {
                                Mensaje.MostrarError("Ocurrió un error al modificar al cliente", Mensaje.ErrorBD);
                            }

                        }
                        //Cliente no existe
                        else if (retorno == 0)
                        {
                            Mensaje.MostrarError("El cliente que ingresó no esta registrado", Mensaje.ErrorBD);
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrió un error al buscar al cliente", Mensaje.ErrorBD);
                        }
                    }
                }
            }
        }

        //Borrar los campos
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quieres vaciar los campos de modificación?", "Vaciar los campos"))
            {
                //Limpio los TextBox
                Control[] controles = { txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, txtTelefono, txtModificarPrimerNombre, txtModificarSegundoNombre,
                txtModificarPrimerApellido, txtModificarSegundoApellido, txtModificarMail,txtModificarDireccion, dtpNacimiento, dtpModificarNacimiento, rdbHombre, rdbMujer, rdbNoBinario,
                    chkModificarHombre, chkModificarMujer, chkModificarNoBinario, listTelefonos, listModificarTelefonos };

                //Le pongo la MaxDate nuevamente en Hoy
                dtpNacimiento.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                dtpModificarNacimiento.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());

                validar.limpiarControles(controles);

                //Nabilito el poder ingresar la cedula
                txtCedula.Enabled = true;
                btnBuscar.Enabled = true;

                //Deshabilito los campos que se pueden editar
                txtPrimerNombre.Enabled = false;
                txtSegundoNombre.Enabled = false;
                txtMail.Enabled = false;
                txtDireccion.Enabled = false;

                rdbHombre.Enabled = false;
                rdbMujer.Enabled = false;
                rdbNoBinario.Enabled = false;

                txtTelefono.Enabled = false;
                listTelefonos.Enabled = false;
                btnAgregarTelefono.Enabled = false;
                btnBorrarTelefono.Enabled = false;

                //Deshabilito los botones para Modificar y Cancelar
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;

                //Limpio todos los errores
                errorProvider.Clear();

            }
        }

    }

}
