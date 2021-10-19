namespace Capa_Presentacion.Formularios
{
    partial class frmModClientes
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
            this.txtPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.txtSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.rdbHombre = new System.Windows.Forms.RadioButton();
            this.rdbMujer = new System.Windows.Forms.RadioButton();
            this.rdbNoBinario = new System.Windows.Forms.RadioButton();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.listTelefonos = new System.Windows.Forms.ListBox();
            this.btnAgregarTelefono = new System.Windows.Forms.Button();
            this.btnBorrarTelefono = new System.Windows.Forms.Button();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.label10 = new System.Windows.Forms.Label();
            this.dtpModificarNacimiento = new System.Windows.Forms.DateTimePicker();
            this.listModificarTelefonos = new System.Windows.Forms.ListBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.txtModificarDireccion = new System.Windows.Forms.TextBox();
            this.txtModificarSegundoApellido = new System.Windows.Forms.TextBox();
            this.txtModificarPrimerApellido = new System.Windows.Forms.TextBox();
            this.txtModificarMail = new System.Windows.Forms.TextBox();
            this.txtModificarSegundoNombre = new System.Windows.Forms.TextBox();
            this.txtModificarPrimerNombre = new System.Windows.Forms.TextBox();
            this.txtCedula = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.chkModificarHombre = new System.Windows.Forms.CheckBox();
            this.chkModificarMujer = new System.Windows.Forms.CheckBox();
            this.chkModificarNoBinario = new System.Windows.Forms.CheckBox();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.pnTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(204, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Modificacion de Clientes";
            // 
            // btnSalir
            // 
            this.btnSalir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalir.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalir.Location = new System.Drawing.Point(914, 7);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 32);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.TabStop = false;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerNombre.Location = new System.Drawing.Point(619, 156);
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.Size = new System.Drawing.Size(136, 19);
            this.txtPrimerNombre.TabIndex = 1;
            this.txtPrimerNombre.TextChanged += new System.EventHandler(this.txtPrimerNombre_TextChanged);
            this.txtPrimerNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerNombre_KeyPress);
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoNombre.Location = new System.Drawing.Point(782, 157);
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.Size = new System.Drawing.Size(136, 19);
            this.txtSegundoNombre.TabIndex = 2;
            this.txtSegundoNombre.TextChanged += new System.EventHandler(this.txtSegundoNombre_TextChanged);
            this.txtSegundoNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegundoNombre_KeyPress);
            // 
            // txtMail
            // 
            this.txtMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMail.Location = new System.Drawing.Point(619, 228);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(299, 19);
            this.txtMail.TabIndex = 5;
            this.txtMail.TextChanged += new System.EventHandler(this.txtMail_TextChanged);
            this.txtMail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMail_KeyPress);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSegundoApellido.Enabled = false;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSegundoApellido.Location = new System.Drawing.Point(782, 191);
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.Size = new System.Drawing.Size(136, 19);
            this.txtSegundoApellido.TabIndex = 4;
            this.txtSegundoApellido.TextChanged += new System.EventHandler(this.txtSegudoApellido_TextChanged);
            this.txtSegundoApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSegudoApellido_KeyPress);
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPrimerApellido.Enabled = false;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrimerApellido.Location = new System.Drawing.Point(619, 191);
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.Size = new System.Drawing.Size(136, 19);
            this.txtPrimerApellido.TabIndex = 3;
            this.txtPrimerApellido.TextChanged += new System.EventHandler(this.txtPrimerApellido_TextChanged);
            this.txtPrimerApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPrimerApellido_KeyPress);
            // 
            // txtDireccion
            // 
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDireccion.Location = new System.Drawing.Point(619, 262);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(299, 19);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(516, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Nombres";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(516, 189);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Apellido";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(516, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 14;
            this.label5.Tag = "";
            this.label5.Text = "Mail";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(516, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Dirección";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(515, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(63, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Género";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(515, 364);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Teléfono";
            // 
            // rdbHombre
            // 
            this.rdbHombre.AutoSize = true;
            this.rdbHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbHombre.Location = new System.Drawing.Point(617, 331);
            this.rdbHombre.Name = "rdbHombre";
            this.rdbHombre.Size = new System.Drawing.Size(76, 21);
            this.rdbHombre.TabIndex = 8;
            this.rdbHombre.TabStop = true;
            this.rdbHombre.Text = "Hombre";
            this.rdbHombre.UseVisualStyleBackColor = true;
            // 
            // rdbMujer
            // 
            this.rdbMujer.AutoSize = true;
            this.rdbMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbMujer.Location = new System.Drawing.Point(691, 331);
            this.rdbMujer.Name = "rdbMujer";
            this.rdbMujer.Size = new System.Drawing.Size(61, 21);
            this.rdbMujer.TabIndex = 19;
            this.rdbMujer.TabStop = true;
            this.rdbMujer.Text = "Mujer";
            this.rdbMujer.UseVisualStyleBackColor = true;
            // 
            // rdbNoBinario
            // 
            this.rdbNoBinario.AutoSize = true;
            this.rdbNoBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbNoBinario.Location = new System.Drawing.Point(752, 331);
            this.rdbNoBinario.Name = "rdbNoBinario";
            this.rdbNoBinario.Size = new System.Drawing.Size(92, 21);
            this.rdbNoBinario.TabIndex = 20;
            this.rdbNoBinario.TabStop = true;
            this.rdbNoBinario.Text = "No Binario";
            this.rdbNoBinario.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(619, 365);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(191, 19);
            this.txtTelefono.TabIndex = 9;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // listTelefonos
            // 
            this.listTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listTelefonos.FormattingEnabled = true;
            this.listTelefonos.ItemHeight = 20;
            this.listTelefonos.Location = new System.Drawing.Point(620, 394);
            this.listTelefonos.Name = "listTelefonos";
            this.listTelefonos.Size = new System.Drawing.Size(193, 80);
            this.listTelefonos.TabIndex = 22;
            this.listTelefonos.UseTabStops = false;
            this.listTelefonos.DoubleClick += new System.EventHandler(this.listTelefonos_DoubleClick);
            // 
            // btnAgregarTelefono
            // 
            this.btnAgregarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnAgregarTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnAgregarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregarTelefono.Location = new System.Drawing.Point(828, 365);
            this.btnAgregarTelefono.Name = "btnAgregarTelefono";
            this.btnAgregarTelefono.Size = new System.Drawing.Size(90, 28);
            this.btnAgregarTelefono.TabIndex = 10;
            this.btnAgregarTelefono.Text = "Agregar";
            this.btnAgregarTelefono.UseVisualStyleBackColor = true;
            this.btnAgregarTelefono.Click += new System.EventHandler(this.btnAgregarTelefono_Click);
            // 
            // btnBorrarTelefono
            // 
            this.btnBorrarTelefono.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnBorrarTelefono.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBorrarTelefono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBorrarTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrarTelefono.Location = new System.Drawing.Point(828, 400);
            this.btnBorrarTelefono.Name = "btnBorrarTelefono";
            this.btnBorrarTelefono.Size = new System.Drawing.Size(90, 28);
            this.btnBorrarTelefono.TabIndex = 51;
            this.btnBorrarTelefono.TabStop = false;
            this.btnBorrarTelefono.Text = "Borrar";
            this.btnBorrarTelefono.UseVisualStyleBackColor = true;
            this.btnBorrarTelefono.Click += new System.EventHandler(this.btnBorrarTelefono_Click);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Enabled = false;
            this.dtpNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpNacimiento.Location = new System.Drawing.Point(619, 296);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(299, 23);
            this.dtpNacimiento.TabIndex = 7;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(516, 296);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(88, 20);
            this.label9.TabIndex = 53;
            this.label9.Text = "Nacimiento";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(39, 332);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 20);
            this.label10.TabIndex = 78;
            this.label10.Text = "Nacimiento";
            // 
            // dtpModificarNacimiento
            // 
            this.dtpModificarNacimiento.Enabled = false;
            this.dtpModificarNacimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpModificarNacimiento.Location = new System.Drawing.Point(155, 332);
            this.dtpModificarNacimiento.Name = "dtpModificarNacimiento";
            this.dtpModificarNacimiento.Size = new System.Drawing.Size(301, 23);
            this.dtpModificarNacimiento.TabIndex = 77;
            this.dtpModificarNacimiento.TabStop = false;
            // 
            // listModificarTelefonos
            // 
            this.listModificarTelefonos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listModificarTelefonos.Enabled = false;
            this.listModificarTelefonos.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listModificarTelefonos.FormattingEnabled = true;
            this.listModificarTelefonos.ItemHeight = 16;
            this.listModificarTelefonos.Location = new System.Drawing.Point(155, 406);
            this.listModificarTelefonos.Name = "listModificarTelefonos";
            this.listModificarTelefonos.Size = new System.Drawing.Size(301, 64);
            this.listModificarTelefonos.TabIndex = 72;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(39, 400);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 20);
            this.label11.TabIndex = 67;
            this.label11.Text = "Teléfono";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 367);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 66;
            this.label12.Text = "Género";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(39, 297);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(75, 20);
            this.label13.TabIndex = 65;
            this.label13.Text = "Dirección";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(40, 263);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(37, 20);
            this.label14.TabIndex = 64;
            this.label14.Tag = "";
            this.label14.Text = "Mail";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(40, 225);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 20);
            this.label15.TabIndex = 63;
            this.label15.Text = "Apellido";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(39, 191);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(73, 20);
            this.label16.TabIndex = 62;
            this.label16.Text = "Nombres";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(39, 156);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 20);
            this.label17.TabIndex = 61;
            this.label17.Text = "Cédula";
            // 
            // txtModificarDireccion
            // 
            this.txtModificarDireccion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarDireccion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarDireccion.Location = new System.Drawing.Point(155, 298);
            this.txtModificarDireccion.Name = "txtModificarDireccion";
            this.txtModificarDireccion.ReadOnly = true;
            this.txtModificarDireccion.Size = new System.Drawing.Size(301, 19);
            this.txtModificarDireccion.TabIndex = 60;
            this.txtModificarDireccion.TabStop = false;
            // 
            // txtModificarSegundoApellido
            // 
            this.txtModificarSegundoApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarSegundoApellido.Location = new System.Drawing.Point(320, 226);
            this.txtModificarSegundoApellido.Name = "txtModificarSegundoApellido";
            this.txtModificarSegundoApellido.ReadOnly = true;
            this.txtModificarSegundoApellido.Size = new System.Drawing.Size(136, 19);
            this.txtModificarSegundoApellido.TabIndex = 59;
            this.txtModificarSegundoApellido.TabStop = false;
            // 
            // txtModificarPrimerApellido
            // 
            this.txtModificarPrimerApellido.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarPrimerApellido.Location = new System.Drawing.Point(155, 226);
            this.txtModificarPrimerApellido.Name = "txtModificarPrimerApellido";
            this.txtModificarPrimerApellido.ReadOnly = true;
            this.txtModificarPrimerApellido.Size = new System.Drawing.Size(138, 19);
            this.txtModificarPrimerApellido.TabIndex = 58;
            this.txtModificarPrimerApellido.TabStop = false;
            // 
            // txtModificarMail
            // 
            this.txtModificarMail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarMail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarMail.Location = new System.Drawing.Point(155, 264);
            this.txtModificarMail.Name = "txtModificarMail";
            this.txtModificarMail.ReadOnly = true;
            this.txtModificarMail.Size = new System.Drawing.Size(301, 19);
            this.txtModificarMail.TabIndex = 57;
            this.txtModificarMail.TabStop = false;
            // 
            // txtModificarSegundoNombre
            // 
            this.txtModificarSegundoNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarSegundoNombre.Location = new System.Drawing.Point(320, 192);
            this.txtModificarSegundoNombre.Name = "txtModificarSegundoNombre";
            this.txtModificarSegundoNombre.ReadOnly = true;
            this.txtModificarSegundoNombre.Size = new System.Drawing.Size(136, 19);
            this.txtModificarSegundoNombre.TabIndex = 56;
            this.txtModificarSegundoNombre.TabStop = false;
            // 
            // txtModificarPrimerNombre
            // 
            this.txtModificarPrimerNombre.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtModificarPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModificarPrimerNombre.Location = new System.Drawing.Point(155, 191);
            this.txtModificarPrimerNombre.Name = "txtModificarPrimerNombre";
            this.txtModificarPrimerNombre.ReadOnly = true;
            this.txtModificarPrimerNombre.Size = new System.Drawing.Size(138, 19);
            this.txtModificarPrimerNombre.TabIndex = 55;
            this.txtModificarPrimerNombre.TabStop = false;
            // 
            // txtCedula
            // 
            this.txtCedula.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtCedula.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCedula.Location = new System.Drawing.Point(155, 157);
            this.txtCedula.Name = "txtCedula";
            this.txtCedula.Size = new System.Drawing.Size(138, 19);
            this.txtCedula.TabIndex = 54;
            this.txtCedula.TabStop = false;
            this.txtCedula.TextChanged += new System.EventHandler(this.txtCedula_TextChanged);
            this.txtCedula.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCedula_KeyPress);
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.Location = new System.Drawing.Point(320, 153);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(136, 28);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(752, 533);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 36);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Descartar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnDescartar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(601, 533);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(92, 36);
            this.btnModificar.TabIndex = 11;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // chkModificarHombre
            // 
            this.chkModificarHombre.AutoSize = true;
            this.chkModificarHombre.Enabled = false;
            this.chkModificarHombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificarHombre.Location = new System.Drawing.Point(156, 371);
            this.chkModificarHombre.Name = "chkModificarHombre";
            this.chkModificarHombre.Size = new System.Drawing.Size(77, 21);
            this.chkModificarHombre.TabIndex = 79;
            this.chkModificarHombre.TabStop = false;
            this.chkModificarHombre.Text = "Hombre";
            this.chkModificarHombre.UseVisualStyleBackColor = true;
            // 
            // chkModificarMujer
            // 
            this.chkModificarMujer.AutoSize = true;
            this.chkModificarMujer.Enabled = false;
            this.chkModificarMujer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificarMujer.Location = new System.Drawing.Point(237, 371);
            this.chkModificarMujer.Name = "chkModificarMujer";
            this.chkModificarMujer.Size = new System.Drawing.Size(62, 21);
            this.chkModificarMujer.TabIndex = 80;
            this.chkModificarMujer.TabStop = false;
            this.chkModificarMujer.Text = "Mujer";
            this.chkModificarMujer.UseVisualStyleBackColor = true;
            // 
            // chkModificarNoBinario
            // 
            this.chkModificarNoBinario.AutoSize = true;
            this.chkModificarNoBinario.Enabled = false;
            this.chkModificarNoBinario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkModificarNoBinario.Location = new System.Drawing.Point(303, 371);
            this.chkModificarNoBinario.Name = "chkModificarNoBinario";
            this.chkModificarNoBinario.Size = new System.Drawing.Size(93, 21);
            this.chkModificarNoBinario.TabIndex = 81;
            this.chkModificarNoBinario.TabStop = false;
            this.chkModificarNoBinario.Text = "No Binario";
            this.chkModificarNoBinario.UseVisualStyleBackColor = true;
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnTitulo.Controls.Add(this.label1);
            this.pnTitulo.Controls.Add(this.btnSalir);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1000, 47);
            this.pnTitulo.TabIndex = 82;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(134, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(159, 26);
            this.label2.TabIndex = 83;
            this.label2.Text = "Datos Actuales";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(571, 85);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(181, 26);
            this.label18.TabIndex = 84;
            this.label18.Text = "Datos a Modificar";
            // 
            // frmModClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pnTitulo);
            this.Controls.Add(this.chkModificarNoBinario);
            this.Controls.Add(this.chkModificarMujer);
            this.Controls.Add(this.chkModificarHombre);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dtpModificarNacimiento);
            this.Controls.Add(this.listModificarTelefonos);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtModificarDireccion);
            this.Controls.Add(this.txtModificarSegundoApellido);
            this.Controls.Add(this.txtModificarPrimerApellido);
            this.Controls.Add(this.txtModificarMail);
            this.Controls.Add(this.txtModificarSegundoNombre);
            this.Controls.Add(this.txtModificarPrimerNombre);
            this.Controls.Add(this.txtCedula);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.btnBorrarTelefono);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnModificar);
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
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.txtSegundoApellido);
            this.Controls.Add(this.txtPrimerApellido);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.txtSegundoNombre);
            this.Controls.Add(this.txtPrimerNombre);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmModClientes";
            this.Text = "frmRegClientes";
            this.Load += new System.EventHandler(this.frmRegClientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.TextBox txtPrimerNombre;
        private System.Windows.Forms.TextBox txtSegundoNombre;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.TextBox txtSegundoApellido;
        private System.Windows.Forms.TextBox txtPrimerApellido;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rdbHombre;
        private System.Windows.Forms.RadioButton rdbMujer;
        private System.Windows.Forms.RadioButton rdbNoBinario;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ListBox listTelefonos;
        private System.Windows.Forms.Button btnAgregarTelefono;
        private System.Windows.Forms.Button btnBorrarTelefono;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ErrorProvider errorProvider;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DateTimePicker dtpModificarNacimiento;
        private System.Windows.Forms.ListBox listModificarTelefonos;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtModificarDireccion;
        private System.Windows.Forms.TextBox txtModificarSegundoApellido;
        private System.Windows.Forms.TextBox txtModificarPrimerApellido;
        private System.Windows.Forms.TextBox txtModificarMail;
        private System.Windows.Forms.TextBox txtModificarSegundoNombre;
        private System.Windows.Forms.TextBox txtModificarPrimerNombre;
        private System.Windows.Forms.TextBox txtCedula;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.CheckBox chkModificarHombre;
        private System.Windows.Forms.CheckBox chkModificarMujer;
        private System.Windows.Forms.CheckBox chkModificarNoBinario;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label2;
    }
}