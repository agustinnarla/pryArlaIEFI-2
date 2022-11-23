namespace pryArlaIEFI_2
{
    partial class frmEliminarCliente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarCliente));
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.mrcDatosClientes = new System.Windows.Forms.GroupBox();
            this.txtDias = new System.Windows.Forms.TextBox();
            this.lblDias = new System.Windows.Forms.Label();
            this.txtSexo = new System.Windows.Forms.TextBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtSaldo = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
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
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.mrcDatosClientes.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(705, 231);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(98, 28);
            this.cmdVolver.TabIndex = 21;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Enabled = false;
            this.cmdEliminar.Location = new System.Drawing.Point(825, 231);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(94, 28);
            this.cmdEliminar.TabIndex = 20;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(9, 77);
            this.pickFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(190, 149);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 19;
            this.pickFoto.TabStop = false;
            // 
            // mrcDatosClientes
            // 
            this.mrcDatosClientes.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcDatosClientes.Controls.Add(this.txtDias);
            this.mrcDatosClientes.Controls.Add(this.lblDias);
            this.mrcDatosClientes.Controls.Add(this.txtSexo);
            this.mrcDatosClientes.Controls.Add(this.lblSexo);
            this.mrcDatosClientes.Controls.Add(this.lblApellido);
            this.mrcDatosClientes.Controls.Add(this.txtApellido);
            this.mrcDatosClientes.Controls.Add(this.txtSaldo);
            this.mrcDatosClientes.Controls.Add(this.txtTelefono);
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
            this.mrcDatosClientes.Location = new System.Drawing.Point(208, 19);
            this.mrcDatosClientes.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatosClientes.Name = "mrcDatosClientes";
            this.mrcDatosClientes.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatosClientes.Size = new System.Drawing.Size(712, 206);
            this.mrcDatosClientes.TabIndex = 18;
            this.mrcDatosClientes.TabStop = false;
            this.mrcDatosClientes.Text = "Datos del cliente";
            // 
            // txtDias
            // 
            this.txtDias.Enabled = false;
            this.txtDias.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtDias.Location = new System.Drawing.Point(175, 142);
            this.txtDias.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDias.Name = "txtDias";
            this.txtDias.Size = new System.Drawing.Size(116, 20);
            this.txtDias.TabIndex = 32;
            // 
            // lblDias
            // 
            this.lblDias.AutoSize = true;
            this.lblDias.Location = new System.Drawing.Point(34, 144);
            this.lblDias.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDias.Name = "lblDias";
            this.lblDias.Size = new System.Drawing.Size(40, 12);
            this.lblDias.TabIndex = 29;
            this.lblDias.Text = "Dias:";
            // 
            // txtSexo
            // 
            this.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtSexo.Location = new System.Drawing.Point(509, 138);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(52, 20);
            this.txtSexo.TabIndex = 24;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(387, 144);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 12);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(34, 56);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 12);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtApellido.Location = new System.Drawing.Point(175, 54);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtSaldo
            // 
            this.txtSaldo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSaldo.Enabled = false;
            this.txtSaldo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtSaldo.Location = new System.Drawing.Point(509, 110);
            this.txtSaldo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSaldo.Name = "txtSaldo";
            this.txtSaldo.Size = new System.Drawing.Size(104, 20);
            this.txtSaldo.TabIndex = 9;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtTelefono.Location = new System.Drawing.Point(175, 83);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.Enabled = false;
            this.lstActividades.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(509, 81);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(170, 20);
            this.lstActividades.TabIndex = 8;
            // 
            // lstBarrios
            // 
            this.lstBarrios.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrios.Enabled = false;
            this.lstBarrios.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstBarrios.FormattingEnabled = true;
            this.lstBarrios.Location = new System.Drawing.Point(509, 53);
            this.lstBarrios.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBarrios.Name = "lstBarrios";
            this.lstBarrios.Size = new System.Drawing.Size(170, 20);
            this.lstBarrios.TabIndex = 7;
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(386, 30);
            this.lblDireccion.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(75, 12);
            this.lblDireccion.TabIndex = 2;
            this.lblDireccion.Text = "Direccion:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDireccion.Enabled = false;
            this.txtDireccion.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtDireccion.Location = new System.Drawing.Point(509, 24);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(143, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(387, 58);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(54, 12);
            this.lblBarrio.TabIndex = 3;
            this.lblBarrio.Text = "Barrio:";
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtCorreo.Location = new System.Drawing.Point(175, 113);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(168, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtNombre.Location = new System.Drawing.Point(175, 24);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(34, 86);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 12);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblSaldo
            // 
            this.lblSaldo.AutoSize = true;
            this.lblSaldo.Location = new System.Drawing.Point(386, 115);
            this.lblSaldo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSaldo.Name = "lblSaldo";
            this.lblSaldo.Size = new System.Drawing.Size(47, 12);
            this.lblSaldo.TabIndex = 5;
            this.lblSaldo.Text = "Saldo:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(34, 115);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(138, 12);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(386, 87);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(75, 12);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 12);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(59, 19);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(139, 20);
            this.txtDni.TabIndex = 3;
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 22);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 12);
            this.lblDni.TabIndex = 0;
            this.lblDni.Text = "DNI:";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(102, 43);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(98, 28);
            this.cmdConsultar.TabIndex = 22;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // frmEliminarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 270);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.mrcDatosClientes);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.txtDni);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEliminarCliente";
            this.ShowIcon = false;
            this.Text = "Eliminar Cliente";
            this.Load += new System.EventHandler(this.frmEliminarCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.mrcDatosClientes.ResumeLayout(false);
            this.mrcDatosClientes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdEliminar;
        private System.Windows.Forms.PictureBox pickFoto;
        private System.Windows.Forms.GroupBox mrcDatosClientes;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtSaldo;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox lstActividades;
        private System.Windows.Forms.ComboBox lstBarrios;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblSaldo;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtSexo;
        private System.Windows.Forms.TextBox txtDias;
        private System.Windows.Forms.Label lblDias;
    }
}