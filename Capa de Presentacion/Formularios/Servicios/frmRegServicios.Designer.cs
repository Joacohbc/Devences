namespace Capa_Presentacion.Formularios.Servicios
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbTipoDeIngreso = new System.Windows.Forms.ComboBox();
            this.dtpFechaFin = new System.Windows.Forms.DateTimePicker();
            this.dtpFechaInico = new System.Windows.Forms.DateTimePicker();
            this.lblTipoDeIng = new System.Windows.Forms.Label();
            this.lblFechFin = new System.Windows.Forms.Label();
            this.lblFechIn = new System.Windows.Forms.Label();
            this.lblCedTit = new System.Windows.Forms.Label();
            this.txtCedulaTitular = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDescartar = new System.Windows.Forms.Button();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.capacidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(917, 7);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 32);
            this.button1.TabIndex = 8;
            this.button1.Text = "Salir";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
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
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 47);
            this.panel1.TabIndex = 9;
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
            this.cmbTipoDeIngreso.Location = new System.Drawing.Point(196, 178);
            this.cmbTipoDeIngreso.Name = "cmbTipoDeIngreso";
            this.cmbTipoDeIngreso.Size = new System.Drawing.Size(193, 24);
            this.cmbTipoDeIngreso.TabIndex = 100;
            // 
            // dtpFechaFin
            // 
            this.dtpFechaFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaFin.Location = new System.Drawing.Point(196, 283);
            this.dtpFechaFin.Name = "dtpFechaFin";
            this.dtpFechaFin.Size = new System.Drawing.Size(193, 23);
            this.dtpFechaFin.TabIndex = 99;
            // 
            // dtpFechaInico
            // 
            this.dtpFechaInico.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFechaInico.Location = new System.Drawing.Point(196, 252);
            this.dtpFechaInico.Name = "dtpFechaInico";
            this.dtpFechaInico.Size = new System.Drawing.Size(193, 23);
            this.dtpFechaInico.TabIndex = 98;
            // 
            // lblTipoDeIng
            // 
            this.lblTipoDeIng.AutoSize = true;
            this.lblTipoDeIng.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoDeIng.Location = new System.Drawing.Point(108, 182);
            this.lblTipoDeIng.Name = "lblTipoDeIng";
            this.lblTipoDeIng.Size = new System.Drawing.Size(64, 20);
            this.lblTipoDeIng.TabIndex = 97;
            this.lblTipoDeIng.Tag = "";
            this.lblTipoDeIng.Text = "Servicio";
            // 
            // lblFechFin
            // 
            this.lblFechFin.AutoSize = true;
            this.lblFechFin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechFin.Location = new System.Drawing.Point(74, 285);
            this.lblFechFin.Name = "lblFechFin";
            this.lblFechFin.Size = new System.Drawing.Size(31, 20);
            this.lblFechFin.TabIndex = 96;
            this.lblFechFin.Text = "Fin";
            // 
            // lblFechIn
            // 
            this.lblFechIn.AutoSize = true;
            this.lblFechIn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechIn.Location = new System.Drawing.Point(74, 255);
            this.lblFechIn.Name = "lblFechIn";
            this.lblFechIn.Size = new System.Drawing.Size(46, 20);
            this.lblFechIn.TabIndex = 95;
            this.lblFechIn.Text = "Inicio";
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
            this.txtCedulaTitular.Size = new System.Drawing.Size(193, 19);
            this.txtCedulaTitular.TabIndex = 93;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(409, 136);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(109, 28);
            this.btnBuscar.TabIndex = 101;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
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
            this.comboBox1.Location = new System.Drawing.Point(196, 351);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(193, 24);
            this.comboBox1.TabIndex = 102;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 355);
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
            this.btnDescartar.Location = new System.Drawing.Point(350, 444);
            this.btnDescartar.Name = "btnDescartar";
            this.btnDescartar.Size = new System.Drawing.Size(92, 36);
            this.btnDescartar.TabIndex = 105;
            this.btnDescartar.Text = "Descartar";
            this.btnDescartar.UseVisualStyleBackColor = true;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrar.Location = new System.Drawing.Point(196, 444);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(92, 36);
            this.btnRegistrar.TabIndex = 104;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.capacidad,
            this.precio});
            this.dataGridView1.Location = new System.Drawing.Point(626, 182);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(323, 289);
            this.dataGridView1.TabIndex = 106;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(622, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 24);
            this.label3.TabIndex = 107;
            this.label3.Text = "Servicios";
            // 
            // nombre
            // 
            this.nombre.Frozen = true;
            this.nombre.HeaderText = "Servicio";
            this.nombre.Name = "nombre";
            this.nombre.ReadOnly = true;
            // 
            // capacidad
            // 
            this.capacidad.Frozen = true;
            this.capacidad.HeaderText = "Capacidad Máxima";
            this.capacidad.Name = "capacidad";
            this.capacidad.ReadOnly = true;
            // 
            // precio
            // 
            this.precio.Frozen = true;
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
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnDescartar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.cmbTipoDeIngreso);
            this.Controls.Add(this.dtpFechaFin);
            this.Controls.Add(this.dtpFechaInico);
            this.Controls.Add(this.lblTipoDeIng);
            this.Controls.Add(this.lblFechFin);
            this.Controls.Add(this.lblFechIn);
            this.Controls.Add(this.lblCedTit);
            this.Controls.Add(this.txtCedulaTitular);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmRegServicios";
            this.Text = "frmRegServicios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbTipoDeIngreso;
        private System.Windows.Forms.DateTimePicker dtpFechaFin;
        private System.Windows.Forms.DateTimePicker dtpFechaInico;
        private System.Windows.Forms.Label lblTipoDeIng;
        private System.Windows.Forms.Label lblFechFin;
        private System.Windows.Forms.Label lblFechIn;
        private System.Windows.Forms.Label lblCedTit;
        private System.Windows.Forms.TextBox txtCedulaTitular;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDescartar;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn capacidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.Label label3;
    }
}