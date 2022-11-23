using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace pryArlaIEFI_2
{
    public partial class frmConsultaActividad : Form
    {
        public frmConsultaActividad()
        {
            InitializeComponent();
          
        }
        
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void cmdListar_Click(object sender, EventArgs e)
        {
            Int32 parCodigo_Actividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsCliente objListarActividad = new clsCliente();
            objListarActividad.ListarPorActividad(grlPrincipalActividad, parCodigo_Actividad);
           
        }

        private void frmConsultaActividad_Load(object sender, EventArgs e)
        {
            clsActividad objListarActividad = new clsActividad();

            objListarActividad.Listar(lstActividad);

            lstActividad.SelectedIndex = -1;
        }

        private void lstImprimir_Click(object sender, EventArgs e)
        {
            prtVentana.ShowDialog();
            //Asignamos impresora seleccionada 
            prtDocumento.PrinterSettings = prtVentana.PrinterSettings;
            prtDocumento.Print();
            MessageBox.Show("Archivo impreso");
        }

        private void lstExportar_Click(object sender, EventArgs e)
        {
            Int32 parCodigo_Actividad = Convert.ToInt32(lstActividad.SelectedValue);
            clsCliente objReporte = new clsCliente();
            objReporte.GenerarReporte(parCodigo_Actividad);
            MessageBox.Show("Reporte generado");
        }

        private void prtDocumento_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            clsCliente objImprimir = new clsCliente();

            objImprimir.ImprimirActividad(e);
        }

        private void lstActividad_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstActividad.SelectedIndex >= 0)
            {
                cmdListar.Enabled = true;
            }
            else
            {
                cmdListar.Enabled = false;
            }
        }

        private void cmdVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
