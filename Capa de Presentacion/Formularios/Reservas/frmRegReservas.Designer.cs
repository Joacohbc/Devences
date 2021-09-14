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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label18 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(210, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingreso de Reservas";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(1223, 9);
            this.btnSalir.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(100, 39);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbTipoDeIngreso
            // 
            this.cmbTipoDeIngreso.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoDeIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoDeIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoDeIngreso.FormattingEnabled = true;
            this.cmbTipoDeIngreso.Items.AddRange(new object[] {
            "Normal",
            "Hospedado",
            "Pensionista o Jubilado"});
            this.cmbTipoDeIngreso.Location = new System.Drawing.Point(240, 255);
            this.cmbTipoDeIngreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoDeIngreso.Name = "cmbTipoDeIngreso";
            this.cmbTipoDeIngreso.Size = new System.Drawing.Size(256, 28);
            this.cmbTipoDeIngreso.TabIndex = 92;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(240, 342);
            this.dtpFechaFin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(256, 26);
            this.dtpFechaFin.TabIndex = 91;
            // 
            // dtpFechaInico
            // 
            this.dtpFechaInico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInico.Location = new System.Drawing.Point(240, 304);
            this.dtpFechaInico.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpFechaInico.Name = "dtpFechaInico";
            this.dtpFechaInico.Size = new System.Drawing.Size(256, 26);
            this.dtpFechaInico.TabIndex = 90;
            // 
            // btnBorrarIntegrante
            // 
            this.btnBorrarIntegrante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrarIntegrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrarIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarIntegrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarIntegrante.Location = new System.Drawing.Point(1175, 233);
            this.btnBorrarIntegrante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarIntegrante.Name = "btnBorrarIntegrante";
            this.btnBorrarIntegrante.Size = new System.Drawing.Size(120, 34);
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
            this.dgvIntegrantes.Location = new System.Drawing.Point(628, 485);
            this.dgvIntegrantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvIntegrantes.MultiSelect = false;
            this.dgvIntegrantes.Name = "dgvIntegrantes";
            this.dgvIntegrantes.ReadOnly = true;
            this.dgvIntegrantes.Size = new System.Drawing.Size(648, 191);
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
            this.btnDescartar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDescartar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnDescartar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDescartar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDescartar.Location = new System.Drawing.Point(373, 526);
            this.btnDescartar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(123, 44);
            this.btnDescartar.TabIndex = 87;
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
            this.btnRegistrar.Location = new System.Drawing.Point(188, 526);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(123, 44);
            this.btnRegistrar.TabIndex = 86;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnAgregarIntegrante
            // 
            this.btnAgregarIntegrante.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarIntegrante.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarIntegrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarIntegrante.Location = new System.Drawing.Point(793, 331);
            this.btnAgregarIntegrante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarIntegrante.Name = "btnAgregarIntegrante";
            this.btnAgregarIntegrante.Size = new System.Drawing.Size(120, 34);
            this.btnAgregarIntegrante.TabIndex = 85;
            this.btnAgregarIntegrante.Text = "Agregar";
            this.btnAgregarIntegrante.UseVisualStyleBackColor = true;
            this.btnAgregarIntegrante.Click += new System.EventHandler(this.btnAgregarIntegrante_Click);
            // 
            // listIntegrantes
            // 
            this.listIntegrantes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listIntegrantes.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listIntegrantes.FormattingEnabled = true;
            this.listIntegrantes.ItemHeight = 25;
            this.listIntegrantes.Location = new System.Drawing.Point(979, 233);
            this.listIntegrantes.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listIntegrantes.Name = "listIntegrantes";
            this.listIntegrantes.Size = new System.Drawing.Size(188, 125);
            this.listIntegrantes.TabIndex = 84;
            // 
            // txtCedulaIntegrante
            // 
            this.txtCedulaIntegrante.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaIntegrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaIntegrante.Location = new System.Drawing.Point(725, 233);
            this.txtCedulaIntegrante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedulaIntegrante.Name = "txtCedulaIntegrante";
            this.txtCedulaIntegrante.Size = new System.Drawing.Size(245, 23);
            this.txtCedulaIntegrante.TabIndex = 83;
            this.txtCedulaIntegrante.TextChanged += new System.EventHandler(this.txtCedulaIntegrante_TextChanged);
            this.txtCedulaIntegrante.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaIntegrante_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(720, 198);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 25);
            this.label8.TabIndex = 82;
            this.label8.Text = "Cedula Integrantes";
            // 
            // lblTipoDeIng
            // 
            this.lblTipoDeIng.AutoSize = true;
            this.lblTipoDeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeIng.Location = new System.Drawing.Point(77, 260);
            this.lblTipoDeIng.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoDeIng.Name = "lblTipoDeIng";
            this.lblTipoDeIng.Size = new System.Drawing.Size(51, 25);
            this.lblTipoDeIng.TabIndex = 80;
            this.lblTipoDeIng.Tag = "";
            this.lblTipoDeIng.Text = "Tipo";
            // 
            // lblFechFin
            // 
            this.lblFechFin.AutoSize = true;
            this.lblFechFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechFin.Location = new System.Drawing.Point(77, 345);
            this.lblFechFin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechFin.Name = "lblFechFin";
            this.lblFechFin.Size = new System.Drawing.Size(39, 25);
            this.lblFechFin.TabIndex = 79;
            this.lblFechFin.Text = "Fin";
            // 
            // lblFechIn
            // 
            this.lblFechIn.AutoSize = true;
            this.lblFechIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechIn.Location = new System.Drawing.Point(77, 308);
            this.lblFechIn.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFechIn.Name = "lblFechIn";
            this.lblFechIn.Size = new System.Drawing.Size(57, 25);
            this.lblFechIn.TabIndex = 78;
            this.lblFechIn.Text = "Inicio";
            // 
            // lblCedTit
            // 
            this.lblCedTit.AutoSize = true;
            this.lblCedTit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCedTit.Location = new System.Drawing.Point(67, 209);
            this.lblCedTit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCedTit.Name = "lblCedTit";
            this.lblCedTit.Size = new System.Drawing.Size(134, 25);
            this.lblCedTit.TabIndex = 77;
            this.lblCedTit.Text = "Cédula Titular";
            // 
            // txtCedulaTitular
            // 
            this.txtCedulaTitular.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedulaTitular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedulaTitular.Location = new System.Drawing.Point(240, 206);
            this.txtCedulaTitular.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedulaTitular.Name = "txtCedulaTitular";
            this.txtCedulaTitular.Size = new System.Drawing.Size(257, 23);
            this.txtCedulaTitular.TabIndex = 75;
            this.txtCedulaTitular.TextChanged += new System.EventHandler(this.txtCedulaTitular_TextChanged);
            this.txtCedulaTitular.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedulaTitular_KeyPress);
            // 
            // cmbTipoIngresoIntegrante
            // 
            this.cmbTipoIngresoIntegrante.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoIngresoIntegrante.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoIngresoIntegrante.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoIngresoIntegrante.FormattingEnabled = true;
            this.cmbTipoIngresoIntegrante.Items.AddRange(new object[] {
            "Normal",
            "Hospedado",
            "Pensionista o Jubilado"});
            this.cmbTipoIngresoIntegrante.Location = new System.Drawing.Point(725, 272);
            this.cmbTipoIngresoIntegrante.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipoIngresoIntegrante.Name = "cmbTipoIngresoIntegrante";
            this.cmbTipoIngresoIntegrante.Size = new System.Drawing.Size(244, 28);
            this.cmbTipoIngresoIntegrante.TabIndex = 95;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(633, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 25);
            this.label2.TabIndex = 96;
            this.label2.Tag = "";
            this.label2.Text = "Tipo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(629, 438);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
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
            this.chkConfirmada.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkConfirmada.Location = new System.Drawing.Point(240, 441);
            this.chkConfirmada.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chkConfirmada.Name = "chkConfirmada";
            this.chkConfirmada.Size = new System.Drawing.Size(128, 28);
            this.chkConfirmada.TabIndex = 98;
            this.chkConfirmada.Text = "Confirmada";
            this.chkConfirmada.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalir);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1333, 58);
            this.panel1.TabIndex = 99;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(155, 110);
            this.label18.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(90, 31);
            this.label18.TabIndex = 100;
            this.label18.Text = "Titular";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 110);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 31);
            this.label4.TabIndex = 101;
            this.label4.Text = "Integrantes";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 385);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 25);
            this.label5.TabIndex = 102;
            this.label5.Text = "Método de Pago";
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Normal",
            "Hospedado",
            "Pensionista o Jubilado"});
            this.comboBox1.Location = new System.Drawing.Point(240, 385);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(257, 28);
            this.comboBox1.TabIndex = 103;
            // 
            // frmRegReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1333, 745);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.panel1);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegReservas";
            this.Text = "frmRegReservas";
            this.Load += new System.EventHandler(this.frmRegReservas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvIntegrantes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label5;
    }
}