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
    public partial class frmActividad : Form
    {
        public frmActividad()
        {
            InitializeComponent();
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
            frmModificarActividad objModificarActividad = new frmModificarActividad();
            objModificarActividad.ShowDialog();
           
        }

        private void cmdBorrar_Click(object sender, EventArgs e)
        {
            frmEliminarActividad objEliminarActividad = new frmEliminarActividad();
            objEliminarActividad.ShowDialog();
            
        }
    }
}
