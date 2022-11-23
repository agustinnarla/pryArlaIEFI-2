namespace pryArlaIEFI_2
{
    partial class frmConsultaActividad
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
            this.lblActividad = new System.Windows.Forms.Label();
            this.lstActividad = new System.Windows.Forms.ComboBox();
            this.grlPrincipalActividad = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lstImprimir = new System.Windows.Forms.Button();
            this.lstExportar = new System.Windows.Forms.Button();
            this.prtVentana = new System.Windows.Forms.PrintDialog();
            this.prtDocumento = new System.Drawing.Printing.PrintDocument();
            this.cmdVolver = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipalActividad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(77, 26);
            this.lblActividad.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(68, 12);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(190, 23);
            this.lstActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(250, 20);
            this.lstActividad.TabIndex = 1;
            this.lstActividad.SelectedIndexChanged += new System.EventHandler(this.lstActividad_SelectedIndexChanged);
            // 
            // grlPrincipalActividad
            // 
            this.grlPrincipalActividad.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlPrincipalActividad.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.Nombre,
            this.Apellido});
            this.grlPrincipalActividad.Location = new System.Drawing.Point(69, 80);
            this.grlPrincipalActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.grlPrincipalActividad.Name = "grlPrincipalActividad";
            this.grlPrincipalActividad.Size = new System.Drawing.Size(439, 206);
            this.grlPrincipalActividad.TabIndex = 2;
            // 
            // Dni
            // 
            this.Dni.HeaderText = "Dni";
            this.Dni.Name = "Dni";
            this.Dni.ReadOnly = true;
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
            // cmdListar
            // 
            this.cmdListar.Enabled = false;
            this.cmdListar.Location = new System.Drawing.Point(412, 48);
            this.cmdListar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(96, 27);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            this.cmdListar.Click += new System.EventHandler(this.cmdListar_Click);
            // 
            // lstImprimir
            // 
            this.lstImprimir.Location = new System.Drawing.Point(309, 292);
            this.lstImprimir.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstImprimir.Name = "lstImprimir";
            this.lstImprimir.Size = new System.Drawing.Size(96, 27);
            this.lstImprimir.TabIndex = 4;
            this.lstImprimir.Text = "Impimir";
            this.lstImprimir.UseVisualStyleBackColor = true;
            this.lstImprimir.Click += new System.EventHandler(this.lstImprimir_Click);
            // 
            // lstExportar
            // 
            this.lstExportar.Location = new System.Drawing.Point(412, 292);
            this.lstExportar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lstExportar.Name = "lstExportar";
            this.lstExportar.Size = new System.Drawing.Size(96, 27);
            this.lstExportar.TabIndex = 5;
            this.lstExportar.Text = "Exportar";
            this.lstExportar.UseVisualStyleBackColor = true;
            this.lstExportar.Click += new System.EventHandler(this.lstExportar_Click);
            // 
            // prtVentana
            // 
            this.prtVentana.UseEXDialog = true;
            // 
            // prtDocumento
            // 
            this.prtDocumento.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocumento_PrintPage);
            // 
            // cmdVolver
            // 
            this.cmdVolver.Location = new System.Drawing.Point(205, 292);
            this.cmdVolver.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdVolver.Name = "cmdVolver";
            this.cmdVolver.Size = new System.Drawing.Size(96, 27);
            this.cmdVolver.TabIndex = 6;
            this.cmdVolver.Text = "Volver";
            this.cmdVolver.UseVisualStyleBackColor = true;
            this.cmdVolver.Click += new System.EventHandler(this.cmdVolver_Click);
            // 
            // frmConsultaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(530, 330);
            this.Controls.Add(this.cmdVolver);
            this.Controls.Add(this.lstExportar);
            this.Controls.Add(this.lstImprimir);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.grlPrincipalActividad);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.lblActividad);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmConsultaActividad";
            this.ShowIcon = false;
            this.Text = "Consulta por Actividad";
            this.Load += new System.EventHandler(this.frmConsultaActividad_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipalActividad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DataGridView grlPrincipalActividad;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button lstImprimir;
        private System.Windows.Forms.Button lstExportar;
        private System.Windows.Forms.PrintDialog prtVentana;
        private System.Drawing.Printing.PrintDocument prtDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellido;
        private System.Windows.Forms.Button cmdVolver;
    }
}