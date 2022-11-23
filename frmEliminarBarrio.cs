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
    public partial class frmEliminarBarrio : Form
    {
        public frmEliminarBarrio()
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
               
                cmdEliminar.Enabled = true;

            }
        }

        private void frmEliminarBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio objListarBarrio = new clsBarrio();
            objListarBarrio.Listar(lstBarrio);

            lstBarrio.SelectedIndex = -1;
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            //lstBarrio.Refresh();
            int varCodigo_Barrio = Convert.ToInt32(lblCodigo.Text);

            clsBarrio objEliminar = new clsBarrio();
            objEliminar.Eliminar(varCodigo_Barrio);
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
        private void Limpiar()
        {
            lblCodigo.Text = "";
            lstBarrio.SelectedIndex = -1;
        }

        private void lstBarrio_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
