namespace pryArlaIEFI_2
{
    partial class frmPrincipal
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
            this.cmdCliente = new System.Windows.Forms.Button();
            this.cmdConsultar = new System.Windows.Forms.Button();
            this.cmdActividad = new System.Windows.Forms.Button();
            this.cmdAcceso = new System.Windows.Forms.Button();
            this.cmdBarrio = new System.Windows.Forms.Button();
            this.mrcLinea2 = new System.Windows.Forms.GroupBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.panelProfesor = new System.Windows.Forms.Panel();
            this.cmdModificarProfe = new System.Windows.Forms.Button();
            this.cmdAltaProfe = new System.Windows.Forms.Button();
            this.cmdEliminarProfe = new System.Windows.Forms.Button();
            this.cmdProfesor = new System.Windows.Forms.Button();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.cmdConsultaBarrio = new System.Windows.Forms.Button();
            this.cmdConsultaActividad = new System.Windows.Forms.Button();
            this.panelBarrio = new System.Windows.Forms.Panel();
            this.cmdEliminarBarrio = new System.Windows.Forms.Button();
            this.cmdModificarBarrio = new System.Windows.Forms.Button();
            this.panelActividad = new System.Windows.Forms.Panel();
            this.cmdEliminarActividad = new System.Windows.Forms.Button();
            this.cmdModificarActividad = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdBaja = new System.Windows.Forms.Button();
            this.cmdNuevoCliente = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.pMenu.SuspendLayout();
            this.panelProfesor.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelBarrio.SuspendLayout();
            this.panelActividad.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCliente
            // 
            this.cmdCliente.Location = new System.Drawing.Point(181, 14);
            this.cmdCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(135, 30);
            this.cmdCliente.TabIndex = 0;
            this.cmdCliente.Text = "Clientes";
            this.cmdCliente.UseVisualStyleBackColor = true;
            this.cmdCliente.Click += new System.EventHandler(this.cmdCliente_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(350, 14);
            this.cmdConsultar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(135, 30);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            this.cmdConsultar.MouseEnter += new System.EventHandler(this.cmdActivar_MouseEnter);
            this.cmdConsultar.MouseLeave += new System.EventHandler(this.cmdActivar_MouseLeave);
            // 
            // cmdActividad
            // 
            this.cmdActividad.Location = new System.Drawing.Point(519, 14);
            this.cmdActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdActividad.Name = "cmdActividad";
            this.cmdActividad.Size = new System.Drawing.Size(135, 30);
            this.cmdActividad.TabIndex = 2;
            this.cmdActividad.Text = "Actividad";
            this.cmdActividad.UseVisualStyleBackColor = true;
            this.cmdActividad.Click += new System.EventHandler(this.cmdActividad_Click);
            this.cmdActividad.MouseEnter += new System.EventHandler(this.cmdActivar_MouseEnter);
            this.cmdActividad.MouseLeave += new System.EventHandler(this.cmdActivar_MouseLeave);
            // 
            // cmdAcceso
            // 
            this.cmdAcceso.Location = new System.Drawing.Point(12, 14);
            this.cmdAcceso.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAcceso.Name = "cmdAcceso";
            this.cmdAcceso.Size = new System.Drawing.Size(135, 30);
            this.cmdAcceso.TabIndex = 4;
            this.cmdAcceso.Text = "Acceso";
            this.cmdAcceso.UseVisualStyleBackColor = true;
            this.cmdAcceso.Click += new System.EventHandler(this.cmdAcceso_Click);
            // 
            // cmdBarrio
            // 
            this.cmdBarrio.Location = new System.Drawing.Point(688, 14);
            this.cmdBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdBarrio.Name = "cmdBarrio";
            this.cmdBarrio.Size = new System.Drawing.Size(135, 30);
            this.cmdBarrio.TabIndex = 5;
            this.cmdBarrio.Text = "Barrio";
            this.cmdBarrio.UseVisualStyleBackColor = true;
            this.cmdBarrio.Click += new System.EventHandler(this.cmdBarrio_Click);
            this.cmdBarrio.MouseEnter += new System.EventHandler(this.cmdActivar_MouseEnter);
            this.cmdBarrio.MouseLeave += new System.EventHandler(this.cmdActivar_MouseLeave);
            // 
            // mrcLinea2
            // 
            this.mrcLinea2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mrcLinea2.Location = new System.Drawing.Point(2, 200);
            this.mrcLinea2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcLinea2.Name = "mrcLinea2";
            this.mrcLinea2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.mrcLinea2.Size = new System.Drawing.Size(1046, 9);
            this.mrcLinea2.TabIndex = 6;
            this.mrcLinea2.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.panelProfesor);
            this.pMenu.Controls.Add(this.cmdProfesor);
            this.pMenu.Controls.Add(this.panelConsulta);
            this.pMenu.Controls.Add(this.panelBarrio);
            this.pMenu.Controls.Add(this.panelActividad);
            this.pMenu.Controls.Add(this.panelCliente);
            this.pMenu.Controls.Add(this.cmdBarrio);
            this.pMenu.Controls.Add(this.cmdAcceso);
            this.pMenu.Controls.Add(this.cmdActividad);
            this.pMenu.Controls.Add(this.cmdConsultar);
            this.pMenu.Controls.Add(this.cmdCliente);
            this.pMenu.Location = new System.Drawing.Point(2, 6);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(1046, 181);
            this.pMenu.TabIndex = 8;
            this.pMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.pMenu_Paint);
            // 
            // panelProfesor
            // 
            this.panelProfesor.Controls.Add(this.cmdModificarProfe);
            this.panelProfesor.Controls.Add(this.cmdAltaProfe);
            this.panelProfesor.Controls.Add(this.cmdEliminarProfe);
            this.panelProfesor.Location = new System.Drawing.Point(867, 50);
            this.panelProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelProfesor.Name = "panelProfesor";
            this.panelProfesor.Size = new System.Drawing.Size(148, 114);
            this.panelProfesor.TabIndex = 15;
            this.panelProfesor.Visible = false;
            // 
            // cmdModificarProfe
            // 
            this.cmdModificarProfe.Location = new System.Drawing.Point(4, 78);
            this.cmdModificarProfe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdModificarProfe.Name = "cmdModificarProfe";
            this.cmdModificarProfe.Size = new System.Drawing.Size(135, 30);
            this.cmdModificarProfe.TabIndex = 18;
            this.cmdModificarProfe.Text = "Modificar";
            this.cmdModificarProfe.UseVisualStyleBackColor = true;
            this.cmdModificarProfe.Click += new System.EventHandler(this.cmdModificarPorfe_Click);
            // 
            // cmdAltaProfe
            // 
            this.cmdAltaProfe.Location = new System.Drawing.Point(4, 6);
            this.cmdAltaProfe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdAltaProfe.Name = "cmdAltaProfe";
            this.cmdAltaProfe.Size = new System.Drawing.Size(135, 30);
            this.cmdAltaProfe.TabIndex = 12;
            this.cmdAltaProfe.Text = "Alta";
            this.cmdAltaProfe.UseVisualStyleBackColor = true;
            this.cmdAltaProfe.Click += new System.EventHandler(this.cmdAltaProfe_Click);
            // 
            // cmdEliminarProfe
            // 
            this.cmdEliminarProfe.Location = new System.Drawing.Point(4, 42);
            this.cmdEliminarProfe.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminarProfe.Name = "cmdEliminarProfe";
            this.cmdEliminarProfe.Size = new System.Drawing.Size(135, 30);
            this.cmdEliminarProfe.TabIndex = 17;
            this.cmdEliminarProfe.Text = "Baja";
            this.cmdEliminarProfe.UseVisualStyleBackColor = true;
            this.cmdEliminarProfe.Click += new System.EventHandler(this.cdmEliminarProfe_Click);
            // 
            // cmdProfesor
            // 
            this.cmdProfesor.Location = new System.Drawing.Point(867, 14);
            this.cmdProfesor.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdProfesor.Name = "cmdProfesor";
            this.cmdProfesor.Size = new System.Drawing.Size(135, 30);
            this.cmdProfesor.TabIndex = 7;
            this.cmdProfesor.Text = "Profesor";
            this.cmdProfesor.UseVisualStyleBackColor = true;
            this.cmdProfesor.Click += new System.EventHandler(this.cmdProfesor_Click);
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.cmdConsultaBarrio);
            this.panelConsulta.Controls.Add(this.cmdConsultaActividad);
            this.panelConsulta.Location = new System.Drawing.Point(350, 50);
            this.panelConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(148, 88);
            this.panelConsulta.TabIndex = 15;
            this.panelConsulta.Visible = false;
            this.panelConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsulta_Paint);
            // 
            // cmdConsultaBarrio
            // 
            this.cmdConsultaBarrio.Location = new System.Drawing.Point(4, 45);
            this.cmdConsultaBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultaBarrio.Name = "cmdConsultaBarrio";
            this.cmdConsultaBarrio.Size = new System.Drawing.Size(135, 30);
            this.cmdConsultaBarrio.TabIndex = 14;
            this.cmdConsultaBarrio.Text = "Por Barrio";
            this.cmdConsultaBarrio.UseVisualStyleBackColor = true;
            this.cmdConsultaBarrio.Click += new System.EventHandler(this.cmdConsultaBarrio_Click);
            // 
            // cmdConsultaActividad
            // 
            this.cmdConsultaActividad.Location = new System.Drawing.Point(4, 9);
            this.cmdConsultaActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdConsultaActividad.Name = "cmdConsultaActividad";
            this.cmdConsultaActividad.Size = new System.Drawing.Size(135, 30);
            this.cmdConsultaActividad.TabIndex = 11;
            this.cmdConsultaActividad.Text = "Por Actividad";
            this.cmdConsultaActividad.UseVisualStyleBackColor = true;
            this.cmdConsultaActividad.Click += new System.EventHandler(this.cmdConsultaActividad_Click);
            // 
            // panelBarrio
            // 
            this.panelBarrio.Controls.Add(this.cmdEliminarBarrio);
            this.panelBarrio.Controls.Add(this.cmdModificarBarrio);
            this.panelBarrio.Location = new System.Drawing.Point(688, 50);
            this.panelBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelBarrio.Name = "panelBarrio";
            this.panelBarrio.Size = new System.Drawing.Size(148, 88);
            this.panelBarrio.TabIndex = 10;
            this.panelBarrio.Visible = false;
            // 
            // cmdEliminarBarrio
            // 
            this.cmdEliminarBarrio.Location = new System.Drawing.Point(4, 47);
            this.cmdEliminarBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminarBarrio.Name = "cmdEliminarBarrio";
            this.cmdEliminarBarrio.Size = new System.Drawing.Size(135, 30);
            this.cmdEliminarBarrio.TabIndex = 13;
            this.cmdEliminarBarrio.Text = "Eliminar";
            this.cmdEliminarBarrio.UseVisualStyleBackColor = true;
            this.cmdEliminarBarrio.Click += new System.EventHandler(this.cmdEliminarBarrio_Click);
            // 
            // cmdModificarBarrio
            // 
            this.cmdModificarBarrio.Location = new System.Drawing.Point(4, 11);
            this.cmdModificarBarrio.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdModificarBarrio.Name = "cmdModificarBarrio";
            this.cmdModificarBarrio.Size = new System.Drawing.Size(135, 30);
            this.cmdModificarBarrio.TabIndex = 12;
            this.cmdModificarBarrio.Text = "Modificar";
            this.cmdModificarBarrio.UseVisualStyleBackColor = true;
            this.cmdModificarBarrio.Click += new System.EventHandler(this.cmdModificarBarrio_Click);
            // 
            // panelActividad
            // 
            this.panelActividad.Controls.Add(this.cmdEliminarActividad);
            this.panelActividad.Controls.Add(this.cmdModificarActividad);
            this.panelActividad.Location = new System.Drawing.Point(519, 50);
            this.panelActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelActividad.Name = "panelActividad";
            this.panelActividad.Size = new System.Drawing.Size(148, 88);
            this.panelActividad.TabIndex = 9;
            this.panelActividad.Visible = false;
            // 
            // cmdEliminarActividad
            // 
            this.cmdEliminarActividad.Location = new System.Drawing.Point(4, 45);
            this.cmdEliminarActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdEliminarActividad.Name = "cmdEliminarActividad";
            this.cmdEliminarActividad.Size = new System.Drawing.Size(135, 30);
            this.cmdEliminarActividad.TabIndex = 14;
            this.cmdEliminarActividad.Text = "Eliminar";
            this.cmdEliminarActividad.UseVisualStyleBackColor = true;
            this.cmdEliminarActividad.Click += new System.EventHandler(this.cmdEliminarActividad_Click);
            // 
            // cmdModificarActividad
            // 
            this.cmdModificarActividad.Location = new System.Drawing.Point(4, 9);
            this.cmdModificarActividad.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdModificarActividad.Name = "cmdModificarActividad";
            this.cmdModificarActividad.Size = new System.Drawing.Size(135, 30);
            this.cmdModificarActividad.TabIndex = 11;
            this.cmdModificarActividad.Text = "Modificar";
            this.cmdModificarActividad.UseVisualStyleBackColor = true;
            this.cmdModificarActividad.Click += new System.EventHandler(this.cmdModificarActividad_Click);
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.cmdModificar);
            this.panelCliente.Controls.Add(this.cmdBaja);
            this.panelCliente.Controls.Add(this.cmdNuevoCliente);
            this.panelCliente.Location = new System.Drawing.Point(181, 50);
            this.panelCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(148, 114);
            this.panelCliente.TabIndex = 16;
            this.panelCliente.Visible = false;
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(4, 81);
            this.cmdModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(135, 30);
            this.cmdModificar.TabIndex = 15;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdBaja
            // 
            this.cmdBaja.Location = new System.Drawing.Point(4, 45);
            this.cmdBaja.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdBaja.Name = "cmdBaja";
            this.cmdBaja.Size = new System.Drawing.Size(135, 30);
            this.cmdBaja.TabIndex = 14;
            this.cmdBaja.Text = "Baja";
            this.cmdBaja.UseVisualStyleBackColor = true;
            this.cmdBaja.Click += new System.EventHandler(this.cmdBaja_Click);
            // 
            // cmdNuevoCliente
            // 
            this.cmdNuevoCliente.Location = new System.Drawing.Point(4, 9);
            this.cmdNuevoCliente.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdNuevoCliente.Name = "cmdNuevoCliente";
            this.cmdNuevoCliente.Size = new System.Drawing.Size(135, 30);
            this.cmdNuevoCliente.TabIndex = 11;
            this.cmdNuevoCliente.Text = "Alta";
            this.cmdNuevoCliente.UseVisualStyleBackColor = true;
            this.cmdNuevoCliente.Click += new System.EventHandler(this.cmdNuevoCliente_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cmdCerrar.Location = new System.Drawing.Point(884, 222);
            this.cmdCerrar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(164, 30);
            this.cmdCerrar.TabIndex = 14;
            this.cmdCerrar.Text = "Cerrar sesion";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1063, 263);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.mrcLinea2);
            this.Font = new System.Drawing.Font("Lucida Sans Typewriter", 8.25F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmPrincipal";
            this.ShowIcon = false;
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pMenu.ResumeLayout(false);
            this.panelProfesor.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelBarrio.ResumeLayout(false);
            this.panelActividad.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCliente;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdActividad;
        private System.Windows.Forms.Button cmdAcceso;
        private System.Windows.Forms.Button cmdBarrio;
        private System.Windows.Forms.GroupBox mrcLinea2;
        private System.Windows.Forms.Panel pMenu;
        private System.Windows.Forms.Panel panelActividad;
        private System.Windows.Forms.Button cmdEliminarActividad;
        private System.Windows.Forms.Button cmdModificarActividad;
        private System.Windows.Forms.Panel panelBarrio;
        private System.Windows.Forms.Button cmdEliminarBarrio;
        private System.Windows.Forms.Button cmdModificarBarrio;
        private System.Windows.Forms.Button cmdCerrar;
        private System.Windows.Forms.Panel panelConsulta;
        private System.Windows.Forms.Button cmdConsultaBarrio;
        private System.Windows.Forms.Button cmdConsultaActividad;
        private System.Windows.Forms.Panel panelCliente;
        private System.Windows.Forms.Button cmdModificar;
        private System.Windows.Forms.Button cmdBaja;
        private System.Windows.Forms.Button cmdNuevoCliente;
        private System.Windows.Forms.Button cmdProfesor;
        private System.Windows.Forms.Panel panelProfesor;
        private System.Windows.Forms.Button cmdModificarProfe;
        private System.Windows.Forms.Button cmdAltaProfe;
        private System.Windows.Forms.Button cmdEliminarProfe;
    }
}