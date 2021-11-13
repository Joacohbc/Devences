using Capa_Entidades;
using Capa_Logica;
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
    public partial class frmModifReservas : Form
    {
        Reserva reserva = new Reserva();
        Validaciones validar = new Validaciones();


        #region Eventos del Form
        public frmModifReservas()
        {
            InitializeComponent();
            errorProvider.Icon = Properties.Resources.IconoError;
        }

        private void frmModifReservas_Load(object sender, EventArgs e)
        {
            dtpFechaInicio.MinDate = DateTime.Parse(DateTime.Now.ToShortDateString());
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
        #endregion

        #region Validaciones de Ingreso
        private void txtCedulaTitular_TextChanged(object sender, EventArgs e)
        {
            errorProvider.SetError(txtCedulaTitular, "");
        }

        private void txtCedulaTitular_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !validar.validarSiCaracterEsDigito(e.KeyChar, false, "");
        }
        #endregion

        private void btnEliminarReserva_Click(object sender, EventArgs e)
        {
            //DialogResult op = MessageBox.Show("¿Quiere eliminar la reservar?", "Modificar reserva", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if(op == DialogResult.Yes)
            //{
            //    for (int i = 0; i < frmPrincipal.reservas.Count; i++)
            //    {
            //        if (frmPrincipal.reservas[i].Ci == txtCedulaTitular.Text)
            //        {
            //            frmPrincipal.reservas.RemoveAt(i);
            //            MessageBox.Show("La reserva se elimino", "Baja de reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            //Rehabilito la busqueda
            //            reserva = new Reserva();
            //            txtCedulaTitular.ReadOnly = false;
            //            btnBuscar.Enabled = true;

            //            btnCancelar.PerformClick();
            //        }
            //    }
            //}
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ////Valido cedula
            //if (validarCedula(txtCedulaTitular, errorProvider))
            //{
            //    bool titularExiste = false;
            //    //Busco al titular dentro de Clientes
            //    foreach (Cliente c in frmPrincipal.clientes)
            //    {
            //        if (c.Ci == txtCedulaTitular.Text)
            //        {
            //            titularExiste = true;
            //            break;
            //        }
            //    }

            //    //Si el titular existe
            //    if (titularExiste)
            //    {
            //        bool tieneReserva = false;
            //        //Compruebo si tiene reserva
            //        foreach (Reserva r in frmPrincipal.reservas)
            //        {
            //            if (r.Ci == txtCedulaTitular.Text)
            //            {
            //                reserva = r;
            //                tieneReserva = true;
            //                break;
            //            }
            //        }

            //        //Si tiene que la cargue
            //        if (tieneReserva)
            //        {
            //            dtpModificarFechaInicio.Value = reserva.Inicio;
            //            dtpFechaInicio.Value = reserva.Inicio;

            //            dtpModificarFechaFin.Value = reserva.Fin;
            //            dtpFechaFin.Value = reserva.Fin;

            //            if (reserva.Estado == "Confirmada")
            //            {
            //                chkConfirmada.Checked = true;
            //            }
            //            else
            //            {
            //                chkConfirmada.Checked = false;
            //            }

            //            if (reserva.CiIntegrantes.Count > 0)
            //            {
            //                for (int i = 0; i < reserva.CiIntegrantes.Count; i++)
            //                {
            //                    foreach (Cliente c in frmPrincipal.clientes)
            //                    {
            //                        if (c.Ci == reserva.CiIntegrantes[i])
            //                        {
            //                            dgvIntegrantes.Rows.Add(c.PrimerNombre, c.PrimerApellido, c.Genero, reserva.TipoDeIngresoIntegrantes[i]);
            //                            break;
            //                        }
            //                    }
            //                }
            //            }

            //            MessageBox.Show("Se cargo la reserva, ya esta lista para ser modificada", "Modificar Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //            //Deshabilito la busqueda
            //            txtCedulaTitular.ReadOnly = true;
            //            btnBuscar.Enabled = false;
            //        }
            //        else
            //        {
            //            MessageBox.Show("El cliente no tiene ingresado no tiene ninguna reserva", "Modificacion de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        }
            //    }
            //    else
            //    {
            //        MessageBox.Show("El cliente no existe", "Modificacion de Reserva", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //for (int i = 0; i < frmPrincipal.reservas.Count; i++)
            //{
            //    if (frmPrincipal.reservas[i].Ci == txtCedulaTitular.Text)
            //    {
            //        reserva.Inicio = dtpFechaInicio.Value;
            //        reserva.Fin = dtpFechaFin.Value;

            //        if (chkConfirmada.Checked)
            //        {
            //            reserva.Estado = "Confirmada";
            //        }
            //        else
            //        {
            //            reserva.Estado = "No Confirmada";
            //        }

            //        frmPrincipal.reservas[i] = reserva;

            //        MessageBox.Show("Se modifico la reserva con exito", "Modificar Reserva", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        //Rehabilito la busqueda
            //        reserva = new Reserva();
            //        txtCedulaTitular.ReadOnly = false;
            //        btnBuscar.Enabled = true;

            //        btnCancelar.PerformClick();
            //    }
            //}
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            //DialogResult op = MessageBox.Show("¿Quiere vaciar todos los campos?", "Borrar campos", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            //if (op == DialogResult.Yes)
            //{
            //    txtCedulaTitular.Clear();
            //    dtpModificarFechaFin.Value = DateTime.Now;
            //    dtpModificarFechaInicio.Value = DateTime.Now;
            //    dtpFechaInicio.Value = DateTime.Now;
            //    dtpFechaFin.Value = DateTime.Now;
            //    dgvIntegrantes.Rows.Clear();

            //    chkConfirmada.Checked = false;

            //    //Rehabilito la busqueda
            //    reserva = new Reserva();
            //    txtCedulaTitular.ReadOnly = false;
            //    btnBuscar.Enabled = true;
            //}
        }

    }
}
