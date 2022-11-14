using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaIEFI_2
{
    internal class clsBarrio
    {
        private OleDbConnection objConexion = new OleDbConnection();

        private OleDbCommand objComando = new OleDbCommand();

        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BD_Gimnasio1.accdb";

        private string varTabla = "Barrio";

        private string varDetalle;

        public string Detalle
        {
            get { return varDetalle; }
            set { varDetalle = value; }
        }

        public void Listar(ComboBox parLista)
        {
            //conectamos base de datos 
            try
            {
                objConexion.ConnectionString = varRuta;
                objConexion.Open();

                //toma la conexion 
                objComando.Connection = objConexion;
                //traemos la tabla 
                objComando.CommandType = CommandType.TableDirect;
                //selecciona 
                objComando.CommandText = varTabla;

                objAdaptador = new OleDbDataAdapter(objComando);

                DataSet ds = new DataSet();

                objAdaptador.Fill(ds, varTabla);
                parLista.DataSource = ds.Tables[varTabla];
                parLista.DisplayMember = "Detalle";
                parLista.ValueMember = "Codigo_Barrio";

                objConexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }

        }
        public void Agregar()
        {
            try
            {
                string varSentenciaSql = "INSERT INTO Barrio ([Detalle])" +
                    "VALUES ('" + varDetalle + "')";
                //Conecto la base de datos
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                //El comando toma la conexion
                objComando.Connection = objConexion;
                //comando me trae la tabla del access
                objComando.CommandType = CommandType.Text;
                //Selecciona la tabla
                objComando.CommandText = varSentenciaSql;
                objComando.ExecuteNonQuery();
                objConexion.Close();
                MessageBox.Show("Datos cargados con exito");
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }
        }
        public void Eliminar(Int32 parCodigo_Barrio)
        {
            try
            {
                string varSentenciaSql = "DELETE FROM BARRIO WHERE ('" + parCodigo_Barrio + "'= [Codigo_Barrio])";
                //Conecto la base de datos
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                //El comando toma la conexion
                objComando.Connection = objConexion;
                //comando me trae la tabla del access
                objComando.CommandType = CommandType.Text;
                //Selecciona la tabla
                objComando.CommandText = varSentenciaSql;
                objComando.ExecuteNonQuery();
                objConexion.Close();
                MessageBox.Show("Datos eliminados con exito");

            }
            catch (Exception)
            {
                MessageBox.Show("Los datos no pudieron borrarse");
            }
        }
    }
}
