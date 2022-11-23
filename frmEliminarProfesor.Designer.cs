namespace pryArlaIEFI_2
{
    partial class frmEliminarProfesor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEliminarProfesor));
            this.lblDni = new System.Windows.Forms.Label();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdVolver = new System.Windows.Forms.Button();
            this.cmdEliminar = new System.Windows.Forms.Button();
            this.pickFoto = new System.Windows.Forms.PictureBox();
            this.mrcDatos = new System.Windows.Forms.GroupBox();
            this.txtSexo = new System.Windows.Forms.TextBox();
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
            this.lblDni.Location = new System.Drawing.Point(7, 19);
            this.lblDni.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDni.Name = "lblDni";
            this.lblDni.Size = new System.Drawing.Size(33, 12);
            this.lblDni.TabIndex = 43;
            this.lblDni.Text = "DNI:";
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(103, 41);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(98, 28);
            this.cmdConsultar.TabIndex = 42;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(634, 230);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(98, 28);
            this.cmdVolver.TabIndex = 41;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // cmdEliminar
            // 
            this.cmdEliminar.Location = new System.Drawing.Point(754, 230);
            this.cmdEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminar.Name = "cmdEliminar";
            this.cmdEliminar.Size = new System.Drawing.Size(94, 28);
            this.cmdEliminar.TabIndex = 40;
            this.cmdEliminar.Text = "Eliminar";
            this.cmdEliminar.UseVisualStyleBackColor = true;
            this.cmdEliminar.Click += new System.EventHandler(this.cmdEliminar_Click);
            // 
            // pickFoto
            // 
            this.pickFoto.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.ErrorImage")));
            this.pickFoto.Image = ((System.Drawing.Image)(resources.GetObject("pickFoto.Image")));
            this.pickFoto.InitialImage = ((System.Drawing.Image)(resources.GetObject("pickFoto.InitialImage")));
            this.pickFoto.Location = new System.Drawing.Point(10, 71);
            this.pickFoto.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pickFoto.Name = "pickFoto";
            this.pickFoto.Size = new System.Drawing.Size(190, 149);
            this.pickFoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickFoto.TabIndex = 39;
            this.pickFoto.TabStop = false;
            // 
            // mrcDatos
            // 
            this.mrcDatos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mrcDatos.Controls.Add(this.txtSexo);
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
            this.mrcDatos.Location = new System.Drawing.Point(208, 17);
            this.mrcDatos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Name = "mrcDatos";
            this.mrcDatos.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcDatos.Size = new System.Drawing.Size(640, 203);
            this.mrcDatos.TabIndex = 38;
            this.mrcDatos.TabStop = false;
            this.mrcDatos.Text = "Datos del profesor";
            // 
            // txtSexo
            // 
            this.txtSexo.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtSexo.Enabled = false;
            this.txtSexo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtSexo.Location = new System.Drawing.Point(451, 66);
            this.txtSexo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtSexo.Name = "txtSexo";
            this.txtSexo.Size = new System.Drawing.Size(56, 20);
            this.txtSexo.TabIndex = 24;
            // 
            // lblSexo
            // 
            this.lblSexo.AutoSize = true;
            this.lblSexo.Location = new System.Drawing.Point(371, 69);
            this.lblSexo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSexo.Name = "lblSexo";
            this.lblSexo.Size = new System.Drawing.Size(40, 12);
            this.lblSexo.TabIndex = 23;
            this.lblSexo.Text = "Sexo:";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(29, 57);
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
            this.txtApellido.Location = new System.Drawing.Point(175, 55);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(116, 20);
            this.txtApellido.TabIndex = 2;
            // 
            // txtTelefono
            // 
            this.txtTelefono.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtTelefono.Enabled = false;
            this.txtTelefono.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtTelefono.Location = new System.Drawing.Point(175, 87);
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
            this.lstActividades.Location = new System.Drawing.Point(454, 25);
            this.lstActividades.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividades.Name = "lstActividades";
            this.lstActividades.Size = new System.Drawing.Size(170, 20);
            this.lstActividades.TabIndex = 8;
            // 
            // txtCorreo
            // 
            this.txtCorreo.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtCorreo.Enabled = false;
            this.txtCorreo.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.txtCorreo.Location = new System.Drawing.Point(175, 118);
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
            this.lblTelefono.Location = new System.Drawing.Point(29, 88);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(68, 12);
            this.lblTelefono.TabIndex = 7;
            this.lblTelefono.Text = "Telefono:";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.Location = new System.Drawing.Point(29, 118);
            this.lblCorreo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(138, 12);
            this.lblCorreo.TabIndex = 6;
            this.lblCorreo.Text = "Correo electronico:";
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(371, 30);
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
            // txtDni
            // 
            this.txtDni.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDni.Location = new System.Drawing.Point(61, 17);
            this.txtDni.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(139, 20);
            this.txtDni.TabIndex = 37;
            // 
            // frmEliminarProfesor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(878, 266);
            this.Controls.Add(this.lblDni);
            this.Controls.Add(this.cmdConsultar);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdEliminar);
            this.Controls.Add(this.pickFoto);
            this.Controls.Add(this.mrcDatos);
            this.Controls.Add(this.txtDni);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmEliminarProfesor";
            this.ShowIcon = false;
            this.Text = "Eliminar Profesor";
            this.Load += new System.EventHandler(this.frmEliminarProfesor_Load);
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
        private System.Windows.Forms.Button cmdEliminar;
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
        private System.Windows.Forms.Label lblSexo;
        private System.Windows.Forms.TextBox txtSexo;
    }
}