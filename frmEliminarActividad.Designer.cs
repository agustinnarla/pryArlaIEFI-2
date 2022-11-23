namespace pryArlaIEFI_2
{
    partial class frmEliminarActividad
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
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.lblCodigo_Actividad = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(294, 42);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(88, 21);
            this.cmdConsultar.TabIndex = 13;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(236, 140);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(88, 21);
            this.cmdVolver.TabIndex = 12;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // lstActividad
            // 
            this.lstActividad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(164, 18);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(216, 20);
            this.lstActividad.TabIndex = 9;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.cmdConsultar);
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.lstActividad);
            this.mrcDatos.Controls.Add(this.lblCodigo_Actividad);
            this.mrcDatos.Controls.Add(this.lblActividad);
            this.mrcDatos.Location = new System.Drawing.Point(22, 13);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(396, 122);
            this.mrcDatos.TabIndex = 10;
            this.mrcDatos.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(258, 80);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(12, 12);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "-";
            // 
            // lblCodigo_Actividad
            // 
            this.lblCodigo_Actividad.AutoSize = true;
            this.lblCodigo_Actividad.Location = new System.Drawing.Point(21, 80);
            this.lblCodigo_Actividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo_Actividad.Name = "lblCodigo_Actividad";
            this.lblCodigo_Actividad.Size = new System.Drawing.Size(117, 12);
            this.lblCodigo_Actividad.TabIndex = 2;
            this.lblCodigo_Actividad.Text = "Codigo Actividad";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(21, 20);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(68, 12);
            this.lblActividad.TabIndex = 8;
            this.lblActividad.Text = "Actividad";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(330, 140);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(88, 21);
            this.cmdEliminar.TabIndex = 11;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // frmEliminarActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(458, 174);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdEliminar);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEliminarActividad";
            this.ShowIcon = false;
            this.Text = "Eliminar Actividad";
            this.Load += new System.EventHandler(this.frmEliminarActividad_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.Label lblCodigo_Actividad;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Button cmdEliminar;
    }
}