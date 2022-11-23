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

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            Int32 varDniCliente = Convert.ToInt32(txtDni.Text);
            clsCliente objBuscar = new clsCliente();
            objBuscar.Buscar(varDniCliente);

            if (objBuscar.Dni == varDniCliente)
            {
                MessageBox.Show("El cliente ya se encuentra en la base de datos");
            }
            else
            {
                clsCliente objCargar = new clsCliente();
                objCargar.Nombre = txtNombre.Text;
                objCargar.Apellido = txtApellido.Text;
                objCargar.Dni = Convert.ToInt32(txtDni.Text);
                objCargar.Telefono = Convert.ToInt32(txtTelefono.Text);
                objCargar.Actividades = Convert.ToInt32(lstActividades.SelectedValue);
                objCargar.Barrio = Convert.ToInt32(lstBarrios.SelectedValue);
                objCargar.Sexo = Convert.ToString(lstSexo.SelectedItem);
                objCargar.Correo = txtCorreo.Text;
                objCargar.Saldo = Convert.ToInt32(txtSaldo.Text);
                objCargar.Domicilio = txtDireccion.Text;
                objCargar.Dias = Convert.ToInt32(txtDias.Text);
                Limpiar();
                objCargar.Agregar();
            }
        }

        private void frmNuevoCliente_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividades);
            clsBarrio objListarBarrio = new clsBarrio();
            objListarBarrio.Listar(lstBarrios);

            lstActividades.SelectedIndex = -1;
            lstBarrios.SelectedIndex = -1;

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
        private void Check()
        {
            if (txtNombre.Text != "" & txtApellido.Text != "" & lstSexo.SelectedIndex >= 0 & lstActividades.SelectedIndex >= 0 & txtDni.Text != "" & txtCorreo.Text != "" & txtTelefono.Text != "" & txtDias.Text != "" & txtDireccion.Text != "" & lstBarrios.SelectedIndex >= 0 )
            {
                cmdCargar.Enabled = true;
            }
            else
            {
                cmdCargar.Enabled = false;
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

        private void lstActividades_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void lstSexo_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void txtCorreo_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
