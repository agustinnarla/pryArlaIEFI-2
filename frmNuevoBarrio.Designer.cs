namespace pryArlaIEFI_2
{
    partial class frmNuevoBarrio
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
            this.lblNombreBarrio = new System.Windows.Forms.Label();
            this.txtNombreBarrio = new System.Windows.Forms.TextBox();
            this.mrcNuevoBarrio = new System.Windows.Forms.GroupBox();
            this.cmdSalir = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcNuevoBarrio.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombreBarrio
            // 
            this.lblNombreBarrio.AutoSize = true;
            this.lblNombreBarrio.Location = new System.Drawing.Point(15, 33);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(91, 13);
            this.lblNombreBarrio.TabIndex = 0;
            this.lblNombreBarrio.Text = "Nombre del Barrio";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Location = new System.Drawing.Point(110, 30);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(175, 20);
            this.txtNombreBarrio.TabIndex = 1;
            // 
            // mrcNuevoBarrio
            // 
            this.mrcNuevoBarrio.Controls.Add(this.lblNombreBarrio);
            this.mrcNuevoBarrio.Controls.Add(this.txtNombreBarrio);
            this.mrcNuevoBarrio.Location = new System.Drawing.Point(12, 12);
            this.mrcNuevoBarrio.Name = "mrcNuevoBarrio";
            this.mrcNuevoBarrio.Size = new System.Drawing.Size(304, 74);
            this.mrcNuevoBarrio.TabIndex = 2;
            this.mrcNuevoBarrio.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(113, 92);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(84, 30);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(216, 92);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(81, 30);
            this.cmdCargar.TabIndex = 16;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // frmNuevoBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 138);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.mrcNuevoBarrio);
            this.Name = "frmNuevoBarrio";
            this.ShowIcon = false;
            this.Text = "Nuevo Barrio";
            this.mrcNuevoBarrio.ResumeLayout(false);
            this.mrcNuevoBarrio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNombreBarrio;
        private System.Windows.Forms.TextBox txtNombreBarrio;
        private System.Windows.Forms.GroupBox mrcNuevoBarrio;
        private System.Windows.Forms.Button cmdSalir;
        private System.Windows.Forms.Button cmdCargar;
    }
}