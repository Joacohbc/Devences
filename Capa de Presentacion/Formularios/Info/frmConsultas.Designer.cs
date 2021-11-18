﻿namespace Capa_Presentacion.Formularios
{
    partial class frmInfoReservas
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new System.Windows.Forms.Button();
            this.cmbTipoConsulta = new System.Windows.Forms.ComboBox();
            this.lblTipoConsulta = new System.Windows.Forms.Label();
            this.lblBusqueda = new System.Windows.Forms.Label();
            this.cmbClave = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtBusqueda = new System.Windows.Forms.TextBox();
            this.btnBusqueda = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.panel1.TabIndex = 128;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Consultas";
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
            // cmbTipoConsulta
            // 
            this.cmbTipoConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoConsulta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbTipoConsulta.FormattingEnabled = true;
            this.cmbTipoConsulta.Location = new System.Drawing.Point(184, 72);
            this.cmbTipoConsulta.Name = "cmbTipoConsulta";
            this.cmbTipoConsulta.Size = new System.Drawing.Size(177, 24);
            this.cmbTipoConsulta.TabIndex = 129;
            // 
            // lblTipoConsulta
            // 
            this.lblTipoConsulta.AutoSize = true;
            this.lblTipoConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoConsulta.Location = new System.Drawing.Point(31, 74);
            this.lblTipoConsulta.Name = "lblTipoConsulta";
            this.lblTipoConsulta.Size = new System.Drawing.Size(147, 22);
            this.lblTipoConsulta.TabIndex = 131;
            this.lblTipoConsulta.Text = "Tipo de Consulta";
            // 
            // lblBusqueda
            // 
            this.lblBusqueda.AutoSize = true;
            this.lblBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBusqueda.Location = new System.Drawing.Point(406, 74);
            this.lblBusqueda.Name = "lblBusqueda";
            this.lblBusqueda.Size = new System.Drawing.Size(102, 22);
            this.lblBusqueda.TabIndex = 132;
            this.lblBusqueda.Text = "Buscar por:";
            // 
            // cmbClave
            // 
            this.cmbClave.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbClave.Enabled = false;
            this.cmbClave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbClave.FormattingEnabled = true;
            this.cmbClave.Location = new System.Drawing.Point(514, 72);
            this.cmbClave.Name = "cmbClave";
            this.cmbClave.Size = new System.Drawing.Size(110, 24);
            this.cmbClave.TabIndex = 133;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(654, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 134;
            this.label2.Text = "Ingrese:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(14, 127);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(972, 385);
            this.dataGridView1.TabIndex = 130;
            // 
            // txtBusqueda
            // 
            this.txtBusqueda.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBusqueda.Location = new System.Drawing.Point(734, 77);
            this.txtBusqueda.Name = "txtBusqueda";
            this.txtBusqueda.Size = new System.Drawing.Size(138, 19);
            this.txtBusqueda.TabIndex = 135;
            // 
            // btnBusqueda
            // 
            this.btnBusqueda.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnBusqueda.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnBusqueda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBusqueda.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBusqueda.Location = new System.Drawing.Point(889, 70);
            this.btnBusqueda.Name = "btnBusqueda";
            this.btnBusqueda.Size = new System.Drawing.Size(92, 36);
            this.btnBusqueda.TabIndex = 136;
            this.btnBusqueda.Text = "Buscar";
            this.btnBusqueda.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.SteelBlue;
            this.btnActualizar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightSteelBlue;
            this.btnActualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Location = new System.Drawing.Point(14, 522);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(972, 40);
            this.btnActualizar.TabIndex = 137;
            this.btnActualizar.Text = "Actualizar Todo";
            this.btnActualizar.UseVisualStyleBackColor = true;
            // 
            // frmInfoReservas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(1000, 605);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnBusqueda);
            this.Controls.Add(this.txtBusqueda);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cmbClave);
            this.Controls.Add(this.lblBusqueda);
            this.Controls.Add(this.lblTipoConsulta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.cmbTipoConsulta);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmInfoReservas";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.ComboBox cmbTipoConsulta;
        private System.Windows.Forms.Label lblTipoConsulta;
        private System.Windows.Forms.Label lblBusqueda;
        private System.Windows.Forms.ComboBox cmbClave;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtBusqueda;
        private System.Windows.Forms.Button btnBusqueda;
        private System.Windows.Forms.Button btnActualizar;
    }
}