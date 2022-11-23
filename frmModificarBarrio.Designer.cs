namespace pryArlaIEFI_2
{
    partial class frmModificarBarrio
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
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.txtBarrio = new System.Windows.Forms.TextBox();
            this.lblCodigo_Barrio = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(312, 49);
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
            this.cmdVolver.Location = new System.Drawing.Point(178, 191);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(88, 21);
            this.cmdVolver.TabIndex = 12;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(178, 18);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(220, 20);
            this.lstBarrio.TabIndex = 9;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.lblCodigo);
            this.mrcDatos.Controls.Add(this.txtBarrio);
            this.mrcDatos.Controls.Add(this.lblCodigo_Barrio);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Location = new System.Drawing.Point(14, 76);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(396, 110);
            this.mrcDatos.TabIndex = 10;
            this.mrcDatos.TabStop = false;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lblCodigo.Location = new System.Drawing.Point(258, 30);
            this.lblCodigo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(12, 12);
            this.lblCodigo.TabIndex = 5;
            this.lblCodigo.Text = "-";
            // 
            // txtBarrio
            // 
            this.txtBarrio.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtBarrio.Enabled = false;
            this.txtBarrio.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtBarrio.Location = new System.Drawing.Point(164, 51);
            this.txtBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBarrio.Name = "txtBarrio";
            this.txtBarrio.Size = new System.Drawing.Size(220, 20);
            this.txtBarrio.TabIndex = 3;
            this.txtBarrio.TextChanged += new System.EventHandler(this.txtBarrio_TextChanged);
            // 
            // lblCodigo_Barrio
            // 
            this.lblCodigo_Barrio.AutoSize = true;
            this.lblCodigo_Barrio.Location = new System.Drawing.Point(21, 30);
            this.lblCodigo_Barrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodigo_Barrio.Name = "lblCodigo_Barrio";
            this.lblCodigo_Barrio.Size = new System.Drawing.Size(96, 12);
            this.lblCodigo_Barrio.TabIndex = 2;
            this.lblCodigo_Barrio.Text = "Codigo Barrio";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 54);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(124, 12);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre del Barrio";
            // 
            // cmdModificar
            // 
            this.cmdModificar.Enabled = false;
            this.cmdModificar.Location = new System.Drawing.Point(312, 191);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(88, 21);
            this.cmdModificar.TabIndex = 11;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(35, 21);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 12);
            this.lblBarrio.TabIndex = 8;
            this.lblBarrio.Text = "Barrio";
            // 
            // frmModificarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(428, 241);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lstBarrio);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.lblBarrio);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmModificarBarrio";
            this.ShowIcon = false;
            this.Text = "Modificar Barrio";
            this.Load += new System.EventHandler(this.frmModificarBarrio_Load);
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtBarrio;
        private System.Windows.Forms.Label lblCodigo_Barrio;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Label lblBarrio;
    }
}