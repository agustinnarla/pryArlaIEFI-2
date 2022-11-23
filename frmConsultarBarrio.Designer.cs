namespace pryArlaIEFI_2
{
    partial class frmConsultarBarrio
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
            this.grlPrincipalBarrio = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lstBarrio = new System.Windows.Forms.ComboBox();
            this.lblBarrio = new System.Windows.Forms.Label();
            this.cmdVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipalBarrio)).BeginInit();
            this.SuspendLayout();
            // 
            // cmdListar
            // 
            this.cmdListar.Enabled = false;
            this.cmdListar.Location = new System.Drawing.Point(398, 194);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(96, 39);
            this.cmdListar.TabIndex = 7;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // grlPrincipalBarrio
            // 
            this.grlPrincipalBarrio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlPrincipalBarrio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Apellido,
            this.Dni});
            this.grlPrincipalBarrio.Location = new System.Drawing.Point(35, 59);
            this.grlPrincipalBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grlPrincipalBarrio.Name = "grlPrincipalBarrio";
            this.grlPrincipalBarrio.Size = new System.Drawing.Size(458, 129);
            this.grlPrincipalBarrio.TabIndex = 6;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Apellido
            // 
            this.Apellido.HeaderText = "Apellido";
            this.Apellido.Name = "Apellido";
            this.Apellido.ReadOnly = true;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
            // 
            // lstBarrio
            // 
            this.lstBarrio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.lstBarrio.FormattingEnabled = true;
            this.lstBarrio.Location = new System.Drawing.Point(145, 20);
            this.lstBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstBarrio.Name = "lstBarrio";
            this.lstBarrio.Size = new System.Drawing.Size(250, 20);
            this.lstBarrio.TabIndex = 5;
            this.lstBarrio.SelectedIndexChanged += new System.EventHandler(this.lstBarrio_SelectedIndexChanged);
            // 
            // lblBarrio
            // 
            this.lblBarrio.AutoSize = true;
            this.lblBarrio.Location = new System.Drawing.Point(31, 23);
            this.lblBarrio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBarrio.Name = "lblBarrio";
            this.lblBarrio.Size = new System.Drawing.Size(47, 12);
            this.lblBarrio.TabIndex = 4;
            this.lblBarrio.Text = "Barrio";
            // 
            // cmdVolver
            // 
            this.cmdVolver.Enabled = false;
            this.cmdVolver.Location = new System.Drawing.Point(294, 194);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(96, 39);
            this.cmdVolver.TabIndex = 8;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmConsultarBarrio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(506, 244);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.grlPrincipalBarrio);
            this.Controls.Add(this.lstBarrio);
            this.Controls.Add(this.lblBarrio);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConsultarBarrio";
            this.ShowIcon = false;
            this.Text = "Consultar por Barrio";
            this.Load += new System.EventHandler(this.frmConsultarBarrio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipalBarrio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.DataGridView grlPrincipalBarrio;
        private System.Windows.Forms.ComboBox lstBarrio;
        private System.Windows.Forms.Label lblBarrio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.Button cmdVolver;
    }
}