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
        //Pongo el MaxDate del DatePicker, eviatar que la Fec.Nac sea la misma
        private void frmRegClientes_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;
        }

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (validar.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacios ¿Quieres cerrar igual?", "Cerrar")) Close();
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
                Mensaje.MostrarError("Seleccione un telefono", "Eliminar telefono");
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

        //Cargar clliente por cedula
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (ValidarPersona.ValidarCedula(txtCedula, errorProvider))
            {
                //if (frmPrincipal.clientes.Count > 0)
                //{
                //    bool existe = false;
                //    foreach (MetodosCliente c in frmPrincipal.clientes)
                //    {
                //        if (c.Ci == txtCedula.Text)
                //        {
                //            txtModificarPrimerNombre.Text = c.PrimerNombre;
                //            txtPrimerNombre.Text = c.PrimerNombre;

                //            txtModificarSegundoNombre.Text = !String.IsNullOrWhiteSpace(c.SegundoNombre) ? c.SegundoNombre : "";
                //            txtSegundoNombre.Text = !String.IsNullOrWhiteSpace(c.SegundoNombre) ? c.SegundoNombre : "";

                //            txtModificarPrimerApellido.Text = c.PrimerApellido;
                //            txtPrimerApellido.Text = c.PrimerApellido;

                //            txtModificarSegundoApellido.Text = c.SegundoApellido;
                //            txtSegundoApellido.Text = c.SegundoApellido;

                //            txtModificarMail.Text = !String.IsNullOrWhiteSpace(c.Mail) ? c.Mail : "";
                //            txtMail.Text = !String.IsNullOrWhiteSpace(c.Mail) ? c.Mail : "";

                //            txtModificarDireccion.Text = c.Direccion;
                //            txtDireccion.Text = c.Direccion;

                //            dtpModificarNacimiento.Value = c.FechaNacimiento;
                //            dtpNacimiento.Value = c.FechaNacimiento;

                //            if (c.Genero == "Masculino")
                //            {
                //                chkModificarHombre.Checked = true;
                //                rdbHombre.Checked = true;
                //            }
                //            else if (c.Genero == "Femenino")
                //            {
                //                chkModificarMujer.Checked = true;
                //                rdbMujer.Checked = true;
                //            }
                //            else
                //            {
                //                chkModificarNoBinario.Checked = true;
                //                rdbNoBinario.Checked = true;
                //            }

                //            if (c.Telefonos.Count > 0)
                //            {
                //                //Los limpio para que no se repitan los telefonos
                //                listTelefonos.Items.Clear();
                //                listModificarTelefonos.Items.Clear();

                //                foreach (String s in c.Telefonos)
                //                {
                //                    listModificarTelefonos.Items.Add(s);
                //                    listTelefonos.Items.Add(s);
                //                }
                //            }
                //            existe = true;
                //            break;
                //        }
                //    }
                //    if (existe)
                //    {
                //        MessageBox.Show("Cliente ya encontrado, puede empezar a modificarlo", "Modificar clientes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //    }
                //    else
                //    {
                //        MessageBox.Show("No hay clientes registrados con esa cedula", "Modificar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //    }
                //}
                //else
                //{
                //    MessageBox.Show("No hay clientes registrados", "Modificar clientes", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //}

            }
        }

        //Modificar cliente
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (ValidarPersona.ValidarPrimerNombre(txtPrimerNombre, errorProvider))
            {
                if (ValidarPersona.ValidarSegundoNombre(txtSegundoApellido, errorProvider))
                {
                    if (ValidarPersona.ValidarMail(txtMail, errorProvider))
                    {
                        if (ValidarPersona.ValidarDireccion(txtDireccion, errorProvider))
                        {
                            Cliente cliente = CreacionObjeto.CrearCliente(Convert.ToInt32(txtCedula.Text), txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail,
                                 txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos);

                            //if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar al cliente: " + txtModificarPrimerNombre.Text + " " + txtModificarPrimerApellido.Text + "?", "Modificar cliente"))
                            //{
                            //    for (int i = 0; i < frmPrincipal.clientes.Count; i++)
                            //    {
                            //        if (frmPrincipal.clientes[i].Ci == txtCedula.Text)
                            //        {
                            //            frmPrincipal.clientes[i] = cliente;
                            //        }
                            //    }
                            //    Mensaje.MostrarInfo("Se modifico el cliente con exito", "Modificar cliente");
                            //    btnCancelar.PerformClick();
                            //}
                        }
                    }
                }
            }
        }

        //Borrar los campos
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quieres vaciar los campo de modificacion?", "Borrar los campos"))
            {
                //Limpio los TextBox
                Control[] controles = { txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, txtTelefono, txtModificarPrimerNombre, txtModificarSegundoNombre,
                txtModificarPrimerApellido, txtModificarSegundoApellido, txtModificarMail,txtModificarDireccion, dtpNacimiento, dtpModificarNacimiento, rdbHombre, rdbMujer, rdbNoBinario,
                    chkModificarHombre, chkModificarMujer, chkModificarNoBinario, listTelefonos, listModificarTelefonos };

                //Le pongo la MaxDate nuevamente en Hoy
                dtpNacimiento.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                dtpModificarNacimiento.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());

                validar.limpiarControles(controles);

                //Limpio todos los errores
                errorProvider.Clear();

            }
        }
    }

}
