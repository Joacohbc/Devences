﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_de_Datos;
using Capa_Logica;
using Capa_Logica.Clases;

namespace Capa_Presentacion
{
    public partial class frmRegClientes : Form
    {
        public frmRegClientes()
        {
            InitializeComponent();
        }
        
        //Pongo el MaxDate del DatePicker, eviatar que la Fec.Nac sea la misma
        private void frmRegClientes_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;
        }

        #region Validaciones de Ingreso(TextBoxes)

        Validaciones validar = new Validaciones();

        //Cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar,  false, "");
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
            if (Cliente.ValidarTelefono(txtTelefono, errorProvider))
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

        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Validaciones validaciones = new Validaciones();
            if (validaciones.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacios ¿Quieres cerrar igual?", "Cerrar")) {
                    Close();
                }
            }
            else
            {
                Close();
            }
        }

        //Validar y registrar
        private void btnRegistra_Click(object sender, EventArgs e)
        {
            Cliente.DarAlta(txtCedula, txtPrimerApellido, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, dtpNacimiento, rdbHombre, rdbMujer, listTelefonos, errorProvider);
        }

        //Borrar los campos
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos los campos?", "Borrar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedula, txtPrimerNombre, txtSegundoNombre, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, txtTelefono, dtpNacimiento,rdbHombre,rdbMujer,rdbNoBinario,listTelefonos};
                validar.limpiarControles(controles);

                //Checkeo el rdbHombre para simpre haya uno chekeado
                rdbHombre.Checked = true;

                //Y borro el error provider
                errorProvider.Clear();
            }
        }
    }
}
