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
    public partial class frmModifEmpleados : Form
    {
        private Validaciones validar = new Validaciones();

        public frmModifEmpleados()
        {
            InitializeComponent();
        }

        #region Eventos del Form
        //Pongo el MaxDate del DatePicker, eviatar que la FechaNac sea la misma
        private void frmModifEmpleados_Load(object sender, EventArgs e)
        {
            dtpNacimiento.MaxDate = DateTime.Now;

            //Logo del ErrorProvider
            errorProvider.Icon = Properties.Resources.IconoError;

            //Pongo las contrasenia invisibles
            txtContraMod.UseSystemPasswordChar = true;
            txtConfContraMod.UseSystemPasswordChar = true;
        }
        //Cerarr form
        private void btnSalir_Click(object sender, EventArgs e)
        {
            if (validar.hayAlgo(this))
            {
                if (Mensaje.MostraPreguntaSiNo("Los campos no estan vacíos, ¿Quieres cerrar igual?", "Cerrar")) Close();
            }
            else
            {
                Close();
            }
        }
        #endregion

        #region Validaciones de Ingreso(TextBoxes)

        //Cedula
        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }

        private void txtCedula_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(dtpNacimientoMod, "");
        }

        //Primer Nombre
        private void txtPrimNomMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtPrimNomMod_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtPrimNomMod, "");
        }

        //Segundo Nombre
        private void txtSegNomMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtSegNomMod_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtSegNomMod, "");
        }

        //Primer Apellido
        private void txtApMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtApMod_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtApMod, "");
        }

        //Segundo Apellido
        private void txtAp2Mod_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsLetra(e.KeyChar, true, "");
        }

        private void txtAp2Mod_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtAp2Mod, "");
        }

        //Mail
        private void txtMailMod_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Los mail solo aceptan numeros 0-9 letras A-Z y los simbolos "@",".","-" y "_"
            e.Handled = !validar.validarSiCaracterEsDigitoLetra(e.KeyChar, false, "@ . - _");
        }

        private void txtMailMod_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtMailMod, "");
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
        private void txtDireMod_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtDireMod, "");
        }

        #endregion

        #region Eventos de Botones de Telefono
        private void btnAgregarTelefono_Click(object sender, EventArgs e)
        {
            if (ValidarPersona.ValidarTelefono(txtTelefono, errorProvider))
            {
                ///Si el telefono no esta en la lista
                if (!listTelefonosMod.Items.Contains(txtTelefono.Text))
                {
                    //Lo agrego a la lista y borro el texto del TextBox
                    listTelefonosMod.Items.Add(txtTelefono.Text);
                    txtTelefono.Clear();
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
            if (listTelefonosMod.Items.Count > 0)
            {
                //Que algun telefono este seleccionado
                if (listTelefonosMod.SelectedItem != null)
                {
                    if (Mensaje.MostraPreguntaSiNo("¿Quiere eliminar el teléfono seleccionado?", "Eliminar teléfono"))
                    {
                        //Borro el telefono seleccionado
                        listTelefonosMod.Items.Remove(listTelefonosMod.SelectedItem);
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

        private void listTelefonosMod_DoubleClick(object sender, EventArgs e)
        {
            //Que alla telefonos en la lista
            if (listTelefonosMod.Items.Count > 0)
            {
                //Que algun telefono este seleccionado
                if (listTelefonosMod.SelectedItem != null)
                {
                    //Paso el telefono seleccionado al textBox
                    txtTelefono.Text = listTelefonosMod.SelectedItem.ToString();

                    //Y lo remuevo
                    listTelefonosMod.Items.Remove(listTelefonosMod.SelectedItem);
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

        //Buscar la deula
        private void btnBuscarCed_Click(object sender, EventArgs e)
        {
            if (ValidarPersona.ValidarCedula(txtCedula, errorProvider))
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                //Busco si existe y no si esta dado de Alta, porque puede que quiera modificar su
                //estado(alta/baja)
                int retorno = metodos.buscarEmpleado(Convert.ToInt32(txtCedula.Text));

                //Empleado existe
                if (retorno == 1)
                {
                    //Cargo los datos del Empleado
                    Persona persona = metodos.traerPersona(Convert.ToInt32(txtCedula.Text));
                    Empleado empleado = metodos.traerEmpleado(Convert.ToInt32(txtCedula.Text));

                    if (persona != null && empleado != null)
                    {
                        //Cargo los datos en los TextBox de Modificar y en los de Info
                        txtPrimNomMod.Text = persona.PrimerNombre;
                        txtPrimerNombre.Text = persona.PrimerNombre;

                        txtSegundoNombre.Text = !String.IsNullOrWhiteSpace(persona.SegundoNombre) ? persona.SegundoNombre : "";
                        txtSegNomMod.Text = !String.IsNullOrWhiteSpace(persona.SegundoNombre) ? persona.SegundoNombre : "";

                        txtApMod.Text = persona.PrimerApellido;
                        txtPrimerApellido.Text = persona.PrimerApellido;

                        txtAp2Mod.Text = persona.SegundoApellido;
                        txtSegundoApellido.Text = persona.SegundoApellido;

                        txtMailMod.Text = !String.IsNullOrWhiteSpace(persona.Mail) ? persona.Mail : "";
                        txtMail.Text = !String.IsNullOrWhiteSpace(persona.Mail) ? persona.Mail : "";

                        txtDireMod.Text = persona.Direccion;
                        txtDireccion.Text = persona.Direccion;

                        dtpNacimientoMod.Value = persona.FechaNacimiento;
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
                            listTelefonosMod.Items.Clear();

                            foreach (String s in persona.Telefonos)
                            {
                                listTelefonosMod.Items.Add(s);
                                listTelefonos.Items.Add(s);
                            }
                        }

                        chkActivo.Checked = empleado.Estado;

                        txtNomUsu.Text = empleado.Usuario;
                        txtNomUsuMod.Text = empleado.Usuario;
                        cmbCargoMod.SelectedIndex = empleado.Tipo;
                        cmbCargo.SelectedIndex = empleado.Tipo;

                        //Deshabilito el poder ingresar la cedula
                        txtCedula.Enabled = false;
                        btnBuscarCed.Enabled = false;

                        //Habilito los campos que se pueden editar
                        txtPrimNomMod.Enabled = true;
                        txtSegNomMod.Enabled = true;
                        txtMailMod.Enabled = true;
                        txtDireMod.Enabled = true;

                        rdbHombre.Enabled = true;
                        rdbMujer.Enabled = true;
                        rdbNoBinario.Enabled = true;

                        txtTelefono.Enabled = true;
                        listTelefonosMod.Enabled = true;
                        btnAgregarTel.Enabled = true;
                        btnBorrarTel.Enabled = true;

                        chkActivo.Enabled = true;

                        //Habilito los campos del Usuario y Contrasenia
                        cmbCargoMod.Enabled = true;
                        txtNomUsuMod.Enabled = true;
                        txtContraMod.Enabled = true;
                        txtConfContraMod.Enabled = true;


                        //Habilito los botones para Modificar y Cancelar
                        btnModificar.Enabled = true;
                        btnCancelar.Enabled = true;

                        MessageBox.Show("Empleado ya encontrado, puede empezar a modificarlo", "Modificar Empleado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Modificar Usuario
                        if (empleado.Ci == frmPrincipal.empleado.Ci)
                        {
                            Mensaje.MostrarInfo("Por medidas de seguridad, usted no puede modificar su propio usuario", "Modificar empleado");
                            cmbCargo.Enabled = false;
                            txtNomUsuMod.Enabled = false;
                            chkActivo.Enabled = false;
                        }
                    }
                    else
                    {
                        Mensaje.MostrarError("Ocurrió un error al consultar la información del emplado", Mensaje.ErrorBD);
                    }
                }
                //Empleado no existe
                else if (retorno == 0)
                {
                    Mensaje.MostrarInfo("No existe un Empleado con esa cédula", Mensaje.ErrorIngreso);
                }
                else
                {
                    Mensaje.MostrarError("Ocurrió un error al buscar al Empleado", Mensaje.ErrorBD);
                }

            }

        }

        //Valida que los campos no sean iguales
        public bool validarDatosNoIguales()
        {
            if (txtPrimNomMod.Text == txtPrimerNombre.Text)
            {
                if (txtSegNomMod.Text == txtSegNomMod.Text)
                {
                    if (txtApMod.Text == txtPrimerApellido.Text)
                    {
                        if (txtAp2Mod.Text == txtSegundoApellido.Text)
                        {
                            if (txtMailMod.Text == txtMail.Text)
                            {
                                if (txtDireMod.Text == txtDireccion.Text)
                                {
                                    if (dtpNacimientoMod.Value == dtpNacimiento.Value)
                                    {
                                        if (chkModificarHombre.Checked == rdbHombre.Checked && chkModificarMujer.Checked == rdbMujer.Checked && chkModificarNoBinario.Checked == rdbNoBinario.Checked)
                                        {
                                            bool iguales = true;

                                            //Recorror los 2 list para comprobar si son iguales
                                            for (int i = 0; i < listTelefonosMod.Items.Count; i++)
                                            {
                                                //Si tienen cantidad de items diferente no son iguales
                                                if (listTelefonosMod.Items.Count == listTelefonos.Items.Count)
                                                {
                                                    //Comparo si los items son diferentes
                                                    if (listTelefonosMod.Items[i].ToString() != listTelefonos.Items[i].ToString())
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
                                                if (txtNomUsuMod.Text == txtNomUsu.Text)
                                                {
                                                    if (String.IsNullOrEmpty(txtContraMod.Text))
                                                    {
                                                        if (String.IsNullOrEmpty(txtContraMod.Text))
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
                    }
                }
            }
            return true;

        }

        //Descargar la Reserva
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            if (Mensaje.MostraPreguntaSiNo("¿Quieres vaciar los campos de modificación?", "Vaciar los campos"))
            {
                //Limpio los TextBox
                Control[] controles = { txtCedula, txtPrimerNombre, txtSegNomMod, txtPrimerApellido, txtSegundoApellido, txtMail, txtDireccion, txtTelefono, txtPrimNomMod, txtSegNomMod,
                txtApMod, txtAp2Mod, txtMailMod,txtDireMod, dtpNacimiento, dtpNacimientoMod, rdbHombre, rdbMujer, rdbNoBinario, chkModificarHombre, chkModificarMujer,
                    chkModificarNoBinario, listTelefonos, listTelefonosMod, txtNomUsu,  txtNomUsuMod, txtContraMod, txtConfContraMod};

                //Le pongo la MaxDate nuevamente en Hoy
                dtpNacimiento.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());
                dtpNacimientoMod.MaxDate = DateTime.Parse(DateTime.Now.ToShortDateString());

                validar.limpiarControles(controles);

                //Nabilito el poder ingresar la cedula
                txtCedula.Enabled = true;
                btnBuscarCed.Enabled = true;

                //Deshabilito los campos que se pueden editar
                txtPrimNomMod.Enabled = false;
                txtSegNomMod.Enabled = false;
                txtMailMod.Enabled = false;
                txtDireMod.Enabled = false;

                rdbHombre.Enabled = false;
                rdbMujer.Enabled = false;
                rdbNoBinario.Enabled = false;

                txtTelefono.Enabled = false;
                listTelefonosMod.Enabled = false;
                btnAgregarTel.Enabled = false;
                btnBorrarTel.Enabled = false;

                chkActivo.Enabled = false;

                //Deshabilito los botones para Modificar y Cancelar
                btnModificar.Enabled = false;
                btnCancelar.Enabled = false;

                //Habilito los campos del Usuario y Contrasenia
                cmbCargoMod.Enabled = false;
                txtNomUsuMod.Enabled = false;
                txtContraMod.Enabled = false;
                txtConfContraMod.Enabled = false;

                //Limpio todos los errores
                errorProvider.Clear();

            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (validarDatosNoIguales())
            {
                MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

                Empleado empleado = metodos.validarEmpleado(txtCedula, txtPrimNomMod, txtSegNomMod, txtApMod, txtAp2Mod, txtMailMod, txtDireMod, dtpNacimientoMod, rdbHombre,
                    rdbMujer, listTelefonosMod, txtNomUsuMod, cmbCargoMod, txtContraMod, txtConfContraMod, errorProvider);

                if (empleado != null)
                {
                    if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar al empleado: " + empleado.PrimerNombre + " " + empleado.PrimerApellido + "?", "Modificar empleado"))
                    {
                        //Busco si existe y no si esta dado de Alta, porque puede que quiera modificar su
                        //estado(alta/baja)
                        int retorno = metodos.existeEmpleado(empleado.Ci);

                        //Empleado existe
                        if (retorno == 1)
                        {
                            //Modificar Empleado
                            if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar los datos personales del usuario?", "Modificar empleado"))
                            {
                                retorno = metodos.modificarPersona(empleado);
                                if (retorno > 0)
                                {
                                    retorno = metodos.modificarTelefonosPersona(empleado.Ci, empleado.Telefonos);

                                    if (retorno == 1)
                                    {
                                        Mensaje.MostrarInfo("Se modificaron los datos personales del empleado con éxito", "Modificar empleado");
                                    }
                                    else
                                    {
                                        Mensaje.MostrarError("Ocurrió un error al modificar los teléfonos, pero los demás datos se han modificado correctamente", Mensaje.ErrorBD);
                                    }
                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al modificar al empleado", Mensaje.ErrorBD);
                                }
                            }

                            if (Mensaje.MostraPreguntaSiNo("¿Quiere modificar de usuario del empleado?", "Modificar empleado"))
                            {
                                retorno = metodos.modificarEmpleado(empleado);
                                if (retorno > 0)
                                {
                                    Mensaje.MostrarInfo("Se modificaron los datos de usuario del empleado con éxito", "Modificar empleado");
                                    btnCancelar.PerformClick();

                                }
                                else
                                {
                                    Mensaje.MostrarError("Ocurrió un error al modificar al cliente", Mensaje.ErrorBD);
                                }
                            }

                        }
                        else if (retorno == 0)
                        {
                            Mensaje.MostrarError("El empleado que ingresó no está registrado", Mensaje.ErrorBD);
                        }
                        else
                        {
                            Mensaje.MostrarError("Ocurrió un error al buscar al empleado", Mensaje.ErrorBD);
                        }
                    }

                }
            }
        }

        private void chkActivo_Click(object sender, EventArgs e)
        {
            //Saco el objeto del evento, es decir, el qeu seria el deschekeado
            CheckBox r = (CheckBox)sender;

            MetodosEmpleado metodos = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            //Si chkActivo.Checked esta true, sigmifica que esta dado de alta, osea que quiero darle de baja
            //por eso paso el !chkActivo.Checked
            int retorno = metodos.modificarEstadoEmpleado(Convert.ToInt32(txtCedula.Text), !chkActivo.Checked);
            if (retorno > 0)
            {
                Mensaje.MostrarInfo("Se cambió el estado del emplado con éxito", "Modifación de Emplado");
                //Solo cambio el chek del chekBox si se pudo dar de baja/alta correctamente
                //Sino no lo doy de baja
                r.Checked = !r.Checked;
            }
            else
            {
                Mensaje.MostrarError("Ocurrió un error al modificar el estado del empleado", Mensaje.ErrorBD);
            }
        }

    }
}
