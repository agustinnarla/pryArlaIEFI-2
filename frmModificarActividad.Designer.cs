namespace pryArlaIEFI_2
{
    partial class frmModificarActividad
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
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo_Actividad = new System.Windows.Forms.Label();
            this.txtActividad = new System.Windows.Forms.TextBox();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            this.lstProfesor = new System.Windows.Forms.ComboBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(39, 26);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(68, 12);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 48);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(159, 12);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre de la Actividad";
            // 
            // lblCodigo_Actividad
            // 
            this.lblCodigo_Actividad.AutoSize = true;
            this.lblCodigo_Actividad.Location = new System.Drawing.Point(21, 25);
            this.lblCodigo_Actividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo_Actividad.Name = "lblCodigo_Actividad";
            this.lblCodigo_Actividad.Size = new System.Drawing.Size(117, 12);
            this.lblCodigo_Actividad.TabIndex = 2;
            this.lblCodigo_Actividad.Text = "Codigo Actividad";
            // 
            // txtActividad
            // 
            this.txtActividad.Enabled = false;
            this.txtActividad.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtActividad.Location = new System.Drawing.Point(198, 45);
            this.txtActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtActividad.Name = "txtActividad";
            this.txtActividad.Size = new System.Drawing.Size(220, 20);
            this.txtActividad.TabIndex = 3;
            this.txtActividad.TextChanged += new System.EventHandler(this.txtActividad_TextChanged);
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(182, 23);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(216, 20);
            this.lstActividad.TabIndex = 4;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblProfesor);
            this.mrcDatos.Controls.Add(this.lstProfesor);
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.txtActividad);
            this.mrcDatos.Controls.Add(this.lblCodigo_Actividad);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Location = new System.Drawing.Point(20, 67);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(432, 110);
            this.mrcDatos.TabIndex = 5;
            this.mrcDatos.TabStop = false;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(21, 72);
            this.lblProfesor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(61, 12);
            this.lblProfesor.TabIndex = 9;
            this.lblProfesor.Text = "Profesor";
            // 
            // lstProfesor
            // 
            this.lstProfesor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstProfesor.Enabled = false;
            this.lstProfesor.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstProfesor.FormattingEnabled = true;
            this.lstProfesor.Location = new System.Drawing.Point(198, 69);
            this.lstProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstProfesor.Name = "lstProfesor";
            this.lstProfesor.Size = new System.Drawing.Size(220, 20);
            this.lstProfesor.TabIndex = 8;
            this.lstProfesor.SelectedIndexChanged += new System.EventHandler(this.lstProfesor_SelectedIndexChanged);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(258, 25);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(12, 12);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "-";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(350, 183);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(88, 21);
            this.cmdModificar.TabIndex = 5;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(240, 183);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(88, 21);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(350, 49);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(88, 21);
            this.cmdConsultar.TabIndex = 7;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmModificarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(466, 256);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.lblActividad);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmModificarActividad";
            this.ShowIcon = false;
            this.Text = "Modificar Actividad";
            this.Load += new System.EventHandler(this.frmModificarActividad_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo_Actividad;
        private System.Windows.Forms.TextBox txtActividad;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblProfesor;
        private System.Windows.Forms.ComboBox lstProfesor;
    }
}