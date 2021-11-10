namespace Capa_Presentacion.Formularios
{
    partial class frmRegEmpleados
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegEmpleados));
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.btnBorrarTelefono = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRegistra = new System.Windows.Forms.Button();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.listTelefonos = new System.Windows.Forms.ListBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.txtNomUsu = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.txtConfContra = new System.Windows.Forms.TextBox();
            this.cmbTipo = new System.Windows.Forms.ComboBox();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Registro de Empleados";
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
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
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
            this.panel1.TabIndex = 5;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(139, 89);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(229, 31);
            this.label10.TabIndex = 81;
            this.label10.Text = "Datos Personales";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(63, 385);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(109, 25);
            this.label9.TabIndex = 80;
            this.label9.Text = "Nacimiento";
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Location = new System.Drawing.Point(236, 382);
            this.dtpNacimiento.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(397, 26);
            this.dtpNacimiento.TabIndex = 65;
            // 
            // btnBorrarTelefono
            // 
            this.btnBorrarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrarTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTelefono.Location = new System.Drawing.Point(517, 518);
            this.btnBorrarTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnBorrarTelefono.Name = "btnBorrarTelefono";
            this.btnBorrarTelefono.Size = new System.Drawing.Size(120, 42);
            this.btnBorrarTelefono.TabIndex = 56;
            this.btnBorrarTelefono.TabStop = false;
            this.btnBorrarTelefono.Text = "Borrar";
            this.btnBorrarTelefono.UseVisualStyleBackColor = true;
            this.btnBorrarTelefono.Click += new System.EventHandler(this.btnBorrarTelefono_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(692, 635);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(247, 42);
            this.btnCancelar.TabIndex = 76;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnRegistra
            // 
            this.btnRegistra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegistra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRegistra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistra.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistra.Location = new System.Drawing.Point(396, 635);
            this.btnRegistra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegistra.Name = "btnRegistra";
            this.btnRegistra.Size = new System.Drawing.Size(247, 42);
            this.btnRegistra.TabIndex = 74;
            this.btnRegistra.Text = "Registrar";
            this.btnRegistra.UseVisualStyleBackColor = true;
            this.btnRegistra.Click += new System.EventHandler(this.btnRegistra_Click);
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefono.Location = new System.Drawing.Point(515, 447);
            this.btnAgregarTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(120, 42);
            this.btnAgregarTelefono.TabIndex = 73;
            this.btnAgregarTelefono.Text = "Agregar";
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // listTelefonos
            // 
            this.listTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTelefonos.FormattingEnabled = true;
            this.listTelefonos.ItemHeight = 20;
            this.listTelefonos.Location = new System.Drawing.Point(236, 500);
            this.listTelefonos.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.listTelefonos.Name = "listTelefonos";
            this.listTelefonos.Size = new System.Drawing.Size(233, 40);
            this.listTelefonos.TabIndex = 57;
            this.listTelefonos.TabStop = false;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(235, 454);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(233, 23);
            this.txtTelefono.TabIndex = 70;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoBinario.Location = new System.Drawing.Point(415, 421);
            this.rdbNoBinario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(109, 24);
            this.rdbNoBinario.TabIndex = 68;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMujer.Location = new System.Drawing.Point(333, 421);
            this.rdbMujer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(72, 24);
            this.rdbMujer.TabIndex = 67;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHombre.Location = new System.Drawing.Point(235, 421);
            this.rdbHombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(90, 24);
            this.rdbHombre.TabIndex = 66;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(63, 462);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 25);
            this.label8.TabIndex = 79;
            this.label8.Text = "Teléfono";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(63, 420);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 25);
            this.label7.TabIndex = 78;
            this.label7.Text = "Género";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(63, 341);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 25);
            this.label6.TabIndex = 77;
            this.label6.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 298);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 25);
            this.label5.TabIndex = 75;
            this.label5.Tag = "";
            this.label5.Text = "Mail";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(63, 252);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 25);
            this.label4.TabIndex = 72;
            this.label4.Text = "Apellidos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(63, 209);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 25);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombres";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(63, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 25);
            this.label2.TabIndex = 69;
            this.label2.Text = "Cédula";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(236, 341);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(399, 23);
            this.txtDireccion.TabIndex = 64;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            this.txtDireccion.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDireccion_KeyPress);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(453, 252);
            this.txtSegundoApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(181, 23);
            this.txtSegundoApellido.TabIndex = 62;
            this.txtSegundoApellido.TextChanged += new System.EventHandler(this.txtSegudoApellido_TextChanged);
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegudoApellido_KeyPress);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(236, 254);
            this.txtPrimerApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(181, 23);
            this.txtPrimerApellido.TabIndex = 61;
            this.txtPrimerApellido.TextChanged += new System.EventHandler(this.txtPrimerApellido_TextChanged);
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(236, 298);
            this.txtMail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(399, 23);
            this.txtMail.TabIndex = 63;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(453, 212);
            this.txtSegundoNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(181, 23);
            this.txtSegundoNombre.TabIndex = 60;
            this.txtSegundoNombre.TextChanged += new System.EventHandler(this.txtSegundoNombre_TextChanged);
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(236, 210);
            this.txtPrimerNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(181, 23);
            this.txtPrimerNombre.TabIndex = 59;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtPrimerNombre_TextChanged);
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(236, 167);
            this.txtCedula.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(399, 23);
            this.txtCedula.TabIndex = 58;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(717, 89);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(224, 31);
            this.label11.TabIndex = 82;
            this.label11.Text = "Datos de Usuario";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(719, 224);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(180, 25);
            this.label12.TabIndex = 83;
            this.label12.Text = "Nombre de Usuario";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(719, 268);
            this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(114, 25);
            this.label13.TabIndex = 84;
            this.label13.Text = "Contraseña";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(719, 180);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(66, 25);
            this.label14.TabIndex = 85;
            this.label14.Text = "Cargo";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(719, 310);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(204, 25);
            this.label15.TabIndex = 86;
            this.label15.Text = "Confirmar Contraseña";
            // 
            // txtNomUsu
            // 
            this.txtNomUsu.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtNomUsu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNomUsu.Location = new System.Drawing.Point(956, 224);
            this.txtNomUsu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNomUsu.Name = "txtNomUsu";
            this.txtNomUsu.Size = new System.Drawing.Size(221, 23);
            this.txtNomUsu.TabIndex = 87;
            this.txtNomUsu.TextChanged += new System.EventHandler(this.txtNomUsu_TextChanged);
            this.txtNomUsu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNomUsu_KeyPress);
            // 
            // txtContra
            // 
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.Location = new System.Drawing.Point(956, 267);
            this.txtContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(221, 23);
            this.txtContra.TabIndex = 88;
            this.txtContra.TextChanged += new System.EventHandler(this.txtContra_TextChanged);
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            // 
            // txtConfContra
            // 
            this.txtConfContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtConfContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfContra.Location = new System.Drawing.Point(955, 310);
            this.txtConfContra.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtConfContra.Name = "txtConfContra";
            this.txtConfContra.Size = new System.Drawing.Size(223, 23);
            this.txtConfContra.TabIndex = 89;
            this.txtConfContra.TextChanged += new System.EventHandler(this.txtConfContra_TextChanged);
            this.txtConfContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConfContra_KeyPress);
            // 
            // cmbTipo
            // 
            this.cmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cmbTipo.FormattingEnabled = true;
            this.cmbTipo.Items.AddRange(new object[] {
            "Administrativo",
            "Gerente"});
            this.cmbTipo.Location = new System.Drawing.Point(955, 175);
            this.cmbTipo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmbTipo.Name = "cmbTipo";
            this.cmbTipo.Size = new System.Drawing.Size(220, 28);
            this.cmbTipo.TabIndex = 90;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            this.errorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider.Icon")));
            // 
            // frmRegEmpleados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1333, 745);
            this.Controls.Add(this.cmbTipo);
            this.Controls.Add(this.txtConfContra);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.txtNomUsu);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.btnBorrarTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistra);
            this.Controls.Add(this.btnAgregarTelefono);
            this.Controls.Add(this.listTelefonos);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.rdbNoBinario);
            this.Controls.Add(this.rdbMujer);
            this.Controls.Add(this.rdbHombre);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmRegEmpleados";
            this.Text = "frmRegEmpleados";
            this.Load += new System.EventHandler(this.frmRegEmpleados_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Button btnBorrarTelefono;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRegistra;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.ListBox listTelefonos;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtNomUsu;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.TextBox txtConfContra;
        private System.Windows.Forms.ComboBox cmbTipo;
        private System.Windows.Forms.ErrorProvider errorProvider;
    }
}