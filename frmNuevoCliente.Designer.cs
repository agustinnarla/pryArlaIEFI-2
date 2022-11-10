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
            this.lstBarrios = new System.Windows.Forms.ComboBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblSaldo = new System.Windows.Forms.Label();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblDni = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblApellido = new System.Windows.Forms.Label();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lstActividades = new System.Windows.Forms.ComboBox();
            this.cmdAgregarBarrio = new System.Windows.Forms.Button();
            this.cmdAgregarActividad = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcDatosClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.SuspendLayout();
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcDatosClientes.Controls.Add(this.cmdAgregarActividad);
            this.mrcDatosClientes.Controls.Add(this.cmdAgregarBarrio);
            this.mrcDatosClientes.Controls.Add(this.lblApellido);
            this.mrcDatosClientes.Controls.Add(this.txtApellido);
            this.mrcDatosClientes.Controls.Add(this.textBox3);
            this.mrcDatosClientes.Controls.Add(this.textBox2);
            this.mrcDatosClientes.Controls.Add(this.textBox1);
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
            this.mrcDatosClientes.Location = new System.Drawing.Point(178, 17);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Size = new System.Drawing.Size(610, 231);
            this.mrcDatosClientes.TabIndex = 5;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Datos del cliente";
            // 
            // lstBarrios
            // 
            this.lstBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrios.FormattingEnabled = true;
            this.lstBarrios.Location = new System.Drawing.Point(443, 65);
            this.lstBarrios.Name = "lstBarrios";
            this.lstBarrios.Size = new System.Drawing.Size(123, 21);
            this.lstBarrios.TabIndex = 7;
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Location = new System.Drawing.Point(443, 33);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(123, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtCorreo.Location = new System.Drawing.Point(156, 164);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(145, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Location = new System.Drawing.Point(156, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(24, 132);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(24, 164);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(96, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(331, 130);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(37, 13);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(331, 70);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(37, 13);
            this.lblBarrio.TabIndex = 3;
            this.lblBarrio.Text = "Barrio:";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(331, 40);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(55, 13);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(24, 36);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(24, 100);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Location = new System.Drawing.Point(156, 101);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox2.Location = new System.Drawing.Point(156, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox3.Location = new System.Drawing.Point(443, 131);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(90, 20);
            this.textBox3.TabIndex = 9;
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Location = new System.Drawing.Point(156, 66);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(24, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(9, 82);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(163, 161);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 6;
            this.pickFoto.TabStop = false;
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(331, 100);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Actividad:";
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(443, 98);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(123, 21);
            this.lstActividades.TabIndex = 8;
            // 
            // cmdAgregarBarrio
            // 
            this.cmdAgregarBarrio.Location = new System.Drawing.Point(572, 63);
            this.cmdAgregarBarrio.Name = "cmdAgregarBarrio";
            this.cmdAgregarBarrio.Size = new System.Drawing.Size(25, 23);
            this.cmdAgregarBarrio.TabIndex = 21;
            this.cmdAgregarBarrio.Text = "+";
            this.cmdAgregarBarrio.UseVisualStyleBackColor = true;
            this.cmdAgregarBarrio.Click += new System.EventHandler(this.cmdAgregarBarrio_Click);
            // 
            // cmdAgregarActividad
            // 
            this.cmdAgregarActividad.Location = new System.Drawing.Point(572, 96);
            this.cmdAgregarActividad.Name = "cmdAgregarActividad";
            this.cmdAgregarActividad.Size = new System.Drawing.Size(25, 23);
            this.cmdAgregarActividad.TabIndex = 22;
            this.cmdAgregarActividad.Text = "+";
            this.cmdAgregarActividad.UseVisualStyleBackColor = true;
            this.cmdAgregarActividad.Click += new System.EventHandler(this.cmdAgregarActividad_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(604, 254);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(84, 30);
            this.cmdVolver.TabIndex = 17;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(707, 254);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(81, 30);
            this.cmdCargar.TabIndex = 16;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // frmNuevoCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 331);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.mrcDatosClientes);
            this.Name = "frmNuevoCliente";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Nuevo Cliente";
            this.mrcDatosClientes.ResumeLayout(false);
            this.mrcDatosClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
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
    }
}