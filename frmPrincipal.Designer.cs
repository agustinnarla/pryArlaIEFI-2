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
            this.cmdCaja = new System.Windows.Forms.Button();
            this.cmdAcceso = new System.Windows.Forms.Button();
            this.cmdBarrio = new System.Windows.Forms.Button();
            this.mrcLinea2 = new System.Windows.Forms.GroupBox();
            this.pMenu = new System.Windows.Forms.Panel();
            this.panelActividad = new System.Windows.Forms.Panel();
            this.cmdEliminarActividad = new System.Windows.Forms.Button();
            this.cmdModificarActividad = new System.Windows.Forms.Button();
            this.panelBarrio = new System.Windows.Forms.Panel();
            this.cmdEliminarBarrio = new System.Windows.Forms.Button();
            this.cmdModificarBarrio = new System.Windows.Forms.Button();
            this.cmdCerrar = new System.Windows.Forms.Button();
            this.panelConsulta = new System.Windows.Forms.Panel();
            this.cmdConsultaBarrio = new System.Windows.Forms.Button();
            this.cmdConsultaActividad = new System.Windows.Forms.Button();
            this.panelCliente = new System.Windows.Forms.Panel();
            this.cmdBaja = new System.Windows.Forms.Button();
            this.cmdNuevoCliente = new System.Windows.Forms.Button();
            this.cmdModificar = new System.Windows.Forms.Button();
            this.cmdPlan = new System.Windows.Forms.Button();
            this.panelPlan = new System.Windows.Forms.Panel();
            this.cmdMostrar = new System.Windows.Forms.Button();
            this.cmdCargar = new System.Windows.Forms.Button();
            this.mrcLinea1 = new System.Windows.Forms.GroupBox();
            this.pMenu.SuspendLayout();
            this.panelActividad.SuspendLayout();
            this.panelBarrio.SuspendLayout();
            this.panelConsulta.SuspendLayout();
            this.panelCliente.SuspendLayout();
            this.panelPlan.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmdCliente
            // 
            this.cmdCliente.Location = new System.Drawing.Point(58, 68);
            this.cmdCliente.Name = "cmdCliente";
            this.cmdCliente.Size = new System.Drawing.Size(141, 33);
            this.cmdCliente.TabIndex = 0;
            this.cmdCliente.Text = "Clientes";
            this.cmdCliente.UseVisualStyleBackColor = true;
            this.cmdCliente.Click += new System.EventHandler(this.cmdCliente_Click);
            // 
            // cmdConsultar
            // 
            this.cmdConsultar.Location = new System.Drawing.Point(58, 109);
            this.cmdConsultar.Name = "cmdConsultar";
            this.cmdConsultar.Size = new System.Drawing.Size(141, 33);
            this.cmdConsultar.TabIndex = 1;
            this.cmdConsultar.Text = "Consultar";
            this.cmdConsultar.UseVisualStyleBackColor = true;
            this.cmdConsultar.Click += new System.EventHandler(this.cmdConsultar_Click);
            this.cmdConsultar.MouseEnter += new System.EventHandler(this.cmdActivar_MouseEnter);
            this.cmdConsultar.MouseLeave += new System.EventHandler(this.cmdActivar_MouseLeave);
            // 
            // cmdActividad
            // 
            this.cmdActividad.Location = new System.Drawing.Point(58, 148);
            this.cmdActividad.Name = "cmdActividad";
            this.cmdActividad.Size = new System.Drawing.Size(141, 33);
            this.cmdActividad.TabIndex = 2;
            this.cmdActividad.Text = "Actividad";
            this.cmdActividad.UseVisualStyleBackColor = true;
            this.cmdActividad.Click += new System.EventHandler(this.cmdActividad_Click);
            this.cmdActividad.MouseEnter += new System.EventHandler(this.cmdActivar_MouseEnter);
            this.cmdActividad.MouseLeave += new System.EventHandler(this.cmdActivar_MouseLeave);
            // 
            // cmdCaja
            // 
            this.cmdCaja.Location = new System.Drawing.Point(58, 226);
            this.cmdCaja.Name = "cmdCaja";
            this.cmdCaja.Size = new System.Drawing.Size(141, 33);
            this.cmdCaja.TabIndex = 3;
            this.cmdCaja.Text = "Caja";
            this.cmdCaja.UseVisualStyleBackColor = true;
            this.cmdCaja.Click += new System.EventHandler(this.cmdCaja_Click);
            // 
            // cmdAcceso
            // 
            this.cmdAcceso.Location = new System.Drawing.Point(58, 29);
            this.cmdAcceso.Name = "cmdAcceso";
            this.cmdAcceso.Size = new System.Drawing.Size(141, 33);
            this.cmdAcceso.TabIndex = 4;
            this.cmdAcceso.Text = "Acceso";
            this.cmdAcceso.UseVisualStyleBackColor = true;
            this.cmdAcceso.Click += new System.EventHandler(this.cmdAcceso_Click);
            // 
            // cmdBarrio
            // 
            this.cmdBarrio.Location = new System.Drawing.Point(58, 187);
            this.cmdBarrio.Name = "cmdBarrio";
            this.cmdBarrio.Size = new System.Drawing.Size(141, 33);
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
            this.mrcLinea2.Location = new System.Drawing.Point(12, 348);
            this.mrcLinea2.Name = "mrcLinea2";
            this.mrcLinea2.Size = new System.Drawing.Size(273, 10);
            this.mrcLinea2.TabIndex = 6;
            this.mrcLinea2.TabStop = false;
            // 
            // pMenu
            // 
            this.pMenu.Controls.Add(this.cmdPlan);
            this.pMenu.Controls.Add(this.cmdBarrio);
            this.pMenu.Controls.Add(this.cmdAcceso);
            this.pMenu.Controls.Add(this.cmdCaja);
            this.pMenu.Controls.Add(this.cmdActividad);
            this.pMenu.Controls.Add(this.cmdConsultar);
            this.pMenu.Controls.Add(this.cmdCliente);
            this.pMenu.Location = new System.Drawing.Point(2, 6);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(282, 336);
            this.pMenu.TabIndex = 8;
            // 
            // panelActividad
            // 
            this.panelActividad.Controls.Add(this.cmdEliminarActividad);
            this.panelActividad.Controls.Add(this.cmdModificarActividad);
            this.panelActividad.Location = new System.Drawing.Point(324, 121);
            this.panelActividad.Name = "panelActividad";
            this.panelActividad.Size = new System.Drawing.Size(163, 93);
            this.panelActividad.TabIndex = 9;
            this.panelActividad.Visible = false;
            // 
            // cmdEliminarActividad
            // 
            this.cmdEliminarActividad.Location = new System.Drawing.Point(3, 49);
            this.cmdEliminarActividad.Name = "cmdEliminarActividad";
            this.cmdEliminarActividad.Size = new System.Drawing.Size(141, 33);
            this.cmdEliminarActividad.TabIndex = 14;
            this.cmdEliminarActividad.Text = "Eliminar";
            this.cmdEliminarActividad.UseVisualStyleBackColor = true;
            this.cmdEliminarActividad.Click += new System.EventHandler(this.cmdEliminarActividad_Click);
            // 
            // cmdModificarActividad
            // 
            this.cmdModificarActividad.Location = new System.Drawing.Point(3, 10);
            this.cmdModificarActividad.Name = "cmdModificarActividad";
            this.cmdModificarActividad.Size = new System.Drawing.Size(141, 33);
            this.cmdModificarActividad.TabIndex = 11;
            this.cmdModificarActividad.Text = "Modificar";
            this.cmdModificarActividad.UseVisualStyleBackColor = true;
            this.cmdModificarActividad.Click += new System.EventHandler(this.cmdModificarActividad_Click);
            // 
            // panelBarrio
            // 
            this.panelBarrio.Controls.Add(this.cmdEliminarBarrio);
            this.panelBarrio.Controls.Add(this.cmdModificarBarrio);
            this.panelBarrio.Location = new System.Drawing.Point(321, 183);
            this.panelBarrio.Name = "panelBarrio";
            this.panelBarrio.Size = new System.Drawing.Size(163, 101);
            this.panelBarrio.TabIndex = 10;
            this.panelBarrio.Visible = false;
            // 
            // cmdEliminarBarrio
            // 
            this.cmdEliminarBarrio.Location = new System.Drawing.Point(3, 51);
            this.cmdEliminarBarrio.Name = "cmdEliminarBarrio";
            this.cmdEliminarBarrio.Size = new System.Drawing.Size(141, 33);
            this.cmdEliminarBarrio.TabIndex = 13;
            this.cmdEliminarBarrio.Text = "Eliminar";
            this.cmdEliminarBarrio.UseVisualStyleBackColor = true;
            this.cmdEliminarBarrio.Click += new System.EventHandler(this.cmdEliminarBarrio_Click);
            // 
            // cmdModificarBarrio
            // 
            this.cmdModificarBarrio.Location = new System.Drawing.Point(3, 12);
            this.cmdModificarBarrio.Name = "cmdModificarBarrio";
            this.cmdModificarBarrio.Size = new System.Drawing.Size(141, 33);
            this.cmdModificarBarrio.TabIndex = 12;
            this.cmdModificarBarrio.Text = "Modificar";
            this.cmdModificarBarrio.UseVisualStyleBackColor = true;
            this.cmdModificarBarrio.Click += new System.EventHandler(this.cmdModificarBarrio_Click);
            // 
            // cmdCerrar
            // 
            this.cmdCerrar.Location = new System.Drawing.Point(324, 391);
            this.cmdCerrar.Name = "cmdCerrar";
            this.cmdCerrar.Size = new System.Drawing.Size(141, 33);
            this.cmdCerrar.TabIndex = 14;
            this.cmdCerrar.Text = "Cerrar sesion";
            this.cmdCerrar.UseVisualStyleBackColor = true;
            this.cmdCerrar.Click += new System.EventHandler(this.cmdCerrar_Click);
            // 
            // panelConsulta
            // 
            this.panelConsulta.Controls.Add(this.cmdConsultaBarrio);
            this.panelConsulta.Controls.Add(this.cmdConsultaActividad);
            this.panelConsulta.Location = new System.Drawing.Point(321, 113);
            this.panelConsulta.Name = "panelConsulta";
            this.panelConsulta.Size = new System.Drawing.Size(163, 93);
            this.panelConsulta.TabIndex = 15;
            this.panelConsulta.Visible = false;
            this.panelConsulta.Paint += new System.Windows.Forms.PaintEventHandler(this.panelConsulta_Paint);
            // 
            // cmdConsultaBarrio
            // 
            this.cmdConsultaBarrio.Location = new System.Drawing.Point(3, 49);
            this.cmdConsultaBarrio.Name = "cmdConsultaBarrio";
            this.cmdConsultaBarrio.Size = new System.Drawing.Size(141, 33);
            this.cmdConsultaBarrio.TabIndex = 14;
            this.cmdConsultaBarrio.Text = "Por Barrio";
            this.cmdConsultaBarrio.UseVisualStyleBackColor = true;
            // 
            // cmdConsultaActividad
            // 
            this.cmdConsultaActividad.Location = new System.Drawing.Point(3, 10);
            this.cmdConsultaActividad.Name = "cmdConsultaActividad";
            this.cmdConsultaActividad.Size = new System.Drawing.Size(141, 33);
            this.cmdConsultaActividad.TabIndex = 11;
            this.cmdConsultaActividad.Text = "Por Actividad";
            this.cmdConsultaActividad.UseVisualStyleBackColor = true;
            // 
            // panelCliente
            // 
            this.panelCliente.Controls.Add(this.cmdModificar);
            this.panelCliente.Controls.Add(this.cmdBaja);
            this.panelCliente.Controls.Add(this.cmdNuevoCliente);
            this.panelCliente.Location = new System.Drawing.Point(321, 74);
            this.panelCliente.Name = "panelCliente";
            this.panelCliente.Size = new System.Drawing.Size(163, 121);
            this.panelCliente.TabIndex = 16;
            this.panelCliente.Visible = false;
            // 
            // cmdBaja
            // 
            this.cmdBaja.Location = new System.Drawing.Point(3, 49);
            this.cmdBaja.Name = "cmdBaja";
            this.cmdBaja.Size = new System.Drawing.Size(141, 33);
            this.cmdBaja.TabIndex = 14;
            this.cmdBaja.Text = "Baja";
            this.cmdBaja.UseVisualStyleBackColor = true;
            this.cmdBaja.Click += new System.EventHandler(this.cmdBaja_Click);
            // 
            // cmdNuevoCliente
            // 
            this.cmdNuevoCliente.Location = new System.Drawing.Point(3, 10);
            this.cmdNuevoCliente.Name = "cmdNuevoCliente";
            this.cmdNuevoCliente.Size = new System.Drawing.Size(141, 33);
            this.cmdNuevoCliente.TabIndex = 11;
            this.cmdNuevoCliente.Text = "Alta";
            this.cmdNuevoCliente.UseVisualStyleBackColor = true;
            this.cmdNuevoCliente.Click += new System.EventHandler(this.cmdNuevoCliente_Click);
            // 
            // cmdModificar
            // 
            this.cmdModificar.Location = new System.Drawing.Point(3, 88);
            this.cmdModificar.Name = "cmdModificar";
            this.cmdModificar.Size = new System.Drawing.Size(141, 33);
            this.cmdModificar.TabIndex = 15;
            this.cmdModificar.Text = "Modificar";
            this.cmdModificar.UseVisualStyleBackColor = true;
            this.cmdModificar.Click += new System.EventHandler(this.cmdModificar_Click);
            // 
            // cmdPlan
            // 
            this.cmdPlan.Location = new System.Drawing.Point(58, 265);
            this.cmdPlan.Name = "cmdPlan";
            this.cmdPlan.Size = new System.Drawing.Size(141, 33);
            this.cmdPlan.TabIndex = 6;
            this.cmdPlan.Text = "Plan";
            this.cmdPlan.UseVisualStyleBackColor = true;
            this.cmdPlan.Click += new System.EventHandler(this.cmdPlan_Click);
            // 
            // panelPlan
            // 
            this.panelPlan.Controls.Add(this.cmdMostrar);
            this.panelPlan.Controls.Add(this.cmdCargar);
            this.panelPlan.Location = new System.Drawing.Point(321, 273);
            this.panelPlan.Name = "panelPlan";
            this.panelPlan.Size = new System.Drawing.Size(163, 101);
            this.panelPlan.TabIndex = 14;
            this.panelPlan.Visible = false;
            // 
            // cmdMostrar
            // 
            this.cmdMostrar.Location = new System.Drawing.Point(3, 51);
            this.cmdMostrar.Name = "cmdMostrar";
            this.cmdMostrar.Size = new System.Drawing.Size(141, 33);
            this.cmdMostrar.TabIndex = 13;
            this.cmdMostrar.Text = "Mostrar";
            this.cmdMostrar.UseVisualStyleBackColor = true;
            // 
            // cmdCargar
            // 
            this.cmdCargar.Location = new System.Drawing.Point(3, 12);
            this.cmdCargar.Name = "cmdCargar";
            this.cmdCargar.Size = new System.Drawing.Size(141, 33);
            this.cmdCargar.TabIndex = 12;
            this.cmdCargar.Text = "Cargar";
            this.cmdCargar.UseVisualStyleBackColor = true;
            // 
            // mrcLinea1
            // 
            this.mrcLinea1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.mrcLinea1.Location = new System.Drawing.Point(305, 6);
            this.mrcLinea1.Name = "mrcLinea1";
            this.mrcLinea1.Size = new System.Drawing.Size(10, 338);
            this.mrcLinea1.TabIndex = 7;
            this.mrcLinea1.TabStop = false;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 479);
            this.Controls.Add(this.panelPlan);
            this.Controls.Add(this.panelCliente);
            this.Controls.Add(this.panelConsulta);
            this.Controls.Add(this.cmdCerrar);
            this.Controls.Add(this.panelBarrio);
            this.Controls.Add(this.panelActividad);
            this.Controls.Add(this.pMenu);
            this.Controls.Add(this.mrcLinea1);
            this.Controls.Add(this.mrcLinea2);
            this.Name = "frmPrincipal";
            this.Text = "Principal";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.pMenu.ResumeLayout(false);
            this.panelActividad.ResumeLayout(false);
            this.panelBarrio.ResumeLayout(false);
            this.panelConsulta.ResumeLayout(false);
            this.panelCliente.ResumeLayout(false);
            this.panelPlan.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmdCliente;
        private System.Windows.Forms.Button cmdConsultar;
        private System.Windows.Forms.Button cmdActividad;
        private System.Windows.Forms.Button cmdCaja;
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
        private System.Windows.Forms.Button cmdPlan;
        private System.Windows.Forms.Panel panelPlan;
        private System.Windows.Forms.Button cmdMostrar;
        private System.Windows.Forms.Button cmdCargar;
        private System.Windows.Forms.GroupBox mrcLinea1;
    }
}