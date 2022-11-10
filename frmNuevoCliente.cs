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
    public partial class frmNuevoCliente : Form
    {
        public frmNuevoCliente()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdAgregarBarrio_Click(object sender, EventArgs e)
        {
            frmNuevoBarrio objNuevoBarrio = new frmNuevoBarrio();
            objNuevoBarrio.ShowDialog();
        }

        private void cmdAgregarActividad_Click(object sender, EventArgs e)
        {
            frmNuevaActividad objNuevaActividad = new frmNuevaActividad();
            objNuevaActividad.ShowDialog();
        }
    }
}
