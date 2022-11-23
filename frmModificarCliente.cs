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
    public partial class frmModificarCliente : Form
    {
        public frmModificarCliente()
        {
            InitializeComponent();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            Int32 varBuscarDni = Convert.ToInt32(txtDni.Text);
            clsCliente objBuscar = new clsCliente();
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
                txtDireccion.Text = objBuscar.Domicilio;
                txtSaldo.Text = Convert.ToString(objBuscar.Saldo);
                txtTelefono.Text = Convert.ToString(objBuscar.Telefono);
                lstActividades.SelectedValue = objBuscar.Actividades;
                lstBarrios.SelectedValue = objBuscar.Barrio;
                txtDias.Text = Convert.ToString(objBuscar.Dias);
                lstSexo.SelectedItem = objBuscar.Sexo;
                cmdModificar.Enabled = true;
                
            }
        }

        private void frmModificarCliente_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividades);
            clsBarrio objListarBarrio = new clsBarrio();
            objListarBarrio.Listar(lstBarrios);

            lstActividades.SelectedIndex = -1;
            lstBarrios.SelectedIndex = -1;
        }

        private void cmdModificar_Click(object sender, EventArgs e)
        {

            clsCliente objModificar = new clsCliente();
            Int32 parDni = Convert.ToInt32(txtDni.Text);
            objModificar.Nombre = txtNombre.Text;
            objModificar.Apellido = txtApellido.Text;
            objModificar.Telefono = Convert.ToInt32(txtTelefono.Text);
            objModificar.Actividades = Convert.ToInt32(lstActividades.SelectedValue);
            objModificar.Barrio = Convert.ToInt32(lstBarrios.SelectedValue);
            objModificar.Correo = txtCorreo.Text;
            objModificar.Saldo = Convert.ToInt32(txtSaldo.Text);
            objModificar.Domicilio = txtDireccion.Text;
            objModificar.Dias = Convert.ToInt32(txtDias.Text);
            Limpiar();
            objModificar.Modificar(parDni);
            
        }
        private void Check()
        {
            if (txtNombre.Text != "" && txtApellido.Text != "" && lstSexo.SelectedIndex >= 0 && lstActividades.SelectedIndex >= 0 && txtDni.Text != "" && txtCorreo.Text != "" && txtTelefono.Text != "" && txtDias.Text != "" && txtDireccion.Text != "" && txtSaldo.Text != "" && lstBarrios.SelectedIndex >= 0)
            {
                cmdModificar.Enabled = true;
               

            }
            else
            {
               
            }
        }
        private void Enabled()
        {
            txtNombre.Enabled = true;
            txtApellido.Enabled = true;
            txtCorreo.Enabled = true;
            txtDireccion.Enabled = true;
            txtSaldo.Enabled = true;
            txtTelefono.Enabled = true;
            lstActividades.Enabled = true;
            lstBarrios.Enabled = true;
            txtDias.Enabled = true;
            lstSexo.Enabled = true;
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            Check();
        }



        private void lstActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }


        private void lstSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
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
            }
        }
        private void Limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            lstActividades.SelectedIndex = -1;
            lstSexo.SelectedIndex = -1;
            lstBarrios.SelectedIndex = -1;
            txtDias.Text = "";
            txtDireccion.Text = "";
            txtSaldo.Text = "";
            txtTelefono.Text = "";
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
