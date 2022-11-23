namespace pryArlaIEFI_2
{
    partial class frmEliminarBarrio
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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblCodigo_Barrio = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(227, 138);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(88, 21);
            this.cmdVolver.TabIndex = 15;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.cmdConsultar);
            this.mrcDatos.Controls.Add(this.lstBarrio);
            this.mrcDatos.Controls.Add(this.lblCodigo_Barrio);
            this.mrcDatos.Controls.Add(this.lblBarrio);
            this.mrcDatos.Location = new System.Drawing.Point(14, 11);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(396, 122);
            this.mrcDatos.TabIndex = 13;
            this.mrcDatos.TabStop = false;
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
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(164, 18);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(216, 20);
            this.lstBarrio.TabIndex = 9;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged_1);
            // 
            // lblCodigo_Barrio
            // 
            this.lblCodigo_Barrio.AutoSize = true;
            this.lblCodigo_Barrio.Location = new System.Drawing.Point(21, 80);
            this.lblCodigo_Barrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo_Barrio.Name = "lblCodigo_Barrio";
            this.lblCodigo_Barrio.Size = new System.Drawing.Size(96, 12);
            this.lblCodigo_Barrio.TabIndex = 2;
            this.lblCodigo_Barrio.Text = "Codigo Barrio";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(21, 20);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 12);
            this.lblBarrio.TabIndex = 8;
            this.lblBarrio.Text = "Barrio";
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(322, 138);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(88, 21);
            this.cmdEliminar.TabIndex = 14;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(261, 80);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(12, 12);
            this.lblCodigo.TabIndex = 14;
            this.lblCodigo.Text = "-";
            // 
            // frmEliminarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(433, 181);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdEliminar);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEliminarBarrio";
            this.ShowIcon = false;
            this.Text = "Eliminar Barrio";
            this.Load += new System.EventHandler(this.frmEliminarBarrio_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblCodigo_Barrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.Label lblCodigo;
    }
}