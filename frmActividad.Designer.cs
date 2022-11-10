namespace pryArlaIEFI_2
{
    partial class frmActividad
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
            this.mrcLinea1 = new System.Windows.Forms.GroupBox();
            this.mrcLinea2 = new System.Windows.Forms.GroupBox();
            this.cmdBorrar = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mrcLinea1
            // 
            this.mrcLinea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mrcLinea1.Location = new System.Drawing.Point(187, 12);
            this.mrcLinea1.Name = "mrcLinea1";
            this.mrcLinea1.Size = new System.Drawing.Size(10, 135);
            this.mrcLinea1.TabIndex = 15;
            this.mrcLinea1.TabStop = false;
            // 
            // mrcLinea2
            // 
            this.mrcLinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mrcLinea2.Location = new System.Drawing.Point(9, 139);
            this.mrcLinea2.Name = "mrcLinea2";
            this.mrcLinea2.Size = new System.Drawing.Size(172, 10);
            this.mrcLinea2.TabIndex = 14;
            this.mrcLinea2.TabStop = false;
            // 
            // cmdBorrar
            // 
            this.cmdBorrar.Location = new System.Drawing.Point(22, 89);
            this.cmdBorrar.Name = "cmdBorrar";
            this.cmdBorrar.Size = new System.Drawing.Size(141, 32);
            this.cmdBorrar.TabIndex = 9;
            this.cmdBorrar.Text = "Borrar";
            this.cmdBorrar.UseVisualStyleBackColor = true;
            this.cmdBorrar.Click += new System.EventHandler(this.cmdBorrar_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(22, 38);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(141, 32);
            this.cmdModificar.TabIndex = 8;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // frmActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 274);
            this.Controls.Add(this.mrcLinea1);
            this.Controls.Add(this.mrcLinea2);
            this.Controls.Add(this.cmdBorrar);
            this.Controls.Add(this.cmdModificar);
            this.Name = "frmActividad";
            this.Text = "Actividad";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox mrcLinea1;
        private System.Windows.Forms.GroupBox mrcLinea2;
        private System.Windows.Forms.Button cmdBorrar;
        private System.Windows.Forms.Button cmdModificar;
    }
}