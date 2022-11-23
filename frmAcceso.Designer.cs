namespace pryArlaIEFI_2
{
    partial class frmAcceso
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAcceso));
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(31, 15);
            this.pickFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(190, 143);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 28;
            this.pickFoto.TabStop = false;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(255, 58);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 12);
            this.lblApellido.TabIndex = 34;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(406, 52);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 32;
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(444, 30);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(116, 20);
            this.txtDni.TabIndex = 33;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Location = new System.Drawing.Point(406, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 30;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(255, 31);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 12);
            this.lblNombre.TabIndex = 31;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(294, 32);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 12);
            this.lblDni.TabIndex = 29;
            this.lblDni.Text = "DNI:";
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(257, 105);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(33, 12);
            this.lblDias.TabIndex = 35;
            this.lblDias.Text = "Dias";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Enabled = false;
            this.txtDetalle.Location = new System.Drawing.Point(260, 139);
            this.txtDetalle.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(384, 20);
            this.txtDetalle.TabIndex = 39;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Controls.Add(this.txtDias);
            this.mrcDatos.Controls.Add(this.txtSaldo);
            this.mrcDatos.Controls.Add(this.lblSaldo);
            this.mrcDatos.Controls.Add(this.txtDetalle);
            this.mrcDatos.Controls.Add(this.lblDias);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Controls.Add(this.pickFoto);
            this.mrcDatos.Location = new System.Drawing.Point(38, 64);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(672, 183);
            this.mrcDatos.TabIndex = 40;
            this.mrcDatos.TabStop = false;
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Location = new System.Drawing.Point(406, 105);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(116, 20);
            this.txtDias.TabIndex = 43;
            // 
            // txtSaldo
            // 
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Location = new System.Drawing.Point(406, 76);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(116, 20);
            this.txtSaldo.TabIndex = 41;
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(257, 82);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(40, 12);
            this.lblSaldo.TabIndex = 40;
            this.lblSaldo.Text = "Saldo";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(611, 32);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(99, 29);
            this.cmdConsultar.TabIndex = 41;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(611, 252);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(99, 29);
            this.cmdVolver.TabIndex = 42;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 293);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.txtDni);
            this.Controls.Add(this.lblDni);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmAcceso";
            this.Text = "Acceso";
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pickFoto;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Label lblDias;
        private System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.TextBox txtDias;
    }
}