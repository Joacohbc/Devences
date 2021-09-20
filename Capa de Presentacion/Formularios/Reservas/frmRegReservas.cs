using Capa_de_Datos;
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
    public partial class frmRegReservas : Form
    {
        //List<Integrantes> integrantes = new List<Integrantes>();
        Validaciones validar = new Validaciones();

        #region Cosas del Form
        public frmRegReservas()
        {
            InitializeComponent();
        }

        //Cargo los datos en los CMB y asigno Min y Max a los DTP
        private void frmRegReservas_Load(object sender, EventArgs e)
        {
            dtpFechaInico.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
            dtpFechaFin.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());

            //Cargo los Combobox
            MetodosEmpleado metodosEmpleado = new MetodosEmpleado(frmPrincipal.empleado.Ci, frmPrincipal.empleado.Tipo);

            List<String> tiposDeIngreso = metodosEmpleado.traerTipoIngreso();

            //Si no es NULL, osea se cargo correctamente los tipos de ingreso
            if (tiposDeIngreso != null)
            {
                foreach(String ingreso in tiposDeIngreso)
                {
                    cmbTipoDeIngreso.Items.Add(ingreso);
                    cmbTipoIngresoIntegrante.Items.Add(ingreso);
                }

                //Se selecciona el primero por defecto
                cmbTipoDeIngreso.SelectedIndex = 0;
                cmbTipoIngresoIntegrante.SelectedIndex = 0;
                cmbMetodosPago.SelectedIndex = 0;

            }
            else
            {
                Mensaje.MostrarError("Ocurrio un error la cargar los tipos de ingreso, cierre esta pestania e intentelo nuevamente", Mensaje.ErrorBD);

                //Si ocurre un error se desahbiilita todo menos el boton de Cierre del Form
                foreach(Control c in this.Controls)
                {
                    c.Enabled = false;
                }

                panel1.Enabled = true;
                btnSalir.Enabled = true;
            }
        }
        #endregion

        #region Validciones de Ingreso
        //Cedula Titular
        private void txtCedulaTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }

        private void txtCedulaTitular_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedulaTitular, "");
        }

        //Cedula Integrante
        private void txtCedulaIntegrante_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }

        private void txtCedulaIntegrante_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedulaIntegrante, "");
        }
        #endregion

        #region Validacions de Ingreso de Integrantes
        private void btnAgregarIntegrante_Click(object sender, EventArgs e)
        {
            //if (frmPrincipal.clientes.Count > 0)
            //{
            //    if (Cliente.ValidarCedula(txtCedulaTitular, errorProvider))
            //    {
            //        #region Codigo Viejo
            //        bool titualrExiste = false;
            //        foreach (Cliente c in frmPrincipal.clientes)
            //        {
            //            if (c.Ci == txtCedulaIntegrante.Text)
            //            {
            //                if (!listIntegrantes.Items.Contains(txtCedulaIntegrante.Text))
            //                {
            //                    listIntegrantes.Items.Add(txtCedulaIntegrante.Text);
            //                    dgvIntegrantes.Rows.Add(c.PrimerNombre, c.PrimerApellido, c.Genero, cmbTipoIngresoIntegrante.SelectedItem.ToString());
            //                    integrantes.Add(new Integrantes(txtCedulaIntegrante.Text, cmbTipoIngresoIntegrante.SelectedItem.ToString()));
            //                    txtCedulaIntegrante.Clear();
            //                    titualrExiste = true;
            //                    break;
            //                }
            //                else
            //                {
            //                    MessageBox.Show("Este integrante ya se agrego a la lista", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    titualrExiste = true;
            //                    break;
            //                }
            //            }
            //        }

            //        if (!titualrExiste)
            //        {
            //            MessageBox.Show("El cliente que quiere agregar no existe", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //        #endregion
            //    }
            //}
            //else
            //{
            //    MessageBox.Show("Primero ingrese un cliente", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //}
        }

        private void btnBorrarIntegrante_Click(object sender, EventArgs e)
        {
            if (listIntegrantes.Items.Count > 0)
            {
                if (listIntegrantes.SelectedItem != null)
                {
                    DialogResult op = MessageBox.Show("¿Quiere eliminar el integrante seleccionado?", "Eliminar integrante", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (op == DialogResult.Yes)
                    {
                        dgvIntegrantes.Rows.RemoveAt(listIntegrantes.SelectedIndex);
                        listIntegrantes.Items.Remove(listIntegrantes.SelectedItem);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un integrante", "Eliminar integrante", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Primero ingrese un integrante", "Eliminar intengrante", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            ////Valido cedula
            //if (validarCedula(txtCedulaTitular, errorProvider))
            //{
            //    //Valido que las fechas sean validas
            //    if (validar.validarFechaPrimeraEsMenor(dtpFechaInico.Value, dtpFechaFin.Value))
            //    {
            //        bool titularExiste = false;
            //        //Busco al titular dentro de Clientes
            //        foreach (Cliente c in frmPrincipal.clientes)
            //        {
            //            if (c.Ci == txtCedulaTitular.Text)
            //            {
            //                titularExiste = true;
            //                break;
            //            }
            //        }

            //        //Si el titular existe
            //        if (titularExiste)
            //        {
            //            //Checkeo que el Titular no este agregado como cliente
            //            if (!listIntegrantes.Items.Contains(txtCedulaTitular.Text))
            //            {
            //                //Le doy todos los parametros
            //                Reserva reserva = new Reserva();
            //                reserva.Ci = txtCedulaTitular.Text;
            //                reserva.Inicio = dtpFechaInico.Value;
            //                reserva.Fin = dtpFechaFin.Value;
            //                reserva.TipoDeIngreso = cmbTipoDeIngreso.SelectedItem.ToString();

            //                //Agrego los Integrantes
            //                foreach (Integrantes i in integrantes)
            //                {
            //                    reserva.CiIntegrantes.Add(i.Ci);
            //                    reserva.TipoDeIngresoIntegrantes.Add(i.TipoDeIngreso);
            //                }

            //                int precio = 0;

            //                //Calculo el precio
            //                if (reserva.TipoDeIngreso == "Normal")
            //                {
            //                    precio += 150;
            //                }
            //                else if (reserva.TipoDeIngreso == "Hospedado")
            //                {
            //                    precio += 100;
            //                }
            //                else
            //                {
            //                    precio += 80;
            //                }

            //                //Si hay integrantes conformando la reserva que agregue su precio
            //                if (reserva.CiIntegrantes.Count > 0)
            //                {
            //                    foreach (String s in reserva.TipoDeIngresoIntegrantes)
            //                    {
            //                        if (s == "Normal")
            //                        {
            //                            precio += 150;
            //                        }
            //                        else if (s == "Hospedado")
            //                        {
            //                            precio += 100;
            //                        }
            //                        else
            //                        {
            //                            precio += 80;
            //                        }
            //                    }
            //                }


            //                reserva.PrecioTotal = precio * ((dtpFechaFin.Value - dtpFechaInico.Value).Days + 1);

            //                if (chkConfirmada.Checked)
            //                {
            //                    reserva.Estado = "Confirmada";
            //                }
            //                else
            //                {
            //                    reserva.Estado = "No Confirmada";
            //                }

            //                DialogResult op = MessageBox.Show("¿Quieres confirmar la reserva de titular: " + txtCedulaTitular.Text + " con valor de " + reserva.PrecioTotal.ToString(), "Alta de Reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //                if (op == DialogResult.Yes)
            //                {
            //                    bool yaTieneReserva = false;
            //                    foreach (Reserva r in frmPrincipal.reservas)
            //                    {
            //                        if (r.Ci == txtCedulaTitular.Text)
            //                        {
            //                            yaTieneReserva = true;
            //                        }
            //                    }

            //                    if (!yaTieneReserva)
            //                    {
            //                        frmPrincipal.reservas.Add(reserva);
            //                        btnDescartar.PerformClick();
            //                    }
            //                    else
            //                    {
            //                        MessageBox.Show("El cliente ya tiene una reserva", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //                    }
            //                }
            //            }
            //            else
            //            {
            //                MessageBox.Show("El titular no puede ser un integrante", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            }
            //        }
            //        else
            //        {
            //            MessageBox.Show("El cliente que quiere agregar no existe", "Alta de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        errorProvider.SetError(dtpFechaInico, "La fecha de inicio de la reserva debe ser obligatoriamente posteriror o igual a la de fin");
            //    }

            //}

        }

        //Descartar reserva
        private void btnDescartar_Click(object sender, EventArgs e)
        {
            if (Mensaje.MostraPreguntaSiNo("¿Quiere borrar todos los campos?", "Borrar los campos"))
            {
                //Limpio los componenetes
                Control[] controles = { txtCedulaTitular, txtCedulaIntegrante, dtpFechaInico, dtpFechaFin, chkConfirmada ,listIntegrantes, dgvIntegrantes};
                validar.limpiarControles(controles);

                //Para que vuela a tener el predeterminado en el primero
                cmbTipoDeIngreso.SelectedIndex = 0;
                cmbTipoIngresoIntegrante.SelectedIndex = 0;
                cmbMetodosPago.SelectedIndex = 0;

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
    }
}
