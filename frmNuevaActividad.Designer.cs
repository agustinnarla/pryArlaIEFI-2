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
            this.lstProfesor = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lblNombreActividad = new System.Windows.Forms.Label();
            this.txtNombreActividad = new System.Windows.Forms.TextBox();
            this.mrcNuevaActividad.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdSalir
            // 
            this.cmdSalir.Location = new System.Drawing.Point(201, 123);
            this.cmdSalir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdSalir.Name = "cmdSalir";
            this.cmdSalir.Size = new System.Drawing.Size(98, 28);
            this.cmdSalir.TabIndex = 20;
            this.cmdSalir.Text = "Salir";
            this.cmdSalir.UseVisualStyleBackColor = true;
            this.cmdSalir.Click += new System.EventHandler(this.cmdSalir_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Location = new System.Drawing.Point(321, 123);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(94, 28);
            this.cmdCargar.TabIndex = 19;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // mrcNuevaActividad
            // 
            this.mrcNuevaActividad.Controls.Add(this.lstProfesor);
            this.mrcNuevaActividad.Controls.Add(this.lblProfesor);
            this.mrcNuevaActividad.Controls.Add(this.lblNombreActividad);
            this.mrcNuevaActividad.Controls.Add(this.txtNombreActividad);
            this.mrcNuevaActividad.Location = new System.Drawing.Point(14, 11);
            this.mrcNuevaActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcNuevaActividad.Name = "mrcNuevaActividad";
            this.mrcNuevaActividad.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcNuevaActividad.Size = new System.Drawing.Size(401, 106);
            this.mrcNuevaActividad.TabIndex = 18;
            this.mrcNuevaActividad.TabStop = false;
            // 
            // lstProfesor
            // 
            this.lstProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProfesor.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstProfesor.FormattingEnabled = true;
            this.lstProfesor.Location = new System.Drawing.Point(187, 67);
            this.lstProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstProfesor.Name = "lstProfesor";
            this.lstProfesor.Size = new System.Drawing.Size(204, 20);
            this.lstProfesor.TabIndex = 3;
            this.lstProfesor.SelectedIndexChanged += new System.EventHandler(this.lstProfesor_SelectedIndexChanged);
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(18, 67);
            this.lblProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(61, 12);
            this.lblProfesor.TabIndex = 2;
            this.lblProfesor.Text = "Profesor";
            // 
            // lblNombreActividad
            // 
            this.lblNombreActividad.AutoSize = true;
            this.lblNombreActividad.Location = new System.Drawing.Point(18, 30);
            this.lblNombreActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreActividad.Name = "lblNombreActividad";
            this.lblNombreActividad.Size = new System.Drawing.Size(159, 12);
            this.lblNombreActividad.TabIndex = 0;
            this.lblNombreActividad.Text = "Nombre de la Actividad";
            // 
            // txtNombreActividad
            // 
            this.txtNombreActividad.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombreActividad.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtNombreActividad.Location = new System.Drawing.Point(188, 28);
            this.txtNombreActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombreActividad.Name = "txtNombreActividad";
            this.txtNombreActividad.Size = new System.Drawing.Size(204, 20);
            this.txtNombreActividad.TabIndex = 1;
            this.txtNombreActividad.TextChanged += new System.EventHandler(this.txtNombreActividad_TextChanged);
            // 
            // frmNuevaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(429, 156);
            this.Controls.Add(this.cmdSalir);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.mrcNuevaActividad);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNuevaActividad";
            this.ShowIcon = false;
            this.Text = "Nueva Actividad";
            this.Load += new System.EventHandler(this.frmNuevaActividad_Load);
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
        private System.Windows.Forms.ComboBox lstProfesor;
        private System.Windows.Forms.Label lblProfesor;
    }
}