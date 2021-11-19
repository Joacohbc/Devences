namespace Capa_Presentacion.Formularios.Servicios
{
    partial class frmModifServicios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.dgvServicios = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clInicio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmbServicio = new System.Windows.Forms.ComboBox();
            this.dtpFechaInico = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDeIng = new System.Windows.Forms.Label();
            this.lblFechIn = new System.Windows.Forms.Label();
            this.lblCedTit = new System.Windows.Forms.Label();
            this.txtCedulaTitular = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dtpInicioServicio = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.btnEliminarServicio = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 47);
            this.panel1.TabIndex = 128;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 13);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(211, 20);
            this.lblTitulo.TabIndex = 1;
            this.lblTitulo.Text = "Modificacion de Servicios";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(917, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(518, 124);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 136;
            this.label3.Text = "Servicios";
            // 
            // dgvServicios
            // 
            this.dgvServicios.AllowUserToAddRows = false;
            this.dgvServicios.AllowUserToDeleteRows = false;
            this.dgvServicios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServicios.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.clInicio,
            this.clFin});
            this.dgvServicios.Location = new System.Drawing.Point(522, 172);
            this.dgvServicios.Name = "dgvServicios";
            this.dgvServicios.ReadOnly = true;
            this.dgvServicios.Size = new System.Drawing.Size(448, 336);
            this.dgvServicios.TabIndex = 135;
            // 
            // nombre
            // 
            this.nombre.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nombre.HeaderText = "Servicio";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // clInicio
            // 
            this.clInicio.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clInicio.HeaderText = "Inicio";
            this.clInicio.Name = "clInicio";
            this.clInicio.ReadOnly = true;
            // 
            // clFin
            // 
            this.clFin.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.clFin.HeaderText = "Fin";
            this.clFin.Name = "clFin";
            this.clFin.ReadOnly = true;
            // 
            // cmbServicio
            // 
            this.cmbServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbServicio.Enabled = false;
            this.cmbServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbServicio.FormattingEnabled = true;
            this.cmbServicio.Location = new System.Drawing.Point(194, 277);
            this.cmbServicio.Name = "cmbServicio";
            this.cmbServicio.Size = new System.Drawing.Size(283, 24);
            this.cmbServicio.TabIndex = 134;
            this.cmbServicio.SelectedIndexChanged += new System.EventHandler(this.cmbServicio_SelectedIndexChanged);
            // 
            // dtpFechaInico
            // 
            this.dtpFechaInico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInico.Location = new System.Drawing.Point(194, 233);
            this.dtpFechaInico.Name = "dtpFechaInico";
            this.dtpFechaInico.Size = new System.Drawing.Size(283, 23);
            this.dtpFechaInico.TabIndex = 133;
            // 
            // lblTipoDeIng
            // 
            this.lblTipoDeIng.AutoSize = true;
            this.lblTipoDeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeIng.Location = new System.Drawing.Point(106, 277);
            this.lblTipoDeIng.Name = "lblTipoDeIng";
            this.lblTipoDeIng.Size = new System.Drawing.Size(64, 20);
            this.lblTipoDeIng.TabIndex = 132;
            this.lblTipoDeIng.Tag = "";
            this.lblTipoDeIng.Text = "Servicio";
            // 
            // lblFechIn
            // 
            this.lblFechIn.AutoSize = true;
            this.lblFechIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechIn.Location = new System.Drawing.Point(27, 235);
            this.lblFechIn.Name = "lblFechIn";
            this.lblFechIn.Size = new System.Drawing.Size(147, 20);
            this.lblFechIn.TabIndex = 131;
            this.lblFechIn.Text = "Inicio de la Reserva";
            // 
            // lblCedTit
            // 
            this.lblCedTit.AutoSize = true;
            this.lblCedTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedTit.Location = new System.Drawing.Point(64, 191);
            this.lblCedTit.Name = "lblCedTit";
            this.lblCedTit.Size = new System.Drawing.Size(106, 20);
            this.lblCedTit.TabIndex = 130;
            this.lblCedTit.Text = "Cédula Titular";
            // 
            // txtCedulaTitular
            // 
            this.txtCedulaTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaTitular.Location = new System.Drawing.Point(194, 191);
            this.txtCedulaTitular.Name = "txtCedulaTitular";
            this.txtCedulaTitular.Size = new System.Drawing.Size(175, 19);
            this.txtCedulaTitular.TabIndex = 129;
            this.txtCedulaTitular.TextChanged += new System.EventHandler(this.txtCedulaTitular_TextChanged);
            this.txtCedulaTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaTitular_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 24);
            this.label1.TabIndex = 137;
            this.label1.Text = "Datos";
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(404, 186);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(73, 28);
            this.btnBuscar.TabIndex = 138;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Enabled = false;
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(357, 425);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(120, 36);
            this.btnCancelar.TabIndex = 139;
            this.btnCancelar.Text = "Descartar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Enabled = false;
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(194, 425);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 36);
            this.btnModificar.TabIndex = 140;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dtpInicioServicio
            // 
            this.dtpInicioServicio.CustomFormat = "dddd dd MMMM yyyy HH:mm";
            this.dtpInicioServicio.Enabled = false;
            this.dtpInicioServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpInicioServicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInicioServicio.Location = new System.Drawing.Point(194, 317);
            this.dtpInicioServicio.Name = "dtpInicioServicio";
            this.dtpInicioServicio.Size = new System.Drawing.Size(283, 23);
            this.dtpInicioServicio.TabIndex = 142;
            this.dtpInicioServicio.Value = new System.DateTime(2021, 9, 23, 15, 56, 39, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 20);
            this.label5.TabIndex = 141;
            this.label5.Text = "Inicio del Servicio";
            // 
            // btnEliminarServicio
            // 
            this.btnEliminarServicio.Enabled = false;
            this.btnEliminarServicio.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnEliminarServicio.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEliminarServicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarServicio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarServicio.Location = new System.Drawing.Point(194, 371);
            this.btnEliminarServicio.Margin = new System.Windows.Forms.Padding(2);
            this.btnEliminarServicio.Name = "btnEliminarServicio";
            this.btnEliminarServicio.Size = new System.Drawing.Size(283, 38);
            this.btnEliminarServicio.TabIndex = 143;
            this.btnEliminarServicio.Text = "Eliminar servicio";
            this.btnEliminarServicio.UseVisualStyleBackColor = true;
            this.btnEliminarServicio.Click += new System.EventHandler(this.btnEliminarServicio_Click);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // frmModifServicios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.btnEliminarServicio);
            this.Controls.Add(this.dtpInicioServicio);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dgvServicios);
            this.Controls.Add(this.cmbServicio);
            this.Controls.Add(this.dtpFechaInico);
            this.Controls.Add(this.lblTipoDeIng);
            this.Controls.Add(this.lblFechIn);
            this.Controls.Add(this.lblCedTit);
            this.Controls.Add(this.txtCedulaTitular);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModifServicios";
            this.Text = "frmModifServicios";
            this.Load += new System.EventHandler(this.frmModifServicios_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServicios)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvServicios;
        private System.Windows.Forms.ComboBox cmbServicio;
        private System.Windows.Forms.DateTimePicker dtpFechaInico;
        private System.Windows.Forms.Label lblTipoDeIng;
        private System.Windows.Forms.Label lblFechIn;
        private System.Windows.Forms.Label lblCedTit;
        private System.Windows.Forms.TextBox txtCedulaTitular;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.DateTimePicker dtpInicioServicio;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnEliminarServicio;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn clInicio;
        private System.Windows.Forms.DataGridViewTextBoxColumn clFin;
    }
}