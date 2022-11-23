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
            this.lblNombreBarrio.Location = new System.Drawing.Point(18, 30);
            this.lblNombreBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreBarrio.Name = "lblNombreBarrio";
            this.lblNombreBarrio.Size = new System.Drawing.Size(124, 12);
            this.lblNombreBarrio.TabIndex = 0;
            this.lblNombreBarrio.Text = "Nombre del Barrio";
            // 
            // txtNombreBarrio
            // 
            this.txtNombreBarrio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtNombreBarrio.Location = new System.Drawing.Point(143, 27);
            this.txtNombreBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreBarrio.Name = "txtNombreBarrio";
            this.txtNombreBarrio.Size = new System.Drawing.Size(204, 20);
            this.txtNombreBarrio.TabIndex = 1;
            this.txtNombreBarrio.TextChanged += new System.EventHandler(this.txtNombreBarrio_TextChanged);
            // 
            // mrcNuevoBarrio
            // 
            this.mrcNuevoBarrio.Controls.Add(this.lblNombreBarrio);
            this.mrcNuevoBarrio.Controls.Add(this.txtNombreBarrio);
            this.mrcNuevoBarrio.Location = new System.Drawing.Point(14, 11);
            this.mrcNuevoBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcNuevoBarrio.Name = "mrcNuevoBarrio";
            this.mrcNuevoBarrio.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcNuevoBarrio.Size = new System.Drawing.Size(355, 68);
            this.mrcNuevoBarrio.TabIndex = 2;
            this.mrcNuevoBarrio.TabStop = false;
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(154, 85);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(98, 28);
            this.cmdSalir.TabIndex = 17;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Location = new System.Drawing.Point(274, 85);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(94, 28);
            this.cmdCargar.TabIndex = 16;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmNuevoBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(390, 127);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.mrcNuevoBarrio);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNuevoBarrio";
            this.ShowIcon = false;
            this.Text = "Nuevo Barrio";
            this.Load += new System.EventHandler(this.frmNuevoBarrio_Load);
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