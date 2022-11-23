using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaIEFI_2
{
    internal class clsAcceso
    {
        private OleDbConnection objConexion = new OleDbConnection();

        private OleDbCommand objComando = new OleDbCommand();

        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BD_Gimnasio1.accdb";

        private string varTabla = "Acceso";

        private DateTime varFecha;
        private Int32 varDias;
        private Int32 varDni;

        public DateTime Fecha
        {
            get { return varFecha; }
            set { varFecha = value; }
        }
        public Int32 Dias
        {
            get { return varDias; }
            set { varDias = value; }

        }
        public Int32 Dni
        {
            get { return varDni; }
            set { varDni = value; }
        }

        public void Agregar()
        {
            try
            {
                string varSentenciaSql = "INSERT INTO Acceso ([DIAS], [DNI])" +
                    "VALUES ('" +  Dias + "','" + Dni + "')";

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
        public void Buscar(Int32 parDni)
        {
            //try
            //{
            //    //Conecto la base de datos
            //    objConexion.ConnectionString = varRuta;
            //    objConexion.Open();
            //    //El comando toma la conexion
            //    objComando.Connection = objConexion;
            //    //Este comando me trae la tabla del access
            //    objComando.CommandType = CommandType.TableDirect;
            //    //Selecciona la tabla
            //    objComando.CommandText = varTabla;
            //    //Devuelve los datos de la tabla
            //    OleDbDataReader objLector = objComando.ExecuteReader();
            //    //Si hay registros ingresa
            //    if (objLector.HasRows)
            //    {
            //        while (objLector.Read())
            //        {
            //            if (objLector.GetInt32(0) == parDni)
            //            {
            //                varFecha = objLector.GetDateTime(2);
            //                varDias = objLector.GetInt32(1);

            //            }
            //        }
            //    }
            //    //Cierra la conexion
            //    objConexion.Close();
            //}
            //catch (Exception Mensajito)
            //{
            //    MessageBox.Show(Mensajito.Message);
            //}
        }
    }
}
