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
    public partial class frmEliminarActividad : Form
    {
        public frmEliminarActividad()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEliminarActividad_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividad);

            lstActividad.SelectedIndex = -1;
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string varBuscarActividad = lstActividad.Text;
            clsActividad objBuscar = new clsActividad();

            objBuscar.Buscar(varBuscarActividad);

            if (objBuscar.Detalle != varBuscarActividad)
            {
                MessageBox.Show("La actividad no se encuentra en la base de datos");
            }
            else
            {
                lblCodigo.Text = Convert.ToString(objBuscar.Codigo_Actividad);
                cmdEliminar.Enabled = true;
            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {

            int parCodigo_Actividad = Convert.ToInt32(lblCodigo.Text);

            clsActividad objEliminar = new clsActividad();
            objEliminar.Eliminar(parCodigo_Actividad);
            Limpiar();
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividad.SelectedIndex >= 0)
            {
                cmdConsultar.Enabled = true;
            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }
        private void Limpiar()
        {
            
            lblCodigo.Text = "-";
            lstActividad.SelectedIndex = -1;
            
        }
    }
}
