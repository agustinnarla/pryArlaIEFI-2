namespace pryArlaIEFI_2
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
            this.cmdCliente = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdActividad = new System.Windows.Forms.Button();
            this.cmdCaja = new System.Windows.Forms.Button();
            this.cmdAcceso = new System.Windows.Forms.Button();
            this.cmdBarrio = new System.Windows.Forms.Button();
            this.mrcLinea2 = new System.Windows.Forms.GroupBox();
            this.mrcLinea1 = new System.Windows.Forms.GroupBox();
            this.SuspendLayout();
            // 
            // cmdCliente
            // 
            this.cmdCliente.Location = new System.Drawing.Point(12, 38);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(141, 23);
            this.cmdCliente.TabIndex = 0;
            this.cmdCliente.Text = "Clientes";
            this.cmdCliente.UseVisualStyleBackColor = true;
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(12, 78);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(141, 23);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            // 
            // cmdActividad
            // 
            this.cmdActividad.Location = new System.Drawing.Point(12, 119);
            this.cmdActividad.Name = "cmdActividad";
            this.cmdActividad.Size = new System.Drawing.Size(141, 23);
            this.cmdActividad.TabIndex = 2;
            this.cmdActividad.Text = "Actividad";
            this.cmdActividad.UseVisualStyleBackColor = true;
            // 
            // cmdCaja
            // 
            this.cmdCaja.Location = new System.Drawing.Point(12, 163);
            this.cmdCaja.Name = "cmdCaja";
            this.cmdCaja.Size = new System.Drawing.Size(141, 23);
            this.cmdCaja.TabIndex = 3;
            this.cmdCaja.Text = "Caja";
            this.cmdCaja.UseVisualStyleBackColor = true;
            // 
            // cmdAcceso
            // 
            this.cmdAcceso.Location = new System.Drawing.Point(12, 201);
            this.cmdAcceso.Name = "cmdAcceso";
            this.cmdAcceso.Size = new System.Drawing.Size(141, 23);
            this.cmdAcceso.TabIndex = 4;
            this.cmdAcceso.Text = "Acceso";
            this.cmdAcceso.UseVisualStyleBackColor = true;
            // 
            // cmdBarrio
            // 
            this.cmdBarrio.Location = new System.Drawing.Point(12, 240);
            this.cmdBarrio.Name = "cmdBarrio";
            this.cmdBarrio.Size = new System.Drawing.Size(141, 23);
            this.cmdBarrio.TabIndex = 5;
            this.cmdBarrio.Text = "Barrio";
            this.cmdBarrio.UseVisualStyleBackColor = true;
            // 
            // mrcLinea2
            // 
            this.mrcLinea2.Location = new System.Drawing.Point(12, 307);
            this.mrcLinea2.Name = "mrcLinea2";
            this.mrcLinea2.Size = new System.Drawing.Size(172, 18);
            this.mrcLinea2.TabIndex = 6;
            this.mrcLinea2.TabStop = false;
            // 
            // mrcLinea1
            // 
            this.mrcLinea1.Location = new System.Drawing.Point(174, -1);
            this.mrcLinea1.Name = "mrcLinea1";
            this.mrcLinea1.Size = new System.Drawing.Size(10, 302);
            this.mrcLinea1.TabIndex = 7;
            this.mrcLinea1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 497);
            this.Controls.Add(this.mrcLinea1);
            this.Controls.Add(this.mrcLinea2);
            this.Controls.Add(this.cmdBarrio);
            this.Controls.Add(this.cmdAcceso);
            this.Controls.Add(this.cmdCaja);
            this.Controls.Add(this.cmdActividad);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdCliente);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCliente;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdActividad;
        private System.Windows.Forms.Button cmdCaja;
        private System.Windows.Forms.Button cmdAcceso;
        private System.Windows.Forms.Button cmdBarrio;
        private System.Windows.Forms.GroupBox mrcLinea2;
        private System.Windows.Forms.GroupBox mrcLinea1;
    }
}