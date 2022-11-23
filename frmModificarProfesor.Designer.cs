namespace pryArlaIEFI_2
{
    partial class frmModificarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmModificarProfesor));
            this.lblDni = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.lstSexo = new System.Windows.Forms.ComboBox();
            this.lblSexo = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lstActividades = new System.Windows.Forms.ComboBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblActividad = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtDni = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(6, 37);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(29, 13);
            this.lblDni.TabIndex = 36;
            this.lblDni.Text = "DNI:";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(88, 60);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(84, 30);
            this.cmdConsultar.TabIndex = 35;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(353, 255);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(84, 30);
            this.cmdVolver.TabIndex = 34;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(456, 255);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(81, 30);
            this.cmdModificar.TabIndex = 33;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(9, 93);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(163, 161);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 32;
            this.pickFoto.TabStop = false;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcDatos.Controls.Add(this.lstSexo);
            this.mrcDatos.Controls.Add(this.lblSexo);
            this.mrcDatos.Controls.Add(this.lblApellido);
            this.mrcDatos.Controls.Add(this.txtApellido);
            this.mrcDatos.Controls.Add(this.txtTelefono);
            this.mrcDatos.Controls.Add(this.lstActividades);
            this.mrcDatos.Controls.Add(this.txtCorreo);
            this.mrcDatos.Controls.Add(this.txtNombre);
            this.mrcDatos.Controls.Add(this.lblTelefono);
            this.mrcDatos.Controls.Add(this.lblCorreo);
            this.mrcDatos.Controls.Add(this.lblActividad);
            this.mrcDatos.Controls.Add(this.lblNombre);
            this.mrcDatos.Location = new System.Drawing.Point(191, 34);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Size = new System.Drawing.Size(346, 215);
            this.mrcDatos.TabIndex = 31;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del profesor";
            // 
            // lstSexo
            // 
            this.lstSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSexo.Enabled = false;
            this.lstSexo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.lstSexo.Location = new System.Drawing.Point(145, 187);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(54, 20);
            this.lstSexo.TabIndex = 26;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(21, 189);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(34, 13);
            this.lblSexo.TabIndex = 25;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(21, 61);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(47, 13);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Enabled = false;
            this.txtApellido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtApellido.Location = new System.Drawing.Point(146, 58);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtTelefono.Location = new System.Drawing.Point(146, 90);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 4;
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.Enabled = false;
            this.lstActividades.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(145, 154);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(167, 20);
            this.lstActividades.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtCorreo.Location = new System.Drawing.Point(146, 122);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(166, 20);
            this.txtCorreo.TabIndex = 5;
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Enabled = false;
            this.txtNombre.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtNombre.Location = new System.Drawing.Point(146, 26);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(21, 93);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(52, 13);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(21, 125);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(96, 13);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(21, 157);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(54, 13);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(21, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(47, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtDni.Location = new System.Drawing.Point(52, 34);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(120, 20);
            this.txtDni.TabIndex = 30;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged_1);
            // 
            // frmModificarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(566, 298);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdModificar);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.txtDni);
            this.Name = "frmModificarProfesor";
            this.ShowIcon = false;
            this.Text = "Modificar Profesor";
            this.Load += new System.EventHandler(this.frmModificarProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.PictureBox pickFoto;
        private System.Windows.Forms.GroupBox mrcDatos;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.ComboBox lstActividades;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.ComboBox lstSexo;
        private System.Windows.Forms.Label lblSexo;
    }
}