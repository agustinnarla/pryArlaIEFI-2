namespace pryArlaIEFI_2
{
    partial class frmNuevaActividad
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
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcNuevaActividad = new System.Windows.Forms.GroupBox();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.mrcNuevaActividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(141, 92);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(84, 30);
            this.cmdSalir.TabIndex = 20;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(244, 92);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(81, 30);
            this.cmdCargar.TabIndex = 19;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // mrcNuevaActividad
            // 
            this.mrcNuevaActividad.Controls.Add(this.lblNombreActividad);
            this.mrcNuevaActividad.Controls.Add(this.txtNombreActividad);
            this.mrcNuevaActividad.Location = new System.Drawing.Point(12, 12);
            this.mrcNuevaActividad.Name = "mrcNuevaActividad";
            this.mrcNuevaActividad.Size = new System.Drawing.Size(344, 74);
            this.mrcNuevaActividad.TabIndex = 18;
            this.mrcNuevaActividad.TabStop = false;
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(15, 33);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(117, 13);
            this.lblNombreActividad.TabIndex = 0;
            this.lblNombreActividad.Text = "Nombre de la Actividad";
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.Location = new System.Drawing.Point(138, 30);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(175, 20);
            this.txtNombreActividad.TabIndex = 1;
            // 
            // frmNuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 138);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.mrcNuevaActividad);
            this.Name = "frmNuevaActividad";
            this.ShowIcon = false;
            this.Text = "Nueva Actividad";
            this.mrcNuevaActividad.ResumeLayout(false);
            this.mrcNuevaActividad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.GroupBox mrcNuevaActividad;
        private System.Windows.Forms.Label lblNombreActividad;
        private System.Windows.Forms.TextBox txtNombreActividad;
    }
}