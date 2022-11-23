namespace pryArlaIEFI_2
{
    partial class frmNuevoCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoCliente));
            this.mrcDatosClientes = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.lstSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.cmdAgregarActividad = new System.Windows.Forms.Button();
            this.cmdAgregarBarrio = new System.Windows.Forms.Button();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lstActividades = new System.Windows.Forms.ComboBox();
            this.lstBarrios = new System.Windows.Forms.ComboBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcDatosClientes.Controls.Add(this.txtDias);
            this.mrcDatosClientes.Controls.Add(this.lblDias);
            this.mrcDatosClientes.Controls.Add(this.lstSexo);
            this.mrcDatosClientes.Controls.Add(this.lblSexo);
            this.mrcDatosClientes.Controls.Add(this.cmdAgregarActividad);
            this.mrcDatosClientes.Controls.Add(this.cmdAgregarBarrio);
            this.mrcDatosClientes.Controls.Add(this.lblApellido);
            this.mrcDatosClientes.Controls.Add(this.txtApellido);
            this.mrcDatosClientes.Controls.Add(this.txtSaldo);
            this.mrcDatosClientes.Controls.Add(this.txtTelefono);
            this.mrcDatosClientes.Controls.Add(this.txtDni);
            this.mrcDatosClientes.Controls.Add(this.lstActividades);
            this.mrcDatosClientes.Controls.Add(this.lstBarrios);
            this.mrcDatosClientes.Controls.Add(this.lblDireccion);
            this.mrcDatosClientes.Controls.Add(this.txtDireccion);
            this.mrcDatosClientes.Controls.Add(this.lblBarrio);
            this.mrcDatosClientes.Controls.Add(this.txtCorreo);
            this.mrcDatosClientes.Controls.Add(this.txtNombre);
            this.mrcDatosClientes.Controls.Add(this.lblTelefono);
            this.mrcDatosClientes.Controls.Add(this.lblSaldo);
            this.mrcDatosClientes.Controls.Add(this.lblCorreo);
            this.mrcDatosClientes.Controls.Add(this.lblActividad);
            this.mrcDatosClientes.Controls.Add(this.lblNombre);
            this.mrcDatosClientes.Controls.Add(this.lblDni);
            this.mrcDatosClientes.Location = new System.Drawing.Point(208, 16);
            this.mrcDatosClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatosClientes.Size = new System.Drawing.Size(712, 246);
            this.mrcDatosClientes.TabIndex = 5;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Datos del cliente";
            // 
            // txtDias
            // 
            this.txtDias.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtDias.Location = new System.Drawing.Point(182, 174);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDias.MaxLength = 1;
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(62, 20);
            this.txtDias.TabIndex = 28;
            this.txtDias.TextChanged += new System.EventHandler(this.txtDias_TextChanged);
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(29, 181);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(33, 12);
            this.lblDias.TabIndex = 25;
            this.lblDias.Text = "Dias";
            // 
            // lstSexo
            // 
            this.lstSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSexo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.lstSexo.Location = new System.Drawing.Point(517, 147);
            this.lstSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(62, 20);
            this.lstSexo.TabIndex = 24;
            this.lstSexo.SelectedIndexChanged += new System.EventHandler(this.lstSexo_SelectedIndexChanged_1);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(386, 148);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 12);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo:";
            // 
            // cmdAgregarActividad
            // 
            this.cmdAgregarActividad.Location = new System.Drawing.Point(667, 89);
            this.cmdAgregarActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAgregarActividad.Name = "cmdAgregarActividad";
            this.cmdAgregarActividad.Size = new System.Drawing.Size(29, 21);
            this.cmdAgregarActividad.TabIndex = 22;
            this.cmdAgregarActividad.Text = "+";
            this.cmdAgregarActividad.UseVisualStyleBackColor = true;
            this.cmdAgregarActividad.Click += new System.EventHandler(this.cmdAgregarActividad_Click);
            // 
            // cmdAgregarBarrio
            // 
            this.cmdAgregarBarrio.Location = new System.Drawing.Point(667, 58);
            this.cmdAgregarBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAgregarBarrio.Name = "cmdAgregarBarrio";
            this.cmdAgregarBarrio.Size = new System.Drawing.Size(29, 21);
            this.cmdAgregarBarrio.TabIndex = 21;
            this.cmdAgregarBarrio.Text = "+";
            this.cmdAgregarBarrio.UseVisualStyleBackColor = true;
            this.cmdAgregarBarrio.Click += new System.EventHandler(this.cmdAgregarBarrio_Click);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(28, 63);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 12);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtApellido.Location = new System.Drawing.Point(182, 59);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtSaldo
            // 
            this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtSaldo.Location = new System.Drawing.Point(517, 118);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldo.MaxLength = 4;
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(104, 20);
            this.txtSaldo.TabIndex = 9;
            this.txtSaldo.TextChanged += new System.EventHandler(this.txtSaldo_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtTelefono.Location = new System.Drawing.Point(182, 116);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtDni.Location = new System.Drawing.Point(182, 88);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(116, 20);
            this.txtDni.TabIndex = 3;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(517, 89);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(143, 20);
            this.lstActividades.TabIndex = 8;
            this.lstActividades.SelectedIndexChanged += new System.EventHandler(this.lstActividades_SelectedIndexChanged_1);
            // 
            // lstBarrios
            // 
            this.lstBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrios.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstBarrios.FormattingEnabled = true;
            this.lstBarrios.Location = new System.Drawing.Point(517, 59);
            this.lstBarrios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBarrios.Name = "lstBarrios";
            this.lstBarrios.Size = new System.Drawing.Size(143, 20);
            this.lstBarrios.TabIndex = 7;
            this.lstBarrios.SelectedIndexChanged += new System.EventHandler(this.lstBarrios_SelectedIndexChanged);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(386, 37);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 12);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtDireccion.Location = new System.Drawing.Point(517, 30);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(143, 20);
            this.txtDireccion.TabIndex = 6;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(386, 65);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(54, 12);
            this.lblBarrio.TabIndex = 3;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtCorreo.Location = new System.Drawing.Point(182, 145);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(168, 20);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged_1);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtNombre.Location = new System.Drawing.Point(182, 30);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(28, 122);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 12);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(386, 120);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 12);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(28, 151);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(138, 12);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(386, 92);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(75, 12);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(28, 33);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 12);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(28, 92);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 12);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(10, 113);
            this.pickFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(190, 149);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 6;
            this.pickFoto.TabStop = false;
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(720, 268);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(98, 28);
            this.cmdVolver.TabIndex = 17;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Enabled = false;
            this.cmdCargar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdCargar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdCargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.cmdCargar.Location = new System.Drawing.Point(825, 268);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(94, 28);
            this.cmdCargar.TabIndex = 16;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click);
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 306);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.mrcDatosClientes);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNuevoCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nuevo Cliente";
            this.Load += new System.EventHandler(this.frmNuevoCliente_Load);
            this.mrcDatosClientes.ResumeLayout(false);
            this.mrcDatosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox lstBarrios;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.PictureBox pickFoto;
        private System.Windows.Forms.ComboBox lstActividades;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Button cmdAgregarActividad;
        private System.Windows.Forms.Button cmdAgregarBarrio;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.ComboBox lstSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
    }
}