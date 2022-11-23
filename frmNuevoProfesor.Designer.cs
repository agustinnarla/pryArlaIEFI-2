namespace pryArlaIEFI_2
{
    partial class frmNuevoProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmNuevoProfesor));
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.lblDni = new System.Windows.Forms.Label();
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
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).BeginInit();
            this.mrcDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(14, 35);
            this.pickFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(190, 144);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 27;
            this.pickFoto.TabStop = false;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcDatos.Controls.Add(this.txtDni);
            this.mrcDatos.Controls.Add(this.lblDni);
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
            this.mrcDatos.Location = new System.Drawing.Point(208, 27);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(712, 152);
            this.mrcDatos.TabIndex = 26;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del profesor";
            // 
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDni.Location = new System.Drawing.Point(118, 114);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.MaxLength = 8;
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(116, 20);
            this.txtDni.TabIndex = 24;
            this.txtDni.TextChanged += new System.EventHandler(this.txtDni_TextChanged);
            // 
            // lblDni
            // 
            this.lblDni.AutoSize = true;
            this.lblDni.Location = new System.Drawing.Point(29, 115);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 12);
            this.lblDni.TabIndex = 23;
            this.lblDni.Text = "DNI:";
            // 
            // lstSexo
            // 
            this.lstSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstSexo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstSexo.FormattingEnabled = true;
            this.lstSexo.Items.AddRange(new object[] {
            "F",
            "M"});
            this.lstSexo.Location = new System.Drawing.Point(431, 54);
            this.lstSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstSexo.Name = "lstSexo";
            this.lstSexo.Size = new System.Drawing.Size(62, 20);
            this.lstSexo.TabIndex = 22;
            this.lstSexo.SelectedIndexChanged += new System.EventHandler(this.lstSexo_SelectedIndexChanged);
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(285, 56);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 12);
            this.lblSexo.TabIndex = 21;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 56);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(68, 12);
            this.lblApellido.TabIndex = 20;
            this.lblApellido.Text = "Apellido:";
            // 
            // txtApellido
            // 
            this.txtApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtApellido.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellido.Location = new System.Drawing.Point(118, 54);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 2;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.Location = new System.Drawing.Point(118, 84);
            this.txtTelefono.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtTelefono.MaxLength = 8;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(116, 20);
            this.txtTelefono.TabIndex = 4;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            // 
            // lstActividades
            // 
            this.lstActividades.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstActividades.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstActividades.FormattingEnabled = true;
            this.lstActividades.Location = new System.Drawing.Point(431, 21);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(170, 20);
            this.lstActividades.TabIndex = 8;
            this.lstActividades.SelectedIndexChanged += new System.EventHandler(this.lstActividades_SelectedIndexChanged);
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCorreo.Location = new System.Drawing.Point(431, 84);
            this.txtCorreo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(168, 20);
            this.txtCorreo.TabIndex = 5;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtNombre
            // 
            this.txtNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtNombre.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(118, 25);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(116, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(29, 86);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 12);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(285, 86);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(138, 12);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(285, 27);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(75, 12);
            this.lblActividad.TabIndex = 4;
            this.lblActividad.Text = "Actividad:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(29, 27);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 12);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(720, 187);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(98, 28);
            this.cmdVolver.TabIndex = 29;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click_1);
            // 
            // cmdCargar
            // 
            this.cmdCargar.Enabled = false;
            this.cmdCargar.Location = new System.Drawing.Point(825, 187);
            this.cmdCargar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(94, 28);
            this.cmdCargar.TabIndex = 28;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            this.cmdCargar.Click += new System.EventHandler(this.cmdCargar_Click_1);
            // 
            // frmNuevoProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(933, 226);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdCargar);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.mrcDatos);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmNuevoProfesor";
            this.ShowIcon = false;
            this.Text = "Nuevo Profesor";
            this.Load += new System.EventHandler(this.frmNuevoProfesor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickFoto)).EndInit();
            this.mrcDatos.ResumeLayout(false);
            this.mrcDatos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

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
        private System.Windows.Forms.ComboBox lstSexo;
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.Label lblDni;
        private System.Windows.Forms.Button cmdVolver;
        private System.Windows.Forms.Button cmdCargar;
    }
}