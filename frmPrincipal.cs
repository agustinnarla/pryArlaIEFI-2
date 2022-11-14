using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaIEFI_2
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }
        Panel p = new Panel();
 
        private void pickLinea_Click(object sender, EventArgs e)
        {
            //Pen lapiz = new Pen(Color.Orange);
            
        }

        private void cmdCliente_Click(object sender, EventArgs e)
        {
            if (!panelCliente.Visible)
            {
                panelBarrio.Visible = false;
                panelActividad.Visible = false;
                panelConsulta.Visible = false;
                panelCliente.Visible = true;
                panelProfesor.Visible = false;
                panelPlan.Visible = false;

            }
            else
            {
                panelCliente.Visible = false;
            }

        }

        private void cmdCaja_Click(object sender, EventArgs e)
        {
            frmCaja objCaja = new frmCaja();
            objCaja.ShowDialog();

        }
       
        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cmdActivar_MouseEnter(object sender, EventArgs e)
        {
            
            //Button cmdActivar = sender as Button;
            //pMenu.Controls.Add(p);
            //p.Location = new Point(cmdActivar.Location.X + 40 , cmdActivar.Location.Y);
        }

        private void cmdActivar_MouseLeave(object sender, EventArgs e)
        {
            //pMenu.Controls.Remove(p);
        }

        private void cmdActividad_Click(object sender, EventArgs e)
        {
            if (!panelActividad.Visible)
            {
                panelBarrio.Visible = false;
                panelActividad.Visible = true;
                panelConsulta.Visible = false;
                panelCliente.Visible = false;
                panelPlan.Visible = false;
                panelProfesor.Visible = false;

            }
            else
            {
                panelActividad.Visible = false;
            }
        }

        private void cmdBarrio_Click(object sender, EventArgs e)
        {
            if (!panelBarrio.Visible)
            {
                panelBarrio.Visible = true;
                panelActividad.Visible = false;
                panelConsulta.Visible = false;
                panelCliente.Visible = false;
                panelPlan.Visible = false;
                panelProfesor.Visible = false;

            }
            else
            {
                panelBarrio.Visible = false;
            }
        }

        private void cmdEliminarBarrio_Click(object sender, EventArgs e)
        {
            frmEliminarBarrio objEliminarBarrio = new frmEliminarBarrio();

            objEliminarBarrio.ShowDialog();
           
        }

        private void cmdCerrar_Click(object sender, EventArgs e)
        {
            frmLogin objLogin = new frmLogin();
            this.Close();
            objLogin.ShowDialog();
           
        }

        private void cmdModificarActividad_Click(object sender, EventArgs e)
        {
            frmModificarActividad objModificarActividad = new frmModificarActividad();
            objModificarActividad.ShowDialog();
           
        }

        private void cmdEliminarActividad_Click(object sender, EventArgs e)
        {
            frmEliminarActividad objEliminarActividad = new frmEliminarActividad();
            objEliminarActividad.ShowDialog();
            
        }

        private void cmdModificarBarrio_Click(object sender, EventArgs e)
        {
            frmModificarBarrio objModificarBarrio = new frmModificarBarrio();   
            objModificarBarrio.ShowDialog();
            
        }

        private void panelConsulta_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            if (!panelConsulta.Visible)
            {
                panelBarrio.Visible = false;
                panelActividad.Visible = false;
                panelConsulta.Visible = true;
                panelCliente.Visible = false;
                panelPlan.Visible = false;
                panelProfesor.Visible = false;

            }
            else
            {
                panelConsulta.Visible = false;
            }
        }

        private void cmdNuevoCliente_Click(object sender, EventArgs e)
        {
            frmNuevoCliente objNuevoCliente = new frmNuevoCliente();
            objNuevoCliente.ShowDialog();
        }

        private void cmdBaja_Click(object sender, EventArgs e)
        {
            frmEliminarCliente objEliminarCliente = new frmEliminarCliente();
            objEliminarCliente.ShowDialog();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            frmModificarCliente objModificarCliente = new frmModificarCliente();
            objModificarCliente.ShowDialog();
        }
        private void Limpiar()
        {
            panelBarrio.Visible = false;
            panelActividad.Visible = false;
            panelConsulta.Visible = false;
            panelCliente.Visible = false;
            panelPlan.Visible = false;
            panelProfesor.Visible = false;

        }

        private void cmdAcceso_Click(object sender, EventArgs e)
        {
            frmAcceso objAcceso = new frmAcceso();  
            objAcceso.ShowDialog();
        }

        private void cmdPlan_Click(object sender, EventArgs e)
        {
            if (!panelPlan.Visible)
            {
                panelBarrio.Visible = false;
                panelActividad.Visible = false;
                panelConsulta.Visible = false;
                panelCliente.Visible = false;
                panelPlan.Visible = true;
                panelProfesor.Visible = false;
            }
            else
            {
                panelPlan.Visible = false;
            }
        }

        private void cmdProfesor_Click(object sender, EventArgs e)
        {
            if (!panelProfesor.Visible)
            {
                panelBarrio.Visible = false;
                panelActividad.Visible = false;
                panelConsulta.Visible = false;
                panelCliente.Visible = false;
                panelPlan.Visible = false;
                panelProfesor.Visible = true;

            }
            else
            {
                panelProfesor.Visible = false;
            }
        }

        private void pMenu_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmdAltaProfe_Click(object sender, EventArgs e)
        {
            frmNuevoProfesor objNuevoProfesor = new frmNuevoProfesor();
            objNuevoProfesor.ShowDialog();
        }

        private void cdmEliminarProfe_Click(object sender, EventArgs e)
        {
            frmEliminarProfesor objEliminarProfesor  = new frmEliminarProfesor();
            objEliminarProfesor.ShowDialog();
        }

        private void cmdModificarPorfe_Click(object sender, EventArgs e)
        {
            frmModificarProfesor objModificarProfesor = new frmModificarProfesor();
            objModificarProfesor.ShowDialog();
        }

        private void cmdConsultaActividad_Click(object sender, EventArgs e)
        {
            frmConsultaActividad objConsultarActividad = new frmConsultaActividad();
            objConsultarActividad.ShowDialog();
        }

        private void cmdConsultaBarrio_Click(object sender, EventArgs e)
        {
            frmConsultarBarrio objConsultarBarrio = new frmConsultarBarrio();
            objConsultarBarrio.ShowDialog();
        }

        private void cmdConsultaProfe_Click(object sender, EventArgs e)
        {
            frmConsultarProfe objConsultarProfe = new frmConsultarProfe();
            objConsultarProfe.ShowDialog();
        }
    }
}
