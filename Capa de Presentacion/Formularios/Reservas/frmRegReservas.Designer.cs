namespace Capa_Presentacion.Formularios
{
    partial class frmRegReservas
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbTipoDeIngreso = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInico = new System.Windows.Forms.DateTimePicker();
            this.btnBorrarIntegrante = new System.Windows.Forms.Button();
            this.dgvIntegrantes = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Genero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDeIngreso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnAgregarIntegrante = new System.Windows.Forms.Button();
            this.listIntegrantes = new System.Windows.Forms.ListBox();
            this.txtCedulaIntegrante = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.lblTipoDeIng = new System.Windows.Forms.Label();
            this.lblFechFin = new System.Windows.Forms.Label();
            this.lblFechIn = new System.Windows.Forms.Label();
            this.lblCedTit = new System.Windows.Forms.Label();
            this.txtCedulaTitular = new System.Windows.Forms.TextBox();
            this.cmbTipoIngresoIntegrante = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.chkConfirmada = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(406, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso de Reservas";
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(913, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTipoDeIngreso
            // 
            this.cmbTipoDeIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeIngreso.FormattingEnabled = true;
            this.cmbTipoDeIngreso.Items.AddRange(new object[] {
            "Normal",
            "Hospedado",
            "Pensionista o Jubilado"});
            this.cmbTipoDeIngreso.Location = new System.Drawing.Point(197, 160);
            this.cmbTipoDeIngreso.Name = "cmbTipoDeIngreso";
            this.cmbTipoDeIngreso.Size = new System.Drawing.Size(193, 21);
            this.cmbTipoDeIngreso.TabIndex = 92;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Location = new System.Drawing.Point(197, 216);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaFin.TabIndex = 91;
            // 
            // dtpFechaInico
            // 
            this.dtpFechaInico.Location = new System.Drawing.Point(197, 189);
            this.dtpFechaInico.Name = "dtpFechaInico";
            this.dtpFechaInico.Size = new System.Drawing.Size(193, 20);
            this.dtpFechaInico.TabIndex = 90;
            // 
            // btnBorrarIntegrante
            // 
            this.btnBorrarIntegrante.Location = new System.Drawing.Point(867, 128);
            this.btnBorrarIntegrante.Name = "btnBorrarIntegrante";
            this.btnBorrarIntegrante.Size = new System.Drawing.Size(75, 23);
            this.btnBorrarIntegrante.TabIndex = 89;
            this.btnBorrarIntegrante.Text = "Borrar";
            this.btnBorrarIntegrante.UseVisualStyleBackColor = true;
            this.btnBorrarIntegrante.Click += new System.EventHandler(this.btnBorrarIntegrante_Click);
            // 
            // dgvIntegrantes
            // 
            this.dgvIntegrantes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Genero,
            this.tipoDeIngreso});
            this.dgvIntegrantes.Location = new System.Drawing.Point(456, 274);
            this.dgvIntegrantes.MultiSelect = false;
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.ReadOnly = true;
            this.dgvIntegrantes.Size = new System.Drawing.Size(486, 155);
            this.dgvIntegrantes.TabIndex = 88;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Genero
            // 
            this.Genero.HeaderText = "Genero";
            this.Genero.Name = "Genero";
            this.Genero.ReadOnly = true;
            // 
            // tipoDeIngreso
            // 
            this.tipoDeIngreso.HeaderText = "Tipo de Ingreso";
            this.tipoDeIngreso.Name = "tipoDeIngreso";
            this.tipoDeIngreso.ReadOnly = true;
            this.tipoDeIngreso.Width = 140;
            // 
            // btnDescartar
            // 
            this.btnDescartar.Location = new System.Drawing.Point(303, 406);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(87, 23);
            this.btnDescartar.TabIndex = 87;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            this.btnDescartar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(197, 406);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(100, 23);
            this.btnRegistrar.TabIndex = 86;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAgregarIntegrante
            // 
            this.btnAgregarIntegrante.Location = new System.Drawing.Point(585, 191);
            this.btnAgregarIntegrante.Name = "btnAgregarIntegrante";
            this.btnAgregarIntegrante.Size = new System.Drawing.Size(128, 23);
            this.btnAgregarIntegrante.TabIndex = 85;
            this.btnAgregarIntegrante.Text = "Agregar";
            this.btnAgregarIntegrante.UseVisualStyleBackColor = true;
            this.btnAgregarIntegrante.Click += new System.EventHandler(this.btnAgregarIntegrante_Click);
            // 
            // listIntegrantes
            // 
            this.listIntegrantes.FormattingEnabled = true;
            this.listIntegrantes.Location = new System.Drawing.Point(761, 128);
            this.listIntegrantes.Name = "listIntegrantes";
            this.listIntegrantes.Size = new System.Drawing.Size(100, 95);
            this.listIntegrantes.TabIndex = 84;
            // 
            // txtCedulaIntegrante
            // 
            this.txtCedulaIntegrante.Location = new System.Drawing.Point(555, 128);
            this.txtCedulaIntegrante.Name = "txtCedulaIntegrante";
            this.txtCedulaIntegrante.Size = new System.Drawing.Size(184, 20);
            this.txtCedulaIntegrante.TabIndex = 83;
            this.txtCedulaIntegrante.TextChanged += new System.EventHandler(this.txtCedulaIntegrante_TextChanged);
            this.txtCedulaIntegrante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaIntegrante_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(453, 131);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "Cedula Integrantes";
            // 
            // lblTipoDeIng
            // 
            this.lblTipoDeIng.AutoSize = true;
            this.lblTipoDeIng.Location = new System.Drawing.Point(142, 160);
            this.lblTipoDeIng.Name = "lblTipoDeIng";
            this.lblTipoDeIng.Size = new System.Drawing.Size(28, 13);
            this.lblTipoDeIng.TabIndex = 80;
            this.lblTipoDeIng.Tag = "";
            this.lblTipoDeIng.Text = "Tipo";
            // 
            // lblFechFin
            // 
            this.lblFechFin.AutoSize = true;
            this.lblFechFin.Location = new System.Drawing.Point(142, 216);
            this.lblFechFin.Name = "lblFechFin";
            this.lblFechFin.Size = new System.Drawing.Size(21, 13);
            this.lblFechFin.TabIndex = 79;
            this.lblFechFin.Text = "Fin";
            // 
            // lblFechIn
            // 
            this.lblFechIn.AutoSize = true;
            this.lblFechIn.Location = new System.Drawing.Point(141, 189);
            this.lblFechIn.Name = "lblFechIn";
            this.lblFechIn.Size = new System.Drawing.Size(32, 13);
            this.lblFechIn.TabIndex = 78;
            this.lblFechIn.Text = "Inicio";
            // 
            // lblCedTit
            // 
            this.lblCedTit.AutoSize = true;
            this.lblCedTit.Location = new System.Drawing.Point(116, 136);
            this.lblCedTit.Name = "lblCedTit";
            this.lblCedTit.Size = new System.Drawing.Size(72, 13);
            this.lblCedTit.TabIndex = 77;
            this.lblCedTit.Text = "Cédula Titular";
            // 
            // txtCedulaTitular
            // 
            this.txtCedulaTitular.Location = new System.Drawing.Point(197, 133);
            this.txtCedulaTitular.Name = "txtCedulaTitular";
            this.txtCedulaTitular.Size = new System.Drawing.Size(193, 20);
            this.txtCedulaTitular.TabIndex = 75;
            this.txtCedulaTitular.TextChanged += new System.EventHandler(this.txtCedulaTitular_TextChanged);
            this.txtCedulaTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaTitular_KeyPress);
            // 
            // cmbTipoIngresoIntegrante
            // 
            this.cmbTipoIngresoIntegrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIngresoIntegrante.FormattingEnabled = true;
            this.cmbTipoIngresoIntegrante.Items.AddRange(new object[] {
            "Normal",
            "Hospedado",
            "Pensionista o Jubilado"});
            this.cmbTipoIngresoIntegrante.Location = new System.Drawing.Point(555, 160);
            this.cmbTipoIngresoIntegrante.Name = "cmbTipoIngresoIntegrante";
            this.cmbTipoIngresoIntegrante.Size = new System.Drawing.Size(184, 21);
            this.cmbTipoIngresoIntegrante.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(521, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 96;
            this.label2.Tag = "";
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(453, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 97;
            this.label3.Text = "Integrantes";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // chkConfirmada
            // 
            this.chkConfirmada.AutoSize = true;
            this.chkConfirmada.Location = new System.Drawing.Point(197, 242);
            this.chkConfirmada.Name = "chkConfirmada";
            this.chkConfirmada.Size = new System.Drawing.Size(79, 17);
            this.chkConfirmada.TabIndex = 98;
            this.chkConfirmada.Text = "Confirmada";
            this.chkConfirmada.UseVisualStyleBackColor = true;
            // 
            // frmRegReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.btnAgregarIntegrante);
            this.Controls.Add(this.chkConfirmada);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbTipoIngresoIntegrante);
            this.Controls.Add(this.cmbTipoDeIngreso);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInico);
            this.Controls.Add(this.btnBorrarIntegrante);
            this.Controls.Add(this.dgvIntegrantes);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.listIntegrantes);
            this.Controls.Add(this.txtCedulaIntegrante);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblTipoDeIng);
            this.Controls.Add(this.lblFechFin);
            this.Controls.Add(this.lblFechIn);
            this.Controls.Add(this.lblCedTit);
            this.Controls.Add(this.txtCedulaTitular);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegReservas";
            this.Text = "frmRegReservas";
            this.Load += new System.EventHandler(this.frmRegReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbTipoDeIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInico;
        private System.Windows.Forms.Button btnBorrarIntegrante;
        private System.Windows.Forms.DataGridView dgvIntegrantes;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnAgregarIntegrante;
        private System.Windows.Forms.ListBox listIntegrantes;
        private System.Windows.Forms.TextBox txtCedulaIntegrante;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblTipoDeIng;
        private System.Windows.Forms.Label lblFechFin;
        private System.Windows.Forms.Label lblFechIn;
        private System.Windows.Forms.Label lblCedTit;
        private System.Windows.Forms.TextBox txtCedulaTitular;
        private System.Windows.Forms.ComboBox cmbTipoIngresoIntegrante;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.CheckBox chkConfirmada;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Genero;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDeIngreso;
    }
}