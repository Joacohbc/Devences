﻿namespace Capa_Presentacion.Formularios.Servicios
{
    partial class frmRegServicios
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dtpFechaInico = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDeIng = new System.Windows.Forms.Label();
            this.lblFechIn = new System.Windows.Forms.Label();
            this.lblCedTit = new System.Windows.Forms.Label();
            this.txtCedulaTitular = new System.Windows.Forms.TextBox();
            this.cmbFormaDePago = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpInicioServicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duracion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(917, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 8;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Registrar Servicios";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 47);
            this.panel1.TabIndex = 9;
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(196, 178);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(252, 24);
            this.cmbServicio.TabIndex = 100;
            // 
            // dtpFechaInico
            // 
            this.dtpFechaInico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInico.Location = new System.Drawing.Point(196, 222);
            this.dtpFechaInico.Name = "dtpFechaInico";
            this.dtpFechaInico.Size = new System.Drawing.Size(252, 23);
            this.dtpFechaInico.TabIndex = 98;
            // 
            // lblTipoDeIng
            // 
            this.lblTipoDeIng.AutoSize = true;
            this.lblTipoDeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeIng.Location = new System.Drawing.Point(108, 178);
            this.lblTipoDeIng.Name = "lblTipoDeIng";
            this.lblTipoDeIng.Size = new System.Drawing.Size(64, 20);
            this.lblTipoDeIng.TabIndex = 97;
            this.lblTipoDeIng.Tag = "";
            this.lblTipoDeIng.Text = "Servicio";
            // 
            // lblFechIn
            // 
            this.lblFechIn.AutoSize = true;
            this.lblFechIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechIn.Location = new System.Drawing.Point(29, 224);
            this.lblFechIn.Name = "lblFechIn";
            this.lblFechIn.Size = new System.Drawing.Size(147, 20);
            this.lblFechIn.TabIndex = 95;
            this.lblFechIn.Text = "Inicio de la Reserva";
            // 
            // lblCedTit
            // 
            this.lblCedTit.AutoSize = true;
            this.lblCedTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedTit.Location = new System.Drawing.Point(66, 139);
            this.lblCedTit.Name = "lblCedTit";
            this.lblCedTit.Size = new System.Drawing.Size(106, 20);
            this.lblCedTit.TabIndex = 94;
            this.lblCedTit.Text = "Cédula Titular";
            // 
            // txtCedulaTitular
            // 
            this.txtCedulaTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaTitular.Location = new System.Drawing.Point(196, 139);
            this.txtCedulaTitular.Name = "txtCedulaTitular";
            this.txtCedulaTitular.Size = new System.Drawing.Size(252, 19);
            this.txtCedulaTitular.TabIndex = 93;
            this.txtCedulaTitular.TextChanged += new System.EventHandler(this.txtCedulaTitular_TextChanged);
            this.txtCedulaTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaTitular_KeyPress);
            // 
            // cmbFormaDePago
            // 
            this.cmbFormaDePago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFormaDePago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbFormaDePago.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFormaDePago.FormattingEnabled = true;
            this.cmbFormaDePago.Items.AddRange(new object[] {
            "Credito",
            "Debito",
            "Contado"});
            this.cmbFormaDePago.Location = new System.Drawing.Point(196, 344);
            this.cmbFormaDePago.Name = "cmbFormaDePago";
            this.cmbFormaDePago.Size = new System.Drawing.Size(252, 24);
            this.cmbFormaDePago.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 346);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(126, 20);
            this.label4.TabIndex = 103;
            this.label4.Text = "Método de Pago";
            // 
            // btnDescartar
            // 
            this.btnDescartar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartar.Location = new System.Drawing.Point(341, 435);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(92, 36);
            this.btnDescartar.TabIndex = 105;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(196, 435);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(92, 36);
            this.btnRegistrar.TabIndex = 104;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.duracion,
            this.cantidad,
            this.precio});
            this.dgvServicios.Location = new System.Drawing.Point(520, 135);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(448, 336);
            this.dgvServicios.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Servicios";
            // 
            // dtpInicioServicio
            // 
            this.dtpInicioServicio.CustomFormat = "dddd dd MMMM yyyy HH:mm";
            this.dtpInicioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioServicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioServicio.Location = new System.Drawing.Point(196, 260);
            this.dtpInicioServicio.Name = "dtpInicioServicio";
            this.dtpInicioServicio.Size = new System.Drawing.Size(252, 23);
            this.dtpInicioServicio.TabIndex = 111;
            this.dtpInicioServicio.Value = new System.DateTime(2021, 9, 23, 15, 56, 39, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 263);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 110;
            this.label5.Text = "Inicio del Servicio";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Servicio";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // duracion
            // 
            this.duracion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.duracion.HeaderText = "Duracion";
            this.duracion.Name = "duracion";
            this.duracion.ReadOnly = true;
            // 
            // cantidad
            // 
            this.cantidad.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            this.precio.ReadOnly = true;
            // 
            // frmRegServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.dtpInicioServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cmbFormaDePago);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.dtpFechaInico);
            this.Controls.Add(this.lblTipoDeIng);
            this.Controls.Add(this.lblFechIn);
            this.Controls.Add(this.lblCedTit);
            this.Controls.Add(this.txtCedulaTitular);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegServicios";
            this.Text = "frmRegServicios";
            this.Load += new System.EventHandler(this.frmRegServicios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInico;
        private System.Windows.Forms.Label lblTipoDeIng;
        private System.Windows.Forms.Label lblFechIn;
        private System.Windows.Forms.Label lblCedTit;
        private System.Windows.Forms.TextBox txtCedulaTitular;
        private System.Windows.Forms.ComboBox cmbFormaDePago;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpInicioServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn duracion;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
    }
}