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
    public partial class frmEliminarProfesor : Form
    {
        public frmEliminarProfesor()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 varBuscarDni = Convert.ToInt32(txtDni.Text);

            clsProfesor objBuscar = new clsProfesor();

            objBuscar.Buscar(varBuscarDni);

            if (objBuscar.Dni != varBuscarDni)
            {
                MessageBox.Show("El profesor no se encuentra en la base de datos");
            }
            else
            {
                txtNombre.Text = objBuscar.Nombre;
                txtApellido.Text = objBuscar.Apellido;
                txtCorreo.Text = objBuscar.Correo;
                txtTelefono.Text = Convert.ToString(objBuscar.Telefono);
                lstActividades.SelectedValue = objBuscar.Actividades;
                txtSexo.Text = objBuscar.Sexo;

              

            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 varDni = Convert.ToInt32(txtDni.Text);
            clsProfesor objEliminar = new clsProfesor();
            objEliminar.Eliminar(varDni);
            Limpiar();
        }

        private void frmEliminarProfesor_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividades);

            lstActividades.SelectedIndex = -1;
        }
        public void Limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            lstActividades.SelectedIndex = -1;
            txtSexo.Text = "";
            txtTelefono.Text = "";
        }
        private void txtDni_TextChanged_1(object sender, EventArgs e)
        {
            if (txtDni.Text != "")
            {
                cmdConsultar.Enabled = true;

            }
            else
            {
                cmdConsultar.Enabled = false;
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
