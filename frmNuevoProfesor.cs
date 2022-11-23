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
    public partial class frmNuevoProfesor : Form
    {
        public frmNuevoProfesor()
        {
            InitializeComponent();
        }

        private void cmdCargar_Click(object sender, EventArgs e)
        {
            Int32 varDniProfesor = Convert.ToInt32(txtDni.Text);

            clsProfesor objBuscar = new clsProfesor();

            objBuscar.Buscar(varDniProfesor);

            if (objBuscar.Dni == varDniProfesor)
            {
                MessageBox.Show("Profesor ya registrado en la base de datos");
            }
            else
            {
                clsProfesor objCargar = new clsProfesor();

                objCargar.Nombre = txtNombre.Text;
                objCargar.Apellido = txtApellido.Text;
                objCargar.Dni = Convert.ToInt32(txtDni.Text);
                objCargar.Telefono = Convert.ToInt32(txtTelefono.Text);
                objCargar.Actividades = Convert.ToInt32(lstActividades.SelectedValue);
                objCargar.Sexo = Convert.ToString(lstSexo.SelectedItem);
                objCargar.Correo = txtCorreo.Text;

                

                objCargar.Agregar();
                
            }
        }

        private void lstActividades_SelectedIndexChanged(object sender, EventArgs e)
        {
            Check();
        }

        private void frmNuevoProfesor_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();
            objListarActividad.Listar(lstActividades);
            
            lstActividades.SelectedIndex = -1;

            
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {

        }

        private void cmdCargar_Click_1(object sender, EventArgs e)
        {
            Int32 varDniProfesor = Convert.ToInt32(txtDni.Text);

            clsProfesor objBuscar = new clsProfesor();

            objBuscar.Buscar(varDniProfesor);

            if (objBuscar.Dni == varDniProfesor)
            {
                MessageBox.Show("Profesor ya registrado en la base de datos");
            }
            else
            {
                clsProfesor objCargar = new clsProfesor();

                objCargar.Nombre = txtNombre.Text;
                objCargar.Apellido = txtApellido.Text;
                objCargar.Dni = Convert.ToInt32(txtDni.Text);
                objCargar.Telefono = Convert.ToInt32(txtTelefono.Text);
                objCargar.Actividades = Convert.ToInt32(lstActividades.SelectedValue);
                objCargar.Sexo = Convert.ToString(lstSexo.SelectedItem);
                objCargar.Correo = txtCorreo.Text;



                objCargar.Agregar();
                Limpiar();

            }
        }
        public void Limpiar()
        {
            txtApellido.Text = "";
            txtNombre.Text = "";
            txtCorreo.Text = "";
            txtDni.Text = "";
            lstActividades.SelectedIndex = -1;
            lstSexo.SelectedIndex = -1;
        }
        public void Check()
        {
            if (txtNombre.Text != "" & txtApellido.Text != "" &  lstSexo.SelectedIndex >= 0 & lstActividades.SelectedIndex >= 0 & txtDni.Text != "" & txtCorreo.Text != "" & txtTelefono.Text != "")
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

        private void cmdVolver_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
