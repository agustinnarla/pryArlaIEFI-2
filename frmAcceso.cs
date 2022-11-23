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
    public partial class frmAcceso : Form
    {
        public frmAcceso()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
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
                txtNombre.Text = objBuscar.Nombre;
                txtApellido.Text = objBuscar.Apellido;
                txtSaldo.Text = Convert.ToString(objBuscar.Saldo);
                txtDias.Text = Convert.ToString(objBuscar.Dias);

                if (Convert.ToInt32(txtSaldo.Text) < 0)
                {
                    txtDetalle.Text = "ACCESO DENAGADO; DEBE CUOTA";
                    txtDetalle.BackColor = Color.LightCoral;
                }
                else
                {
                    txtDetalle.Text = "ACCESO ACEPTADO";
                    txtDetalle.BackColor = Color.LightGreen;
                }
                
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
