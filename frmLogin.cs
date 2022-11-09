using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaIEFI_2
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        string varUsuario;
        string varContraseña;

        private void lblAyuda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuario: admin \n Contraseña: 1809");
        }

        private void lblAyuda_MouseMove(object sender, MouseEventArgs e)
        {
            lblAyuda.ForeColor = Color.Blue;
        }

        private void lblAyuda_MouseLeave(object sender, EventArgs e)
        {
            lblAyuda.ForeColor = Color.Black;
        }

        private void cmdIngresar_Click(object sender, EventArgs e)
        {
            varUsuario = txtUsuario.Text;
            varContraseña = Convert.ToString(txtContraseña.Text);

            if (Convert.ToString(varContraseña) == "" || varUsuario == "")
            {
                MessageBox.Show("Porfavor complete los campos");
            }
            else
            {
                if (varUsuario != "admin" || varContraseña != "1809")
                {
                    MessageBox.Show("Usuario y/o contraseña incorrecto");

                }
                else
                {
                    frmPrincipal objPrincipal = new frmPrincipal();
                    objPrincipal.Show();
                    this.Hide();

                }
            }
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            if (txtContraseña.Text != "" & txtUsuario.Text != "")
            {
                cmdIngresar.Enabled = true;
            }
            else
            {
                cmdIngresar.Enabled = false;
            }

        }

        private void txtContraseña_TextChanged(object sender, EventArgs e)
        {

            if (txtContraseña.Text != "" & txtUsuario.Text != "")
            {
                cmdIngresar.Enabled = true;
            }
            else
            {
                cmdIngresar.Enabled = false;
            }
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            cmdIngresar.Enabled = false;
        }
        private void txtContraseña_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 48 & e.KeyChar <= 57))
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 & e.KeyChar <= 64) || (e.KeyChar >= 91 & e.KeyChar <= 96) || (e.KeyChar >= 123 & e.KeyChar <= 255))
            {
                e.Handled = true;
            }
        }
    }
}
