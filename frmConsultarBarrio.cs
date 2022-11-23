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
    public partial class frmConsultarBarrio : Form
    {
        public frmConsultarBarrio()
        {
            InitializeComponent();
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 parCodigoBarrio = Convert.ToInt32(lstBarrio.SelectedValue);

            clsCliente objListarBarrio = new clsCliente();
            objListarBarrio.ListarPorBarrio(grlPrincipalBarrio, parCodigoBarrio);
           
        }

        private void frmConsultarBarrio_Load(object sender, EventArgs e)
        {
            clsBarrio Barrios = new clsBarrio();

            Barrios.Listar(lstBarrio);

            lstBarrio.SelectedIndex = -1;
        }

        private void lstBarrio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstBarrio.SelectedIndex >= 0)
            {
                cmdListar.Enabled = true;
            }
            else
            {
                cmdListar.Enabled = false;
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
