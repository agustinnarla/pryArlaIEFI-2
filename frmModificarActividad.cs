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
    public partial class frmModificarActividad : Form
    {
        public frmModificarActividad()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string varBuscarActividad = lstActividad.Text;
            clsActividad objBuscar = new clsActividad();

            objBuscar.Buscar(varBuscarActividad);
            if (objBuscar.Detalle != varBuscarActividad)
            {
                MessageBox.Show("La Actividad no se encuentra en la base de datos");
            }
            else
            {
                lblCodigo.Text = Convert.ToString(objBuscar.Codigo_Actividad);
                txtActividad.Text = objBuscar.Detalle;
                lstProfesor.SelectedValue = objBuscar.Codigo_Pofesor;
                cmdModificar.Enabled = true;
                txtActividad.Enabled = true;
                lstProfesor.Enabled = true;

            }
        }

        private void frmModificarActividad_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividad);
            clsProfesor objListarProfesor = new clsProfesor();
            objListarProfesor.Listar(lstProfesor);

            lstActividad.SelectedIndex = -1;
            lstProfesor.SelectedIndex = -1;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            clsActividad objModificar = new clsActividad();
            

            int varDetalle = Convert.ToInt32(lblCodigo.Text);

            objModificar.Detalle = txtActividad.Text;
            objModificar.Codigo_Pofesor = Convert.ToInt32(lstProfesor.SelectedValue);

            objModificar.Modificar(Convert.ToString(varDetalle));
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
        private void Check()
        {
            if (txtActividad.Text != "" && lstProfesor.SelectedIndex >= 0)
            {
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdModificar.Enabled = false;
            }
        }

        private void txtActividad_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }
        private void Limpiar()
        {
            txtActividad.Text = "";
            lblCodigo.Text = "-";
            lstActividad.SelectedIndex = -1;
            lstProfesor.SelectedIndex = -1;
        }

    }
}
