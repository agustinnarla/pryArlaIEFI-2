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
            this.grlPrincipal = new System.Windows.Forms.DataGridView();
            this.cmdListar = new System.Windows.Forms.Button();
            this.lstImprimir = new System.Windows.Forms.Button();
            this.lstExportar = new System.Windows.Forms.Button();
            this.mrcSaldo = new System.Windows.Forms.GroupBox();
            this.lblMayor = new System.Windows.Forms.Label();
            this.lblMenor = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblPromedio = new System.Windows.Forms.Label();
            this.txtMayor = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtPromedio = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipal)).BeginInit();
            this.mrcSaldo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblActividad
            // 
            this.lblActividad.AutoSize = true;
            this.lblActividad.Location = new System.Drawing.Point(46, 30);
            this.lblActividad.Name = "lblActividad";
            this.lblActividad.Size = new System.Drawing.Size(51, 13);
            this.lblActividad.TabIndex = 0;
            this.lblActividad.Text = "Actividad";
            // 
            // lstActividad
            // 
            this.lstActividad.FormattingEnabled = true;
            this.lstActividad.Location = new System.Drawing.Point(143, 27);
            this.lstActividad.Name = "lstActividad";
            this.lstActividad.Size = new System.Drawing.Size(215, 21);
            this.lstActividad.TabIndex = 1;
            // 
            // grlPrincipal
            // 
            this.grlPrincipal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grlPrincipal.Location = new System.Drawing.Point(49, 69);
            this.grlPrincipal.Name = "grlPrincipal";
            this.grlPrincipal.Size = new System.Drawing.Size(393, 140);
            this.grlPrincipal.TabIndex = 2;
            // 
            // cmdListar
            // 
            this.cmdListar.Location = new System.Drawing.Point(469, 73);
            this.cmdListar.Name = "cmdListar";
            this.cmdListar.Size = new System.Drawing.Size(82, 42);
            this.cmdListar.TabIndex = 3;
            this.cmdListar.Text = "Listar";
            this.cmdListar.UseVisualStyleBackColor = true;
            // 
            // lstImprimir
            // 
            this.lstImprimir.Location = new System.Drawing.Point(469, 119);
            this.lstImprimir.Name = "lstImprimir";
            this.lstImprimir.Size = new System.Drawing.Size(82, 42);
            this.lstImprimir.TabIndex = 4;
            this.lstImprimir.Text = "Impimir";
            this.lstImprimir.UseVisualStyleBackColor = true;
            // 
            // lstExportar
            // 
            this.lstExportar.Location = new System.Drawing.Point(469, 167);
            this.lstExportar.Name = "lstExportar";
            this.lstExportar.Size = new System.Drawing.Size(82, 42);
            this.lstExportar.TabIndex = 5;
            this.lstExportar.Text = "Exportar";
            this.lstExportar.UseVisualStyleBackColor = true;
            // 
            // mrcSaldo
            // 
            this.mrcSaldo.Controls.Add(this.txtPromedio);
            this.mrcSaldo.Controls.Add(this.txtTotal);
            this.mrcSaldo.Controls.Add(this.textBox2);
            this.mrcSaldo.Controls.Add(this.txtMayor);
            this.mrcSaldo.Controls.Add(this.lblPromedio);
            this.mrcSaldo.Controls.Add(this.lblTotal);
            this.mrcSaldo.Controls.Add(this.lblMenor);
            this.mrcSaldo.Controls.Add(this.lblMayor);
            this.mrcSaldo.Location = new System.Drawing.Point(49, 215);
            this.mrcSaldo.Name = "mrcSaldo";
            this.mrcSaldo.Size = new System.Drawing.Size(393, 111);
            this.mrcSaldo.TabIndex = 6;
            this.mrcSaldo.TabStop = false;
            this.mrcSaldo.Text = "Saldo";
            // 
            // lblMayor
            // 
            this.lblMayor.AutoSize = true;
            this.lblMayor.Location = new System.Drawing.Point(13, 29);
            this.lblMayor.Name = "lblMayor";
            this.lblMayor.Size = new System.Drawing.Size(36, 13);
            this.lblMayor.TabIndex = 0;
            this.lblMayor.Text = "Mayor";
            // 
            // lblMenor
            // 
            this.lblMenor.AutoSize = true;
            this.lblMenor.Location = new System.Drawing.Point(13, 68);
            this.lblMenor.Name = "lblMenor";
            this.lblMenor.Size = new System.Drawing.Size(37, 13);
            this.lblMenor.TabIndex = 1;
            this.lblMenor.Text = "Menor";
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(246, 29);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(31, 13);
            this.lblTotal.TabIndex = 2;
            this.lblTotal.Text = "Total";
            // 
            // lblPromedio
            // 
            this.lblPromedio.AutoSize = true;
            this.lblPromedio.Location = new System.Drawing.Point(246, 68);
            this.lblPromedio.Name = "lblPromedio";
            this.lblPromedio.Size = new System.Drawing.Size(51, 13);
            this.lblPromedio.TabIndex = 3;
            this.lblPromedio.Text = "Promedio";
            // 
            // txtMayor
            // 
            this.txtMayor.Enabled = false;
            this.txtMayor.Location = new System.Drawing.Point(95, 29);
            this.txtMayor.Name = "txtMayor";
            this.txtMayor.Size = new System.Drawing.Size(59, 20);
            this.txtMayor.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(95, 65);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(59, 20);
            this.textBox2.TabIndex = 5;
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(313, 26);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(57, 20);
            this.txtTotal.TabIndex = 6;
            this.txtTotal.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // txtPromedio
            // 
            this.txtPromedio.Enabled = false;
            this.txtPromedio.Location = new System.Drawing.Point(313, 65);
            this.txtPromedio.Name = "txtPromedio";
            this.txtPromedio.Size = new System.Drawing.Size(57, 20);
            this.txtPromedio.TabIndex = 7;
            // 
            // frmConsultaActividad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 355);
            this.Controls.Add(this.mrcSaldo);
            this.Controls.Add(this.lstExportar);
            this.Controls.Add(this.lstImprimir);
            this.Controls.Add(this.cmdListar);
            this.Controls.Add(this.grlPrincipal);
            this.Controls.Add(this.lstActividad);
            this.Controls.Add(this.lblActividad);
            this.Name = "frmConsultaActividad";
            this.ShowIcon = false;
            this.Text = "Consulta por Actividad";
            ((System.ComponentModel.ISupportInitialize)(this.grlPrincipal)).EndInit();
            this.mrcSaldo.ResumeLayout(false);
            this.mrcSaldo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActividad;
        private System.Windows.Forms.ComboBox lstActividad;
        private System.Windows.Forms.DataGridView grlPrincipal;
        private System.Windows.Forms.Button cmdListar;
        private System.Windows.Forms.Button lstImprimir;
        private System.Windows.Forms.Button lstExportar;
        private System.Windows.Forms.GroupBox mrcSaldo;
        private System.Windows.Forms.TextBox txtPromedio;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMayor;
        private System.Windows.Forms.Label lblPromedio;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblMenor;
        private System.Windows.Forms.Label lblMayor;
    }
}