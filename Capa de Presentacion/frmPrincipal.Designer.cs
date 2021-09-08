namespace Capa_Presentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.pnForms = new System.Windows.Forms.Panel();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.pnSubMenuGerente = new System.Windows.Forms.Panel();
            this.btnRegEmp = new System.Windows.Forms.Button();
            this.btnModifEmp = new System.Windows.Forms.Button();
            this.btnModifPyH = new System.Windows.Forms.Button();
            this.btnMenuGerente = new System.Windows.Forms.Button();
            this.pnSubMenuServicios = new System.Windows.Forms.Panel();
            this.btnModifServ = new System.Windows.Forms.Button();
            this.btnRegServ = new System.Windows.Forms.Button();
            this.btnMenuServicios = new System.Windows.Forms.Button();
            this.pnSubMenuReservas = new System.Windows.Forms.Panel();
            this.btnModifRes = new System.Windows.Forms.Button();
            this.btnIngRes = new System.Windows.Forms.Button();
            this.btnMenuReservas = new System.Windows.Forms.Button();
            this.pnSubMenuClientes = new System.Windows.Forms.Panel();
            this.btnRegCli = new System.Windows.Forms.Button();
            this.btnModifCli = new System.Windows.Forms.Button();
            this.btnMenuClientes = new System.Windows.Forms.Button();
            this.pnSubMenuInfo = new System.Windows.Forms.Panel();
            this.btnInfoPyH = new System.Windows.Forms.Button();
            this.btnConsultas = new System.Windows.Forms.Button();
            this.btnMenuInfo = new System.Windows.Forms.Button();
            this.pnBarra = new System.Windows.Forms.Panel();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.picUsuario = new System.Windows.Forms.PictureBox();
            this.pnMenuSize = new System.Windows.Forms.Panel();
            this.btnMinimizarMenu = new System.Windows.Forms.Button();
            this.pnBordeMenu = new System.Windows.Forms.Panel();
            this.pnForms.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.pnMenu.SuspendLayout();
            this.pnSubMenuGerente.SuspendLayout();
            this.pnSubMenuServicios.SuspendLayout();
            this.pnSubMenuReservas.SuspendLayout();
            this.pnSubMenuClientes.SuspendLayout();
            this.pnSubMenuInfo.SuspendLayout();
            this.pnBarra.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).BeginInit();
            this.pnMenuSize.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnForms
            // 
            this.pnForms.BackColor = System.Drawing.Color.White;
            this.pnForms.Controls.Add(this.picLogo);
            this.pnForms.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnForms.Location = new System.Drawing.Point(205, 40);
            this.pnForms.Name = "pnForms";
            this.pnForms.Size = new System.Drawing.Size(1000, 605);
            this.pnForms.TabIndex = 2;
            // 
            // picLogo
            // 
            this.picLogo.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.picLogo.BackColor = System.Drawing.Color.SteelBlue;
            this.picLogo.Image = global::Capa_Presentacion.Properties.Resources.logoAzul;
            this.picLogo.Location = new System.Drawing.Point(256, 200);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(378, 148);
            this.picLogo.TabIndex = 0;
            this.picLogo.TabStop = false;
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.PowderBlue;
            this.pnMenu.Controls.Add(this.pnSubMenuGerente);
            this.pnMenu.Controls.Add(this.btnMenuGerente);
            this.pnMenu.Controls.Add(this.pnSubMenuServicios);
            this.pnMenu.Controls.Add(this.btnMenuServicios);
            this.pnMenu.Controls.Add(this.pnSubMenuReservas);
            this.pnMenu.Controls.Add(this.btnMenuReservas);
            this.pnMenu.Controls.Add(this.pnSubMenuClientes);
            this.pnMenu.Controls.Add(this.btnMenuClientes);
            this.pnMenu.Controls.Add(this.pnSubMenuInfo);
            this.pnMenu.Controls.Add(this.btnMenuInfo);
            this.pnMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenu.Location = new System.Drawing.Point(0, 40);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(174, 605);
            this.pnMenu.TabIndex = 1;
            // 
            // pnSubMenuGerente
            // 
            this.pnSubMenuGerente.Controls.Add(this.btnRegEmp);
            this.pnSubMenuGerente.Controls.Add(this.btnModifEmp);
            this.pnSubMenuGerente.Controls.Add(this.btnModifPyH);
            this.pnSubMenuGerente.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuGerente.Location = new System.Drawing.Point(0, 480);
            this.pnSubMenuGerente.Name = "pnSubMenuGerente";
            this.pnSubMenuGerente.Size = new System.Drawing.Size(174, 105);
            this.pnSubMenuGerente.TabIndex = 17;
            this.pnSubMenuGerente.Visible = false;
            // 
            // btnRegEmp
            // 
            this.btnRegEmp.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRegEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnRegEmp.FlatAppearance.BorderSize = 0;
            this.btnRegEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnRegEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegEmp.Location = new System.Drawing.Point(0, 0);
            this.btnRegEmp.Name = "btnRegEmp";
            this.btnRegEmp.Size = new System.Drawing.Size(174, 35);
            this.btnRegEmp.TabIndex = 10;
            this.btnRegEmp.Text = "Registrar Empleados";
            this.btnRegEmp.UseVisualStyleBackColor = false;
            this.btnRegEmp.Click += new System.EventHandler(this.btnRegEmp_Click);
            // 
            // btnModifEmp
            // 
            this.btnModifEmp.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModifEmp.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifEmp.FlatAppearance.BorderSize = 0;
            this.btnModifEmp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModifEmp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnModifEmp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifEmp.Location = new System.Drawing.Point(0, 35);
            this.btnModifEmp.Name = "btnModifEmp";
            this.btnModifEmp.Size = new System.Drawing.Size(174, 35);
            this.btnModifEmp.TabIndex = 11;
            this.btnModifEmp.Text = "Modificar Empleados";
            this.btnModifEmp.UseVisualStyleBackColor = false;
            this.btnModifEmp.Click += new System.EventHandler(this.btnModifEmp_Click);
            // 
            // btnModifPyH
            // 
            this.btnModifPyH.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModifPyH.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifPyH.FlatAppearance.BorderSize = 0;
            this.btnModifPyH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModifPyH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnModifPyH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifPyH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifPyH.Location = new System.Drawing.Point(0, 70);
            this.btnModifPyH.Name = "btnModifPyH";
            this.btnModifPyH.Size = new System.Drawing.Size(174, 35);
            this.btnModifPyH.TabIndex = 12;
            this.btnModifPyH.Text = "Modificar Precios";
            this.btnModifPyH.UseVisualStyleBackColor = false;
            this.btnModifPyH.Click += new System.EventHandler(this.btnModifPyH_Click);
            // 
            // btnMenuGerente
            // 
            this.btnMenuGerente.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenuGerente.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuGerente.FlatAppearance.BorderSize = 0;
            this.btnMenuGerente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuGerente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuGerente.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuGerente.Image = global::Capa_Presentacion.Properties.Resources.gerente;
            this.btnMenuGerente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuGerente.Location = new System.Drawing.Point(0, 440);
            this.btnMenuGerente.Name = "btnMenuGerente";
            this.btnMenuGerente.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuGerente.Size = new System.Drawing.Size(174, 40);
            this.btnMenuGerente.TabIndex = 17;
            this.btnMenuGerente.Text = "   Gerencia";
            this.btnMenuGerente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuGerente.UseVisualStyleBackColor = false;
            this.btnMenuGerente.Click += new System.EventHandler(this.btnMenuGerente_Click);
            // 
            // pnSubMenuServicios
            // 
            this.pnSubMenuServicios.Controls.Add(this.btnModifServ);
            this.pnSubMenuServicios.Controls.Add(this.btnRegServ);
            this.pnSubMenuServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuServicios.Location = new System.Drawing.Point(0, 370);
            this.pnSubMenuServicios.Name = "pnSubMenuServicios";
            this.pnSubMenuServicios.Size = new System.Drawing.Size(174, 70);
            this.pnSubMenuServicios.TabIndex = 17;
            this.pnSubMenuServicios.Visible = false;
            // 
            // btnModifServ
            // 
            this.btnModifServ.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModifServ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifServ.FlatAppearance.BorderSize = 0;
            this.btnModifServ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModifServ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnModifServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifServ.Location = new System.Drawing.Point(0, 35);
            this.btnModifServ.Name = "btnModifServ";
            this.btnModifServ.Size = new System.Drawing.Size(174, 35);
            this.btnModifServ.TabIndex = 18;
            this.btnModifServ.Text = "Modificar Servicios";
            this.btnModifServ.UseVisualStyleBackColor = false;
            this.btnModifServ.Click += new System.EventHandler(this.btnModifServ_Click);
            // 
            // btnRegServ
            // 
            this.btnRegServ.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRegServ.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegServ.FlatAppearance.BorderSize = 0;
            this.btnRegServ.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegServ.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnRegServ.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegServ.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegServ.Location = new System.Drawing.Point(0, 0);
            this.btnRegServ.Name = "btnRegServ";
            this.btnRegServ.Size = new System.Drawing.Size(174, 35);
            this.btnRegServ.TabIndex = 17;
            this.btnRegServ.Text = "Registrar Servicios";
            this.btnRegServ.UseVisualStyleBackColor = false;
            this.btnRegServ.Click += new System.EventHandler(this.btnRegServ_Click);
            // 
            // btnMenuServicios
            // 
            this.btnMenuServicios.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenuServicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuServicios.FlatAppearance.BorderSize = 0;
            this.btnMenuServicios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuServicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuServicios.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuServicios.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuServicios.Image = global::Capa_Presentacion.Properties.Resources.servicios;
            this.btnMenuServicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuServicios.Location = new System.Drawing.Point(0, 330);
            this.btnMenuServicios.Name = "btnMenuServicios";
            this.btnMenuServicios.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuServicios.Size = new System.Drawing.Size(174, 40);
            this.btnMenuServicios.TabIndex = 17;
            this.btnMenuServicios.Text = "   Servicios";
            this.btnMenuServicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuServicios.UseVisualStyleBackColor = false;
            this.btnMenuServicios.Click += new System.EventHandler(this.btnMenuServicios_Click);
            // 
            // pnSubMenuReservas
            // 
            this.pnSubMenuReservas.Controls.Add(this.btnModifRes);
            this.pnSubMenuReservas.Controls.Add(this.btnIngRes);
            this.pnSubMenuReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuReservas.Location = new System.Drawing.Point(0, 260);
            this.pnSubMenuReservas.Name = "pnSubMenuReservas";
            this.pnSubMenuReservas.Size = new System.Drawing.Size(174, 70);
            this.pnSubMenuReservas.TabIndex = 17;
            this.pnSubMenuReservas.Visible = false;
            // 
            // btnModifRes
            // 
            this.btnModifRes.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModifRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnModifRes.FlatAppearance.BorderSize = 0;
            this.btnModifRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModifRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnModifRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifRes.Location = new System.Drawing.Point(0, 35);
            this.btnModifRes.Name = "btnModifRes";
            this.btnModifRes.Size = new System.Drawing.Size(174, 35);
            this.btnModifRes.TabIndex = 17;
            this.btnModifRes.Text = "Modificar Reservas";
            this.btnModifRes.UseVisualStyleBackColor = false;
            this.btnModifRes.Click += new System.EventHandler(this.btnModifRes_Click);
            // 
            // btnIngRes
            // 
            this.btnIngRes.BackColor = System.Drawing.Color.PowderBlue;
            this.btnIngRes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIngRes.FlatAppearance.BorderSize = 0;
            this.btnIngRes.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnIngRes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnIngRes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngRes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngRes.Location = new System.Drawing.Point(0, 0);
            this.btnIngRes.Name = "btnIngRes";
            this.btnIngRes.Size = new System.Drawing.Size(174, 35);
            this.btnIngRes.TabIndex = 8;
            this.btnIngRes.Text = "Ingresar Reservas";
            this.btnIngRes.UseVisualStyleBackColor = false;
            this.btnIngRes.Click += new System.EventHandler(this.btnIngRes_Click);
            // 
            // btnMenuReservas
            // 
            this.btnMenuReservas.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenuReservas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuReservas.FlatAppearance.BorderSize = 0;
            this.btnMenuReservas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuReservas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuReservas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuReservas.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuReservas.Image = global::Capa_Presentacion.Properties.Resources.reservas;
            this.btnMenuReservas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuReservas.Location = new System.Drawing.Point(0, 220);
            this.btnMenuReservas.Name = "btnMenuReservas";
            this.btnMenuReservas.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuReservas.Size = new System.Drawing.Size(174, 40);
            this.btnMenuReservas.TabIndex = 17;
            this.btnMenuReservas.Text = "   Reservas";
            this.btnMenuReservas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuReservas.UseVisualStyleBackColor = false;
            this.btnMenuReservas.Click += new System.EventHandler(this.btnMenuReservas_Click);
            // 
            // pnSubMenuClientes
            // 
            this.pnSubMenuClientes.Controls.Add(this.btnRegCli);
            this.pnSubMenuClientes.Controls.Add(this.btnModifCli);
            this.pnSubMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuClientes.Location = new System.Drawing.Point(0, 150);
            this.pnSubMenuClientes.Name = "pnSubMenuClientes";
            this.pnSubMenuClientes.Size = new System.Drawing.Size(174, 70);
            this.pnSubMenuClientes.TabIndex = 15;
            this.pnSubMenuClientes.Visible = false;
            // 
            // btnRegCli
            // 
            this.btnRegCli.BackColor = System.Drawing.Color.PowderBlue;
            this.btnRegCli.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRegCli.FlatAppearance.BorderSize = 0;
            this.btnRegCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRegCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnRegCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegCli.Location = new System.Drawing.Point(0, 0);
            this.btnRegCli.Name = "btnRegCli";
            this.btnRegCli.Size = new System.Drawing.Size(174, 35);
            this.btnRegCli.TabIndex = 6;
            this.btnRegCli.Text = "Registrar Clientes";
            this.btnRegCli.UseVisualStyleBackColor = false;
            this.btnRegCli.Click += new System.EventHandler(this.btnRegCli_Click);
            // 
            // btnModifCli
            // 
            this.btnModifCli.BackColor = System.Drawing.Color.PowderBlue;
            this.btnModifCli.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnModifCli.FlatAppearance.BorderSize = 0;
            this.btnModifCli.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnModifCli.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnModifCli.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModifCli.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModifCli.Location = new System.Drawing.Point(0, 35);
            this.btnModifCli.Name = "btnModifCli";
            this.btnModifCli.Size = new System.Drawing.Size(174, 35);
            this.btnModifCli.TabIndex = 7;
            this.btnModifCli.Text = "Modificar Clientes";
            this.btnModifCli.UseVisualStyleBackColor = false;
            this.btnModifCli.Click += new System.EventHandler(this.btnModifCli_Click);
            // 
            // btnMenuClientes
            // 
            this.btnMenuClientes.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuClientes.FlatAppearance.BorderSize = 0;
            this.btnMenuClientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuClientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuClientes.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuClientes.Image = global::Capa_Presentacion.Properties.Resources.clientes;
            this.btnMenuClientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuClientes.Location = new System.Drawing.Point(0, 110);
            this.btnMenuClientes.Name = "btnMenuClientes";
            this.btnMenuClientes.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuClientes.Size = new System.Drawing.Size(174, 40);
            this.btnMenuClientes.TabIndex = 14;
            this.btnMenuClientes.Text = "   Clientes";
            this.btnMenuClientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuClientes.UseVisualStyleBackColor = false;
            this.btnMenuClientes.Click += new System.EventHandler(this.btnMenuClientes_Click);
            // 
            // pnSubMenuInfo
            // 
            this.pnSubMenuInfo.Controls.Add(this.btnInfoPyH);
            this.pnSubMenuInfo.Controls.Add(this.btnConsultas);
            this.pnSubMenuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnSubMenuInfo.Location = new System.Drawing.Point(0, 40);
            this.pnSubMenuInfo.Name = "pnSubMenuInfo";
            this.pnSubMenuInfo.Size = new System.Drawing.Size(174, 70);
            this.pnSubMenuInfo.TabIndex = 13;
            this.pnSubMenuInfo.Visible = false;
            // 
            // btnInfoPyH
            // 
            this.btnInfoPyH.BackColor = System.Drawing.Color.PowderBlue;
            this.btnInfoPyH.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnInfoPyH.Enabled = false;
            this.btnInfoPyH.FlatAppearance.BorderSize = 0;
            this.btnInfoPyH.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnInfoPyH.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnInfoPyH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInfoPyH.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInfoPyH.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnInfoPyH.Location = new System.Drawing.Point(0, 35);
            this.btnInfoPyH.Name = "btnInfoPyH";
            this.btnInfoPyH.Size = new System.Drawing.Size(174, 35);
            this.btnInfoPyH.TabIndex = 4;
            this.btnInfoPyH.Text = "Precios y Horarios";
            this.btnInfoPyH.UseVisualStyleBackColor = false;
            this.btnInfoPyH.Click += new System.EventHandler(this.btnInfoPyH_Click);
            // 
            // btnConsultas
            // 
            this.btnConsultas.BackColor = System.Drawing.Color.PowderBlue;
            this.btnConsultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsultas.Enabled = false;
            this.btnConsultas.FlatAppearance.BorderSize = 0;
            this.btnConsultas.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnConsultas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SkyBlue;
            this.btnConsultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsultas.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsultas.Location = new System.Drawing.Point(0, 0);
            this.btnConsultas.Margin = new System.Windows.Forms.Padding(10);
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(174, 35);
            this.btnConsultas.TabIndex = 5;
            this.btnConsultas.Text = "Consultas";
            this.btnConsultas.UseVisualStyleBackColor = false;
            this.btnConsultas.Click += new System.EventHandler(this.btnInfoRes_Click);
            // 
            // btnMenuInfo
            // 
            this.btnMenuInfo.BackColor = System.Drawing.Color.SteelBlue;
            this.btnMenuInfo.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnMenuInfo.FlatAppearance.BorderSize = 0;
            this.btnMenuInfo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.CornflowerBlue;
            this.btnMenuInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMenuInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenuInfo.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnMenuInfo.Image = global::Capa_Presentacion.Properties.Resources.informacion;
            this.btnMenuInfo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMenuInfo.Location = new System.Drawing.Point(0, 0);
            this.btnMenuInfo.Name = "btnMenuInfo";
            this.btnMenuInfo.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.btnMenuInfo.Size = new System.Drawing.Size(174, 40);
            this.btnMenuInfo.TabIndex = 6;
            this.btnMenuInfo.Text = "   información";
            this.btnMenuInfo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMenuInfo.UseVisualStyleBackColor = false;
            this.btnMenuInfo.Click += new System.EventHandler(this.btnMenuInfo_Click);
            // 
            // pnBarra
            // 
            this.pnBarra.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnBarra.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBarra.Controls.Add(this.btnCerrarSesion);
            this.pnBarra.Controls.Add(this.lblUsuario);
            this.pnBarra.Controls.Add(this.picUsuario);
            this.pnBarra.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnBarra.Location = new System.Drawing.Point(0, 0);
            this.pnBarra.Name = "pnBarra";
            this.pnBarra.Size = new System.Drawing.Size(1205, 40);
            this.pnBarra.TabIndex = 0;
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCerrarSesion.FlatAppearance.BorderSize = 0;
            this.btnCerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarSesion.Image = global::Capa_Presentacion.Properties.Resources.salida_de_emergencia;
            this.btnCerrarSesion.Location = new System.Drawing.Point(1166, 4);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(32, 28);
            this.btnCerrarSesion.TabIndex = 2;
            this.btnCerrarSesion.UseVisualStyleBackColor = true;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(1061, 11);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(97, 15);
            this.lblUsuario.TabIndex = 1;
            this.lblUsuario.Text = "Administrativo";
            // 
            // picUsuario
            // 
            this.picUsuario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picUsuario.Image = global::Capa_Presentacion.Properties.Resources.usuario;
            this.picUsuario.Location = new System.Drawing.Point(1032, 7);
            this.picUsuario.Name = "picUsuario";
            this.picUsuario.Size = new System.Drawing.Size(24, 24);
            this.picUsuario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picUsuario.TabIndex = 0;
            this.picUsuario.TabStop = false;
            // 
            // pnMenuSize
            // 
            this.pnMenuSize.BackColor = System.Drawing.Color.SteelBlue;
            this.pnMenuSize.Controls.Add(this.btnMinimizarMenu);
            this.pnMenuSize.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnMenuSize.Location = new System.Drawing.Point(174, 40);
            this.pnMenuSize.Name = "pnMenuSize";
            this.pnMenuSize.Size = new System.Drawing.Size(30, 605);
            this.pnMenuSize.TabIndex = 3;
            // 
            // btnMinimizarMenu
            // 
            this.btnMinimizarMenu.FlatAppearance.BorderSize = 0;
            this.btnMinimizarMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimizarMenu.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimizarMenu.Image")));
            this.btnMinimizarMenu.Location = new System.Drawing.Point(1, 5);
            this.btnMinimizarMenu.Name = "btnMinimizarMenu";
            this.btnMinimizarMenu.Size = new System.Drawing.Size(30, 30);
            this.btnMinimizarMenu.TabIndex = 0;
            this.btnMinimizarMenu.UseVisualStyleBackColor = true;
            this.btnMinimizarMenu.Click += new System.EventHandler(this.btnMinimizarMenu_Click);
            // 
            // pnBordeMenu
            // 
            this.pnBordeMenu.BackColor = System.Drawing.Color.SteelBlue;
            this.pnBordeMenu.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnBordeMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnBordeMenu.Location = new System.Drawing.Point(204, 40);
            this.pnBordeMenu.Name = "pnBordeMenu";
            this.pnBordeMenu.Size = new System.Drawing.Size(1, 605);
            this.pnBordeMenu.TabIndex = 4;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.ClientSize = new System.Drawing.Size(1205, 645);
            this.Controls.Add(this.pnForms);
            this.Controls.Add(this.pnBordeMenu);
            this.Controls.Add(this.pnMenuSize);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnBarra);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MinimumSize = new System.Drawing.Size(1000, 300);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onsen Spa Termal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPrincipal_FormClosing);
            this.pnForms.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.pnMenu.ResumeLayout(false);
            this.pnSubMenuGerente.ResumeLayout(false);
            this.pnSubMenuServicios.ResumeLayout(false);
            this.pnSubMenuReservas.ResumeLayout(false);
            this.pnSubMenuClientes.ResumeLayout(false);
            this.pnSubMenuInfo.ResumeLayout(false);
            this.pnBarra.ResumeLayout(false);
            this.pnBarra.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picUsuario)).EndInit();
            this.pnMenuSize.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnForms;
        private System.Windows.Forms.Button btnInfoPyH;
        private System.Windows.Forms.Button btnIngRes;
        private System.Windows.Forms.Button btnModifEmp;
        private System.Windows.Forms.Button btnConsultas;
        private System.Windows.Forms.Button btnRegEmp;
        private System.Windows.Forms.Button btnRegCli;
        private System.Windows.Forms.Button btnModifCli;
        private System.Windows.Forms.Button btnModifPyH;
        private System.Windows.Forms.Panel pnBarra;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnMenuInfo;
        private System.Windows.Forms.Panel pnSubMenuInfo;
        private System.Windows.Forms.Panel pnSubMenuClientes;
        private System.Windows.Forms.Button btnMenuClientes;
        private System.Windows.Forms.Panel pnSubMenuReservas;
        private System.Windows.Forms.Button btnModifRes;
        private System.Windows.Forms.Button btnMenuReservas;
        private System.Windows.Forms.Button btnModifServ;
        private System.Windows.Forms.Panel pnSubMenuServicios;
        private System.Windows.Forms.Button btnRegServ;
        private System.Windows.Forms.Button btnMenuServicios;
        private System.Windows.Forms.Panel pnSubMenuGerente;
        private System.Windows.Forms.Button btnMenuGerente;
        private System.Windows.Forms.PictureBox picUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pnMenuSize;
        private System.Windows.Forms.Button btnMinimizarMenu;
        private System.Windows.Forms.Panel pnBordeMenu;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}