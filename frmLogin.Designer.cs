namespace pryArlaIEFI_2
{
    partial class frmLogin
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.cmdIngresar = new System.Windows.Forms.Button();
            this.mrcUsuario = new System.Windows.Forms.GroupBox();
            this.mrcLinea = new System.Windows.Forms.GroupBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.pickLogo = new System.Windows.Forms.PictureBox();
            this.lblAyuda = new System.Windows.Forms.Label();
            this.mrcAyuda = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.pickLogo)).BeginInit();
            this.mrcAyuda.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdIngresar
            // 
            this.cmdIngresar.Location = new System.Drawing.Point(530, 142);
            this.cmdIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cmdIngresar.Name = "cmdIngresar";
            this.cmdIngresar.Size = new System.Drawing.Size(105, 31);
            this.cmdIngresar.TabIndex = 5;
            this.cmdIngresar.Text = "Ingresar";
            this.cmdIngresar.UseVisualStyleBackColor = true;
            this.cmdIngresar.Click += new System.EventHandler(this.cmdIngresar_Click);
            // 
            // mrcUsuario
            // 
            this.mrcUsuario.Location = new System.Drawing.Point(337, -2);
            this.mrcUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcUsuario.Name = "mrcUsuario";
            this.mrcUsuario.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcUsuario.Size = new System.Drawing.Size(14, 244);
            this.mrcUsuario.TabIndex = 4;
            this.mrcUsuario.TabStop = false;
            // 
            // mrcLinea
            // 
            this.mrcLinea.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mrcLinea.Location = new System.Drawing.Point(337, -2);
            this.mrcLinea.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcLinea.Name = "mrcLinea";
            this.mrcLinea.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcLinea.Size = new System.Drawing.Size(14, 267);
            this.mrcLinea.TabIndex = 5;
            this.mrcLinea.TabStop = false;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblContraseña.Location = new System.Drawing.Point(377, 100);
            this.lblContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(102, 18);
            this.lblContraseña.TabIndex = 3;
            this.lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(377, 56);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(70, 18);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario";
            // 
            // txtContraseña
            // 
            this.txtContraseña.BackColor = System.Drawing.SystemColors.Window;
            this.txtContraseña.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtContraseña.Location = new System.Drawing.Point(507, 101);
            this.txtContraseña.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraseña.MaxLength = 4;
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(128, 20);
            this.txtContraseña.TabIndex = 1;
            this.txtContraseña.TextChanged += new System.EventHandler(this.txtContraseña_TextChanged);
            // 
            // txtUsuario
            // 
            this.txtUsuario.BackColor = System.Drawing.SystemColors.Window;
            this.txtUsuario.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.txtUsuario.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuario.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtUsuario.Location = new System.Drawing.Point(507, 55);
            this.txtUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtUsuario.MaxLength = 5;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(128, 20);
            this.txtUsuario.TabIndex = 0;
            this.txtUsuario.TextChanged += new System.EventHandler(this.txtUsuario_TextChanged);
            // 
            // pickLogo
            // 
            this.pickLogo.Image = ((System.Drawing.Image)(resources.GetObject("pickLogo.Image")));
            this.pickLogo.Location = new System.Drawing.Point(34, 28);
            this.pickLogo.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pickLogo.Name = "pickLogo";
            this.pickLogo.Size = new System.Drawing.Size(272, 215);
            this.pickLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pickLogo.TabIndex = 6;
            this.pickLogo.TabStop = false;
            // 
            // lblAyuda
            // 
            this.lblAyuda.AutoSize = true;
            this.lblAyuda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAyuda.Location = new System.Drawing.Point(9, 11);
            this.lblAyuda.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAyuda.Name = "lblAyuda";
            this.lblAyuda.Size = new System.Drawing.Size(59, 16);
            this.lblAyuda.TabIndex = 7;
            this.lblAyuda.Text = "¡Ayuda!";
            this.lblAyuda.Click += new System.EventHandler(this.lblAyuda_Click);
            this.lblAyuda.MouseLeave += new System.EventHandler(this.lblAyuda_MouseLeave);
            this.lblAyuda.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblAyuda_MouseMove);
            // 
            // mrcAyuda
            // 
            this.mrcAyuda.Controls.Add(this.lblAyuda);
            this.mrcAyuda.Location = new System.Drawing.Point(380, 221);
            this.mrcAyuda.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAyuda.Name = "mrcAyuda";
            this.mrcAyuda.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.mrcAyuda.Size = new System.Drawing.Size(255, 32);
            this.mrcAyuda.TabIndex = 8;
            this.mrcAyuda.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(662, 266);
            this.Controls.Add(this.mrcLinea);
            this.Controls.Add(this.pickLogo);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.cmdIngresar);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtUsuario);
            this.Controls.Add(this.mrcUsuario);
            this.Controls.Add(this.mrcAyuda);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pickLogo)).EndInit();
            this.mrcAyuda.ResumeLayout(false);
            this.mrcAyuda.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdIngresar;
        private System.Windows.Forms.GroupBox mrcUsuario;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.PictureBox pickLogo;
        private System.Windows.Forms.Label lblAyuda;
        private System.Windows.Forms.GroupBox mrcLinea;
        private System.Windows.Forms.GroupBox mrcAyuda;
    }
}

