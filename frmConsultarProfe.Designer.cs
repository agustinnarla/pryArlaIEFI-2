namespace pryArlaIEFI_2
{
    partial class frmConsultarProfe
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
            this.cmdListar = new System.Windows.Forms.Button();
            this.grlPrincipal = new System.Windows.Forms.DataGridView();
            this.lstProfesor = new System.Windows.Forms.ComboBox();
            this.lblProfesor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipal)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(346, 217);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(82, 42);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // grlPrincipal
            // 
            this.grlPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlPrincipal.Location = new System.Drawing.Point(35, 71);
            this.grlPrincipal.Name = "grlPrincipal";
            this.grlPrincipal.Size = new System.Drawing.Size(393, 140);
            this.grlPrincipal.TabIndex = 6;
            // 
            // lstProfesor
            // 
            this.lstProfesor.FormattingEnabled = true;
            this.lstProfesor.Location = new System.Drawing.Point(129, 29);
            this.lstProfesor.Name = "lstProfesor";
            this.lstProfesor.Size = new System.Drawing.Size(215, 21);
            this.lstProfesor.TabIndex = 5;
            // 
            // lblProfesor
            // 
            this.lblProfesor.AutoSize = true;
            this.lblProfesor.Location = new System.Drawing.Point(32, 32);
            this.lblProfesor.Name = "lblProfesor";
            this.lblProfesor.Size = new System.Drawing.Size(46, 13);
            this.lblProfesor.TabIndex = 4;
            this.lblProfesor.Text = "Profesor";
            // 
            // frmConsultarProfe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 291);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.grlPrincipal);
            this.Controls.Add(this.lstProfesor);
            this.Controls.Add(this.lblProfesor);
            this.Name = "frmConsultarProfe";
            this.Text = "Consultar por Profe";
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView grlPrincipal;
        private System.Windows.Forms.ComboBox lstProfesor;
        private System.Windows.Forms.Label lblProfesor;
    }
}