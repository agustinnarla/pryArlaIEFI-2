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
    public partial class frmModificarBarrio : Form
    {
        public frmModificarBarrio()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            string varBuscarBarrio = lstBarrio.Text;
            clsBarrio objBuscar = new clsBarrio();

            objBuscar.Buscar(varBuscarBarrio);
            if (objBuscar.Detalle != varBuscarBarrio)
            {
                MessageBox.Show("El Barrio no se encuentra en la base de datos");
            }
            else
            {
                
                lblCodigo.Text = Convert.ToString(objBuscar.Codigo);
                txtBarrio.Text = objBuscar.Detalle;
                cmdModificar.Enabled = true;
                txtBarrio.Enabled = true;
            }
        }

        private void frmModificarBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio objListarBarrio = new clsBarrio();
            objListarBarrio.Listar(lstBarrio);

            lstBarrio.SelectedIndex = -1;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            clsBarrio objModificar = new clsBarrio();

            int parDetalle = Convert.ToInt32(lblCodigo.Text);

            objModificar.Detalle = txtBarrio.Text;

            objModificar.Modificar(parDetalle);
            Limpiar();


        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBarrio.SelectedIndex >= 0)
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
            if (txtBarrio.Text != "" )
            {
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdModificar.Enabled = false;
            }
        }

        private void txtBarrio_TextChanged(object sender, EventArgs e)
        {
            Check();
        }
        private void Limpiar()
        {
            txtBarrio.Text = "";
            lblCodigo.Text = "-";
            lstBarrio.SelectedIndex = -1;
        }
    }
}
