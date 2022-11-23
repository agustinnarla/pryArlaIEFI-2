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
    public partial class frmNuevaActividad : Form
    {
        public frmNuevaActividad()
        {
            InitializeComponent();
        }

        private void cmdSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            string varNombreActividad = txtNombreActividad.Text;

            clsActividad objBuscar = new clsActividad();

            objBuscar.Buscar(varNombreActividad);

            if (objBuscar.Detalle == varNombreActividad)
            {
                MessageBox.Show("La actividad ya se encuentra registrada");
            }
            else
            {
                clsActividad objCarga = new clsActividad();

                objCarga.Detalle = txtNombreActividad.Text;
                objCarga.Codigo_Pofesor = Convert.ToInt32(lstProfesor.SelectedValue);
                Limpiar();
                objCarga.Agregar();

            }

        }

        private void frmNuevaActividad_Load(object sender, EventArgs e)
        {
            clsProfesor objListarProfesor = new clsProfesor();
            objListarProfesor.Listar(lstProfesor);
            lstProfesor.SelectedIndex = -1;
            
        }
        private void Limpiar()
        {
            lstProfesor.SelectedIndex = -1;
            txtNombreActividad.Text = "";
        }
        private void Check()
        {
            if (txtNombreActividad.Text != "" && lstProfesor.SelectedIndex >= 0)
            {
                cmdCargar.Enabled = true;

            }
            else
            {
                cmdCargar.Enabled = false;
            }
        }

        private void txtNombreActividad_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstProfesor_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }
    }
}
