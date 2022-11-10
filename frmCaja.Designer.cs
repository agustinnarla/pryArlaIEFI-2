namespace pryArlaIEFI_2
{
    partial class frmCaja
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
            this.lblDni = new System.Windows.Forms.Label();
            this.lblNombreApellido = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblActiviadad = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.dtpCalendario = new System.Windows.Forms.DateTimePicker();
            this.lblFechaCuota = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombreApellido = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lstDias = new System.Windows.Forms.ComboBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(108, 12);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(23, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "Dni";
            // 
            // lblNombreApellido
            // 
            this.lblNombreApellido.AutoSize = true;
            this.lblNombreApellido.Location = new System.Drawing.Point(62, 34);
            this.lblNombreApellido.Name = "lblNombreApellido";
            this.lblNombreApellido.Size = new System.Drawing.Size(92, 13);
            this.lblNombreApellido.TabIndex = 1;
            this.lblNombreApellido.Text = "Nombre y Apellido";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(62, 63);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(34, 13);
            this.lblSaldo.TabIndex = 2;
            this.lblSaldo.Text = "Saldo";
            // 
            // lblActiviadad
            // 
            this.lblActiviadad.AutoSize = true;
            this.lblActiviadad.Location = new System.Drawing.Point(62, 92);
            this.lblActiviadad.Name = "lblActiviadad";
            this.lblActiviadad.Size = new System.Drawing.Size(51, 13);
            this.lblActiviadad.TabIndex = 3;
            this.lblActiviadad.Text = "Actividad";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(62, 121);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(28, 13);
            this.lblDias.TabIndex = 4;
            this.lblDias.Text = "Dias";
            // 
            // dtpCalendario
            // 
            this.dtpCalendario.Location = new System.Drawing.Point(175, 150);
            this.dtpCalendario.Name = "dtpCalendario";
            this.dtpCalendario.Size = new System.Drawing.Size(200, 20);
            this.dtpCalendario.TabIndex = 5;
            // 
            // lblFechaCuota
            // 
            this.lblFechaCuota.AutoSize = true;
            this.lblFechaCuota.Location = new System.Drawing.Point(62, 150);
            this.lblFechaCuota.Name = "lblFechaCuota";
            this.lblFechaCuota.Size = new System.Drawing.Size(88, 13);
            this.lblFechaCuota.TabIndex = 6;
            this.lblFechaCuota.Text = "Inicio de la cuota";
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(221, 12);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(100, 20);
            this.txtDni.TabIndex = 7;
            // 
            // txtNombreApellido
            // 
            this.txtNombreApellido.Enabled = false;
            this.txtNombreApellido.Location = new System.Drawing.Point(175, 32);
            this.txtNombreApellido.Name = "txtNombreApellido";
            this.txtNombreApellido.Size = new System.Drawing.Size(100, 20);
            this.txtNombreApellido.TabIndex = 8;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(175, 61);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(100, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // lstDias
            // 
            this.lstDias.FormattingEnabled = true;
            this.lstDias.Location = new System.Drawing.Point(175, 120);
            this.lstDias.Name = "lstDias";
            this.lstDias.Size = new System.Drawing.Size(200, 21);
            this.lstDias.TabIndex = 11;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtActividad);
            this.mrcDatos.Controls.Add(this.lstDias);
            this.mrcDatos.Controls.Add(this.txtSaldo);
            this.mrcDatos.Controls.Add(this.txtNombreApellido);
            this.mrcDatos.Controls.Add(this.lblFechaCuota);
            this.mrcDatos.Controls.Add(this.dtpCalendario);
            this.mrcDatos.Controls.Add(this.lblDias);
            this.mrcDatos.Controls.Add(this.lblActiviadad);
            this.mrcDatos.Controls.Add(this.lblSaldo);
            this.mrcDatos.Controls.Add(this.lblNombreApellido);
            this.mrcDatos.Location = new System.Drawing.Point(46, 61);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(389, 209);
            this.mrcDatos.TabIndex = 12;
            this.mrcDatos.TabStop = false;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(340, 276);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(81, 30);
            this.cmdCargar.TabIndex = 13;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // txtActividad
            // 
            this.txtActividad.Enabled = false;
            this.txtActividad.Location = new System.Drawing.Point(175, 89);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(100, 20);
            this.txtActividad.TabIndex = 12;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(340, 25);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(81, 30);
            this.cmdConsultar.TabIndex = 14;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(237, 276);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(84, 30);
            this.cmdSalir.TabIndex = 15;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            // 
            // frmCaja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(452, 321);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Name = "frmCaja";
            this.ShowIcon = false;
            this.Text = "Caja";
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblNombreApellido;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblActiviadad;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.DateTimePicker dtpCalendario;
        private System.Windows.Forms.Label lblFechaCuota;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombreApellido;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.ComboBox lstDias;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdSalir;
    }
}