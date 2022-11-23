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
    public partial class frmModificarProfesor : Form
    {
        public frmModificarProfesor()
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
                MessageBox.Show("El cliente no se encuentra en la base de datos");
            }
            else
            {
                Enabled();
                txtNombre.Text = objBuscar.Nombre;
                txtApellido.Text = objBuscar.Apellido;
                txtCorreo.Text = objBuscar.Correo;
                txtTelefono.Text = Convert.ToString(objBuscar.Telefono);
                lstActividades.SelectedValue = objBuscar.Actividades;
                lstSexo.SelectedItem = objBuscar.Sexo;
                cmdModificar.Enabled = true;

            }
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {
           
            clsProfesor objModificar = new clsProfesor();
            Int32 parDni = Convert.ToInt32(txtDni.Text);
            objModificar.Nombre = txtNombre.Text;
            objModificar.Apellido = txtApellido.Text;
            objModificar.Telefono = Convert.ToInt32(txtTelefono.Text);
            objModificar.Actividades = Convert.ToInt32(lstActividades.SelectedValue);
            objModificar.Correo = txtCorreo.Text;
            Limpiar();
            objModificar.Modificar(parDni);
        }

        private void frmModificarProfesor_Load(object sender, EventArgs e)
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
            lstSexo.SelectedIndex = -1;
            txtTelefono.Text = "";
        }
        public void Check()
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && lstSexo.SelectedIndex >= 0 && lstActividades.SelectedIndex >= 0 && txtDni.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "")
            {
                cmdModificar.Enabled = true;
            }
            else
            {
                cmdModificar.Enabled = false;
            }
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            Check();
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
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtCorreo.Enabled = false;
                txtTelefono.Enabled = false;
                lstActividades.Enabled = false;
            }
        }
        private void Enabled()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtTelefono.Enabled = true;
            lstActividades.Enabled = true;
            
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
