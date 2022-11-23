using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Net.Http.Headers;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Drawing;
using System.IO;
//using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryArlaIEFI_2
{
    internal class clsActividad
    {
        private OleDbConnection objConexion = new OleDbConnection();

        private OleDbCommand objComando = new OleDbCommand();

        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BD_GimnasioFinal.accdb";

        private string varTabla = "Actividad";

        private string varDetalle;
        private Int32 varCodigo_Actividad;
        private Int32 varCodigo_Pofesor;

        public string Detalle
        {
            get { return varDetalle; }
            set { varDetalle = value; }
        }
        public Int32 Codigo_Actividad
        {
            get { return varCodigo_Actividad; }
            set { varCodigo_Actividad = value; }
        }
        public Int32 Codigo_Pofesor
        {
            get { return varCodigo_Pofesor; }
            set { varCodigo_Pofesor = value; }
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
                parLista.ValueMember = "Codigo_Actividad";

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
                string varSentenciaSql = "INSERT INTO Actividad ([Detalle],[Codigo_Profesor])" +
                    "VALUES ('" + varDetalle + "','" + varCodigo_Pofesor + "')";

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
        public void Eliminar(Int32 parCodigo_Actividad)
        {
            try
            {
                string varSentenciaSql = "DELETE FROM ACTIVIDAD WHERE (" + parCodigo_Actividad + "= [Codigo_Actividad])";
              
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
            catch (Exception Mensajito )
            {
                MessageBox.Show(Mensajito.Message);
                //MessageBox.Show("Los datos no pudieron borrarse");
            }
        }
        public void Modificar(string parActividad)
        {
            try
            {
                string varSentenciaSql = "UPDATE Actividad SET [Detalle]= '" + Detalle + "' WHERE [Codigo_Actividad] =" + parActividad + "";
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
                MessageBox.Show("Datos modificados con exito");

            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }
        }
        public void Buscar(string parNombreActividad)
        {

            try
            {
                //Conecto la base de datos
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                //El comando toma la conexion
                objComando.Connection = objConexion;
                //Este comando me trae la tabla del access
                objComando.CommandType = CommandType.TableDirect;
                //Selecciona la tabla
                objComando.CommandText = varTabla;
                //Devuelve los datos de la tabla
                OleDbDataReader Lector = objComando.ExecuteReader();
                //Si hay registros ingresa
                if (Lector.HasRows)
                {
                    while (Lector.Read())
                    {
                        if (Lector.GetString(2) == parNombreActividad)
                        {
                            Codigo_Actividad = Lector.GetInt32(0);
                            Codigo_Pofesor = Lector.GetInt32(1);
                            Detalle = Lector.GetString(2);
                        }
                    }
                }
                //Cierra la conexion
                objConexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
            }
        }
        public string BuscarActividad(Int32 parCodigoActividad)
        {
            try
            {
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                objComando.Connection = objConexion;
                objComando.CommandType = CommandType.TableDirect;
                objComando.CommandText = varTabla;
                OleDbDataReader objLector = objComando.ExecuteReader();
                string Actividad = "";
                if (objLector.HasRows)
                {
                    while (objLector.Read())
                    {
                        if (objLector.GetInt32(0) == parCodigoActividad)
                        {
                            Actividad = objLector.GetString(2);
                        }
                    }
                }
                objConexion.Close();
                return Actividad;
            }
            catch (Exception Mensajito)
            {
                return Mensajito.Message;
            }
        }
        

    }
    
}
