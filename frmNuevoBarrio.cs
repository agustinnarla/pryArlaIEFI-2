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
    public partial class frmNuevoBarrio : Form
    {
        public frmNuevoBarrio()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string varNombreBarrio = txtNombreBarrio.Text;
            clsBarrio objBuscar = new clsBarrio();
            objBuscar.Buscar(varNombreBarrio);

            if (objBuscar.Detalle == varNombreBarrio)
            {
                MessageBox.Show("El barrio ya está cargado en la base de datos");
            }
            else
            {
                clsBarrio objCargar = new clsBarrio();
                objCargar.Detalle = varNombreBarrio;
                objCargar.Agregar();
                Limpiar();

            }
        }

        private void frmNuevoBarrio_Load(object sender, EventArgs e)
        {

        }
        private void Limpiar()
        {
            txtNombreBarrio.Text = "";
        }

        private void txtNombreBarrio_TextChanged(object sender, EventArgs e)
        {
            if (txtNombreBarrio.Text != "")
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }
    }
}
