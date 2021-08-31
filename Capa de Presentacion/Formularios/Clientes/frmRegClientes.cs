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
using Capa_Logica;

namespace Capa_Presentacion.Formularios
{
    public partial class frmRegClientes : Form
    {

        public frmRegClientes()
        {
            InitializeComponent();
        }

        #region Validaciones de Ingreso(TextBoxes)

        Validaciones validar = new Validaciones();

        //Cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, false, "");
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedula, "");
        }

        //Primer Nombre
        private void txtPrimerNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, false, "");
        }

        private void txtPrimerNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPrimerNombre, "");
        }

        //Segundo Nombre
        private void txtSegundoNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, false, "");
        }

        private void txtSegundoNombre_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSegundoNombre, "");
        }

        //Primer Apellido
        private void txtPrimerApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, false, "");
        }

        private void txtPrimerApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPrimerApellido, "");
        }

        //Segundo Apellido
        private void txtSegudoApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, false, "");
        }

        private void txtSegudoApellido_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSegundoApellido, "");
        }

        //Mail
        private void txtMail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Los mail solo aceptan numeros 0-9 letras A-Z y los simbolos "@",".","-" y "_"
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, true, "@ . - _");
        }

        private void txtMail_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMail, "");
        }

        //Telefono
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, true, "+ -");
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

        ValidacionesConErrorProvider validarEP = new ValidacionesConErrorProvider();

        #region Eventos de Botones de Telefono

        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (validarEP.validarDigitos(txtTelefono, errorProvider, false, true, "+ -", 21))
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
                    MessageBox.Show("El telefono que quiere agregar ya existe", "Agregar telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    DialogResult op = MessageBox.Show("¿Quiere eliminar el telefono seleccionado?", "Eliminar telefono", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (op == DialogResult.Yes)
                    {
                        //Borro el telefono seleccionado
                        listTelefonos.Items.Remove(listTelefonos.SelectedItem);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un telefono", "Eliminar telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero ingrese un telefono", "Eliminar telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                    MessageBox.Show("Seleccione un telefono", "Editar telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero ingrese un telefono", "Editar telefono", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        //Validar y registrar
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            //Valida la cedul
            if (validarCedula(txtCedula, errorProvider))
            {
                if (validarEP.validarLetras(txtPrimerNombre, errorProvider, true, false, "", 20))
                {
                    //Si no esta vacio, que lo valide(ES OPCIONAL)
                    if (String.IsNullOrWhiteSpace(txtSegundoNombre.Text) || validarEP.validarLetras(txtSegundoNombre, errorProvider, true, false, "", 20))
                    {
                        
                        if (validarEP.validarLetras(txtPrimerApellido, errorProvider, true, false, "", 20))
                        {
                            if (validarEP.validarLetras(txtSegundoApellido, errorProvider, true, false, "", 20))
                            {
                                //Si no esta vacio, que lo valide(ES OPCIONAL)
                                if (String.IsNullOrWhiteSpace(txtMail.Text) || validarEP.validarLetrasDigitos(txtMail, errorProvider, false, true, "@ . - _", 320))
                                {
                                    //Validar el mail
                                    if (String.IsNullOrWhiteSpace(txtMail.Text) || validarEmail(txtMail))
                                    {
                                        if (validarEP.validarVacio(txtDireccion, errorProvider, 250))
                                        {
                                            if (validar.validarFechaPrimeraEsMenor(dtpNacimiento.Value, DateTime.Now))
                                            {
                                                errorProvider.SetError(dtpNacimiento, "");

                                                if (rdbHombre.Checked || rdbMujer.Checked || rdbNoBinario.Checked)
                                                {
                                                    errorProvider.SetError(rdbNoBinario, "");
                                                    Cliente cliente = new Cliente();
                                                    cliente.Ci = txtCedula.Text;
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

                                                    if(listTelefonos.Items.Count > 0)
                                                    {
                                                        //Casteo la listTelefonos a un List de Strings
                                                        cliente.Telefonos = listTelefonos.Items.Cast<String>().ToList();
                                                    }
                                                    else
                                                    {
                                                        cliente.Telefonos = new List<string>();
                                                    }

                                                    DialogResult op = MessageBox.Show("¿Quiere confirmar al cliente: " + cliente.PrimerNombre + " " + cliente.PrimerApellido + "?", "Alta de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                                                    if (op == DialogResult.Yes)
                                                    {
                                                        bool yaExiste = false;
                                                        foreach(Cliente c in frmPrincipal.clientes)
                                                        {
                                                            if(c.Ci == cliente.Ci)
                                                            {
                                                                yaExiste = true;
                                                                break;
                                                            }
                                                        }

                                                        if (!yaExiste)
                                                        {
                                                            frmPrincipal.clientes.Add(cliente);
                                                            MessageBox.Show("Se registro el cliente con exito", "Alta de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                            btnCancelar.PerformClick();
                                                        }
                                                        else
                                                        {
                                                            MessageBox.Show("El cliente con la cedula: " + cliente.Ci + " ya existe", "Alta de cliente", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                                        }

                                                    }
                                                }
                                                else
                                                {
                                                    errorProvider.SetIconPadding(rdbNoBinario, 5);
                                                    errorProvider.SetError(rdbNoBinario, "Debe elegir un genero");
                                                }

                                            }
                                            else
                                            {
                                                errorProvider.SetIconPadding(dtpNacimiento, 5);
                                                errorProvider.SetError(dtpNacimiento, "Fecha de nacimiento invalida");
                                            }
                                        }

                                    }
                                }
                            }
                        }
                    }
                }
            }
        }

        //Borrar los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            DialogResult op = MessageBox.Show("¿Quiere borrar todos los campos?", "Borrar los campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (op == DialogResult.Yes)
            {
                //Limpio los TextBox
                TextBox[] textBoxes = { txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, txtTelefono };
                validar.limpiarTextBots(textBoxes);

                //Le doy de nuevo la fecha
                dtpNacimiento.Value = DateTime.Parse(DateTime.Now.ToShortDateString());

                //Restablesco los RadioBtn
                rdbHombre.Checked = false;
                rdbMujer.Checked = false;
                rdbNoBinario.Checked = false;

                //Vacio los telefonos
                listTelefonos.Items.Clear();

                //Limpio todos los errores
                errorProvider.Clear();
            }
        }

        //Pongo el MaxDate del DatePicker, eviatar que la Fec.Nac sea la misma
        private void frmRegClientes_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;
        }

        //Validar mails
        private bool validarEmail(TextBox txtBox)
        {
            if (validarEP.validarVacio(txtBox, errorProvider, 320)) 
            {
                if (new EmailAddressAttribute().IsValid(txtBox.Text))
                {
                    return true;
                }
                else
                {
                    errorProvider.SetIconPadding(txtBox, 5);
                    errorProvider.SetError(txtBox, "El formato del mail ingresado es invalido");
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

        //Valida la cedula
        private bool validarCedula(TextBox txtBox, ErrorProvider errorProvider)
        {

            if (validarEP.validarVacio(txtBox, errorProvider, 13))
            {
                if (txtBox.Text.Length >= 8)
                {
                    bool valido = true;
                    foreach (Char c in txtBox.Text)
                    {
                        //Valida caracter por caracter con los parametros indicados, sino valido sea falso(retorne false) 
                        if (!validar.validarSiCaracterEsDigito(c, false, false, ""))
                        {
                            valido = false;
                            break;
                        }
                    }

                    if (valido)
                    {
                        return true;
                    }
                    else
                    {
                        errorProvider.SetIconPadding(txtBox, 5);
                        errorProvider.SetError(txtBox, "Este campo solo puede contener digitos");
                        txtBox.Focus();
                        return false;
                    }
                }
                else
                {
                    errorProvider.SetIconPadding(txtBox, 5);
                    errorProvider.SetError(txtBox, "Este campo debe contener por lo menos 8 digitos");
                    txtBox.Focus();
                    return false;
                }
            }
            else
            {
                return false;
            }


        }
    }
}
