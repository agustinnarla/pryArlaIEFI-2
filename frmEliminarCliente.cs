using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaIEFI_2
{
    public partial class frmEliminarCliente : Form
    {
        public frmEliminarCliente()
        {
            InitializeComponent();
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
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
                cmdEliminar.Enabled = true;
                txtNombre.Text = objBuscar.Nombre;
                txtApellido.Text = objBuscar.Apellido;
                txtCorreo.Text = objBuscar.Correo;
                txtDireccion.Text = objBuscar.Domicilio;
                txtSaldo.Text = Convert.ToString(objBuscar.Saldo);
                txtTelefono.Text = Convert.ToString(objBuscar.Telefono);
                lstActividades.SelectedValue = objBuscar.Actividades;
                lstBarrios.SelectedValue = objBuscar.Barrio;
                txtSexo.Text = objBuscar.Sexo;
                txtDias.Text = Convert.ToString(objBuscar.Dias);

            }
        }

        private void cmdEliminar_Click(object sender, EventArgs e)
        {
            Int32 varDni = Convert.ToInt32(txtDni.Text);
            clsCliente objEliminar = new clsCliente();
            objEliminar.Eliminar(varDni);
            Limpiar();
            
        }

        private void frmEliminarCliente_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividades);
            clsBarrio objListarBarrio = new clsBarrio();
            objListarBarrio.Listar(lstBarrios);

            lstActividades.SelectedIndex = -1;
            lstBarrios.SelectedIndex = -1;

        }
       
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            
        }



        private void lstActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
        }


        private void lstSexo_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void txtDias_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void lstBarrios_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void txtSaldo_TextChanged(object sender, EventArgs e)
        {
            
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
            txtSexo.Text = "";
            lstBarrios.SelectedIndex = -1;
            txtDias.Text = "";
            txtDireccion.Text = "";
            txtSaldo.Text = "";
            txtTelefono.Text = "";
        }
    }
}
