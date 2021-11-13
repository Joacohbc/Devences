namespace Capa_Presentacion.Formularios
{
    partial class frmPreciosYHorarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPreciosYHorarios));
            this.lblPrecios = new System.Windows.Forms.Label();
            this.lblHorarios = new System.Windows.Forms.Label();
            this.pnTitulo = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.lblIngNormal = new System.Windows.Forms.Label();
            this.lblIngAlojados = new System.Windows.Forms.Label();
            this.lblIngJub = new System.Windows.Forms.Label();
            this.txtIngJub = new System.Windows.Forms.TextBox();
            this.txtIngAlojados = new System.Windows.Forms.TextBox();
            this.txtIngNormal = new System.Windows.Forms.TextBox();
            this.lblSpa = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEntrada = new System.Windows.Forms.TextBox();
            this.txtSalida = new System.Windows.Forms.TextBox();
            this.txtEntradaVest = new System.Windows.Forms.TextBox();
            this.txtSalidaVest = new System.Windows.Forms.TextBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.pnTitulo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblPrecios
            // 
            this.lblPrecios.AutoSize = true;
            this.lblPrecios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecios.Location = new System.Drawing.Point(35, 107);
            this.lblPrecios.Name = "lblPrecios";
            this.lblPrecios.Size = new System.Drawing.Size(85, 26);
            this.lblPrecios.TabIndex = 2;
            this.lblPrecios.Text = "Precios";
            // 
            // lblHorarios
            // 
            this.lblHorarios.AutoSize = true;
            this.lblHorarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHorarios.Location = new System.Drawing.Point(477, 107);
            this.lblHorarios.Name = "lblHorarios";
            this.lblHorarios.Size = new System.Drawing.Size(94, 26);
            this.lblHorarios.TabIndex = 3;
            this.lblHorarios.Text = "Horarios";
            // 
            // pnTitulo
            // 
            this.pnTitulo.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnTitulo.Controls.Add(this.lblTitulo);
            this.pnTitulo.Controls.Add(this.btnSalir);
            this.pnTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTitulo.Location = new System.Drawing.Point(0, 0);
            this.pnTitulo.Name = "pnTitulo";
            this.pnTitulo.Size = new System.Drawing.Size(1000, 47);
            this.pnTitulo.TabIndex = 83;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(12, 14);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(154, 20);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Precios y Horarios";
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
            // lblIngNormal
            // 
            this.lblIngNormal.AutoSize = true;
            this.lblIngNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngNormal.Location = new System.Drawing.Point(63, 198);
            this.lblIngNormal.Name = "lblIngNormal";
            this.lblIngNormal.Size = new System.Drawing.Size(131, 22);
            this.lblIngNormal.TabIndex = 84;
            this.lblIngNormal.Text = "Ingreso Normal";
            // 
            // lblIngAlojados
            // 
            this.lblIngAlojados.AutoSize = true;
            this.lblIngAlojados.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngAlojados.Location = new System.Drawing.Point(63, 301);
            this.lblIngAlojados.Name = "lblIngAlojados";
            this.lblIngAlojados.Size = new System.Drawing.Size(168, 22);
            this.lblIngAlojados.TabIndex = 85;
            this.lblIngAlojados.Text = "Ingreso de Alojados";
            // 
            // lblIngJub
            // 
            this.lblIngJub.AutoSize = true;
            this.lblIngJub.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIngJub.Location = new System.Drawing.Point(63, 408);
            this.lblIngJub.Name = "lblIngJub";
            this.lblIngJub.Size = new System.Drawing.Size(296, 22);
            this.lblIngJub.TabIndex = 86;
            this.lblIngJub.Text = "Ingreso de Jubilados y Pensionistas";
            // 
            // txtIngJub
            // 
            this.txtIngJub.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngJub.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngJub.Location = new System.Drawing.Point(67, 434);
            this.txtIngJub.Name = "txtIngJub";
            this.txtIngJub.Size = new System.Drawing.Size(53, 19);
            this.txtIngJub.TabIndex = 87;
            this.txtIngJub.TabStop = false;
            // 
            // txtIngAlojados
            // 
            this.txtIngAlojados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngAlojados.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngAlojados.Location = new System.Drawing.Point(67, 327);
            this.txtIngAlojados.Name = "txtIngAlojados";
            this.txtIngAlojados.Size = new System.Drawing.Size(53, 19);
            this.txtIngAlojados.TabIndex = 88;
            this.txtIngAlojados.TabStop = false;
            // 
            // txtIngNormal
            // 
            this.txtIngNormal.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtIngNormal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIngNormal.Location = new System.Drawing.Point(67, 224);
            this.txtIngNormal.Name = "txtIngNormal";
            this.txtIngNormal.Size = new System.Drawing.Size(53, 19);
            this.txtIngNormal.TabIndex = 89;
            this.txtIngNormal.TabStop = false;
            // 
            // lblSpa
            // 
            this.lblSpa.AutoSize = true;
            this.lblSpa.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSpa.Location = new System.Drawing.Point(524, 194);
            this.lblSpa.Name = "lblSpa";
            this.lblSpa.Size = new System.Drawing.Size(47, 24);
            this.lblSpa.TabIndex = 90;
            this.lblSpa.Text = "SPA";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(524, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 24);
            this.label1.TabIndex = 91;
            this.label1.Text = "Vestuarios";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(595, 256);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 22);
            this.label2.TabIndex = 92;
            this.label2.Text = "Entrada";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(790, 256);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 22);
            this.label3.TabIndex = 93;
            this.label3.Text = "Salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(595, 446);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 22);
            this.label4.TabIndex = 94;
            this.label4.Text = "Entrada";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(790, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 22);
            this.label5.TabIndex = 95;
            this.label5.Text = "Salida";
            // 
            // txtEntrada
            // 
            this.txtEntrada.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntrada.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntrada.Location = new System.Drawing.Point(599, 281);
            this.txtEntrada.Name = "txtEntrada";
            this.txtEntrada.Size = new System.Drawing.Size(53, 19);
            this.txtEntrada.TabIndex = 96;
            this.txtEntrada.TabStop = false;
            // 
            // txtSalida
            // 
            this.txtSalida.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalida.Location = new System.Drawing.Point(794, 281);
            this.txtSalida.Name = "txtSalida";
            this.txtSalida.Size = new System.Drawing.Size(53, 19);
            this.txtSalida.TabIndex = 97;
            this.txtSalida.TabStop = false;
            // 
            // txtEntradaVest
            // 
            this.txtEntradaVest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEntradaVest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEntradaVest.Location = new System.Drawing.Point(599, 471);
            this.txtEntradaVest.Name = "txtEntradaVest";
            this.txtEntradaVest.Size = new System.Drawing.Size(53, 19);
            this.txtEntradaVest.TabIndex = 98;
            this.txtEntradaVest.TabStop = false;
            // 
            // txtSalidaVest
            // 
            this.txtSalidaVest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSalidaVest.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSalidaVest.Location = new System.Drawing.Point(794, 471);
            this.txtSalidaVest.Name = "txtSalidaVest";
            this.txtSalidaVest.Size = new System.Drawing.Size(53, 19);
            this.txtSalidaVest.TabIndex = 99;
            this.txtSalidaVest.TabStop = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.FlatAppearance.BorderSize = 0;
            this.btnRefresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnRefresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnRefresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRefresh.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(956, 53);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(32, 32);
            this.btnRefresh.TabIndex = 100;
            this.btnRefresh.TabStop = false;
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // frmPreciosYHorarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.txtSalidaVest);
            this.Controls.Add(this.txtEntradaVest);
            this.Controls.Add(this.txtSalida);
            this.Controls.Add(this.txtEntrada);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSpa);
            this.Controls.Add(this.txtIngNormal);
            this.Controls.Add(this.txtIngAlojados);
            this.Controls.Add(this.txtIngJub);
            this.Controls.Add(this.lblIngJub);
            this.Controls.Add(this.lblIngAlojados);
            this.Controls.Add(this.lblIngNormal);
            this.Controls.Add(this.pnTitulo);
            this.Controls.Add(this.lblHorarios);
            this.Controls.Add(this.lblPrecios);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmPreciosYHorarios";
            this.Text = "frmPreciosYHorarios";
            this.pnTitulo.ResumeLayout(false);
            this.pnTitulo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblPrecios;
        private System.Windows.Forms.Label lblHorarios;
        private System.Windows.Forms.Panel pnTitulo;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label lblIngNormal;
        private System.Windows.Forms.Label lblIngAlojados;
        private System.Windows.Forms.Label lblIngJub;
        private System.Windows.Forms.TextBox txtIngJub;
        private System.Windows.Forms.TextBox txtIngAlojados;
        private System.Windows.Forms.TextBox txtIngNormal;
        private System.Windows.Forms.Label lblSpa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEntrada;
        private System.Windows.Forms.TextBox txtSalida;
        private System.Windows.Forms.TextBox txtEntradaVest;
        private System.Windows.Forms.TextBox txtSalidaVest;
        private System.Windows.Forms.Button btnRefresh;
    }
}