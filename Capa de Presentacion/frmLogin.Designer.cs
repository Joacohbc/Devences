namespace Capa_Presentacion
{
    partial class frmLogin
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
            this.pnLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.txtContra = new System.Windows.Forms.TextBox();
            this.btnIngreso = new System.Windows.Forms.Button();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.chkMostrarContra = new System.Windows.Forms.CheckBox();
            this.lblUnder1 = new System.Windows.Forms.Label();
            this.lblUnder2 = new System.Windows.Forms.Label();
            this.pnLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnLogo
            // 
            this.pnLogo.BackColor = System.Drawing.Color.SkyBlue;
            this.pnLogo.Controls.Add(this.pictureBox1);
            this.pnLogo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnLogo.Location = new System.Drawing.Point(0, 0);
            this.pnLogo.Name = "pnLogo";
            this.pnLogo.Size = new System.Drawing.Size(200, 301);
            this.pnLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Capa_Presentacion.Properties.Resources.logoBlanco;
            this.pictureBox1.Location = new System.Drawing.Point(0, 65);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(219, 190);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Control;
            this.txtUsuario.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.Color.SkyBlue;
            this.txtUsuario.Location = new System.Drawing.Point(290, 96);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(5);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(324, 22);
            this.txtUsuario.TabIndex = 1;
            this.txtUsuario.Text = "Usuario";
            this.txtUsuario.Enter += new System.EventHandler(this.txtUsuario_Enter);
            this.txtUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUsuario_KeyPress);
            this.txtUsuario.Leave += new System.EventHandler(this.txtUsuario_Leave);
            // 
            // txtContra
            // 
            this.txtContra.BackColor = System.Drawing.SystemColors.Control;
            this.txtContra.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContra.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContra.ForeColor = System.Drawing.Color.LightSkyBlue;
            this.txtContra.Location = new System.Drawing.Point(290, 148);
            this.txtContra.Name = "txtContra";
            this.txtContra.Size = new System.Drawing.Size(324, 22);
            this.txtContra.TabIndex = 2;
            this.txtContra.Text = "Contraseña";
            this.txtContra.Enter += new System.EventHandler(this.txtContra_Enter);
            this.txtContra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtContra_KeyPress);
            this.txtContra.Leave += new System.EventHandler(this.txtContra_Leave);
            // 
            // btnIngreso
            // 
            this.btnIngreso.BackColor = System.Drawing.SystemColors.Control;
            this.btnIngreso.FlatAppearance.BorderSize = 2;
            this.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngreso.ForeColor = System.Drawing.Color.SkyBlue;
            this.btnIngreso.Location = new System.Drawing.Point(290, 220);
            this.btnIngreso.Name = "btnIngreso";
            this.btnIngreso.Size = new System.Drawing.Size(324, 36);
            this.btnIngreso.TabIndex = 0;
            this.btnIngreso.Text = "INGRESAR";
            this.btnIngreso.UseVisualStyleBackColor = false;
            this.btnIngreso.Click += new System.EventHandler(this.btnIngreso_Click);
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblTitulo.Location = new System.Drawing.Point(400, 15);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(87, 29);
            this.lblTitulo.TabIndex = 4;
            this.lblTitulo.Text = "LOGIN";
            // 
            // chkMostrarContra
            // 
            this.chkMostrarContra.Appearance = System.Windows.Forms.Appearance.Button;
            this.chkMostrarContra.BackColor = System.Drawing.Color.Transparent;
            this.chkMostrarContra.Checked = true;
            this.chkMostrarContra.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkMostrarContra.FlatAppearance.BorderSize = 0;
            this.chkMostrarContra.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent;
            this.chkMostrarContra.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.chkMostrarContra.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.chkMostrarContra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.chkMostrarContra.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chkMostrarContra.Image = global::Capa_Presentacion.Properties.Resources.ojo;
            this.chkMostrarContra.Location = new System.Drawing.Point(624, 141);
            this.chkMostrarContra.Name = "chkMostrarContra";
            this.chkMostrarContra.Size = new System.Drawing.Size(32, 32);
            this.chkMostrarContra.TabIndex = 5;
            this.chkMostrarContra.UseVisualStyleBackColor = false;
            this.chkMostrarContra.Visible = false;
            this.chkMostrarContra.CheckedChanged += new System.EventHandler(this.chkMostrarContra_CheckedChanged);
            // 
            // lblUnder1
            // 
            this.lblUnder1.AutoSize = true;
            this.lblUnder1.BackColor = System.Drawing.Color.Transparent;
            this.lblUnder1.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblUnder1.Location = new System.Drawing.Point(287, 107);
            this.lblUnder1.Name = "lblUnder1";
            this.lblUnder1.Size = new System.Drawing.Size(331, 13);
            this.lblUnder1.TabIndex = 6;
            this.lblUnder1.Text = "______________________________________________________";
            // 
            // lblUnder2
            // 
            this.lblUnder2.AutoSize = true;
            this.lblUnder2.BackColor = System.Drawing.Color.Transparent;
            this.lblUnder2.ForeColor = System.Drawing.Color.SkyBlue;
            this.lblUnder2.Location = new System.Drawing.Point(287, 159);
            this.lblUnder2.Name = "lblUnder2";
            this.lblUnder2.Size = new System.Drawing.Size(331, 13);
            this.lblUnder2.TabIndex = 7;
            this.lblUnder2.Text = "______________________________________________________";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(734, 301);
            this.Controls.Add(this.txtContra);
            this.Controls.Add(this.lblUnder2);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.lblUnder1);
            this.Controls.Add(this.chkMostrarContra);
            this.Controls.Add(this.lblTitulo);
            this.Controls.Add(this.btnIngreso);
            this.Controls.Add(this.pnLogo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "frmLogin";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Onsen Spa Termal";
            this.pnLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnLogo;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.TextBox txtContra;
        private System.Windows.Forms.Button btnIngreso;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.CheckBox chkMostrarContra;
        private System.Windows.Forms.Label lblUnder1;
        private System.Windows.Forms.Label lblUnder2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

