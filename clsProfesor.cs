using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryArlaIEFI_2
{
    internal class clsProfesor
    {
        private OleDbConnection objConexion = new OleDbConnection();

        private OleDbCommand objComando = new OleDbCommand();

        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BD_GimnasioFinal.accdb";

        private string varTabla = "Profesor";

        private string varNombre;
        private string varApellido;
        private Int32 varDni;
        private string varSexo;
        private Int32 varActividades;
        private string varCorreo;
        private Int32 varCodigo_Profesor;
        private Int32 varTelefono;

        public string Nombre
        {
            get { return varNombre; }
            set { varNombre = value; }
        }
        public string Apellido
        {
            get { return varApellido; }
            set { varApellido = value; }
        }
        public Int32 Dni
        {
            get { return varDni; }
            set { varDni = value; }
        }

        public string Sexo
        {
            get { return varSexo; }
            set { varSexo = value; }
        }
        public Int32 Actividades
        {
            get { return varActividades; }
            set { varActividades = value; }
        }
        public string Correo
        {
            get { return varCorreo; }
            set { varCorreo = value; }
        }
        public Int32 Codigo
        {
            get { return varCodigo_Profesor; }
            set { varCodigo_Profesor = value; }
        }
        public Int32 Telefono
        {
            get { return varTelefono; }
            set { varTelefono = value; }
        }

        public void Agregar()
        {
            try
            {
                

                string varSentenciaSql = "INSERT INTO Profesor ([NOMBRE], [APELLIDO], [DNI], [SEXO], [TELEFONO], [CODIGO_ACTIVIDAD], [EMAIL])" +
                   "VALUES ('" + Nombre + "','" + Apellido + "','" + Dni + "','" + Sexo + "','" + Telefono + "','" + Actividades + "','" +Correo + "')";


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
                OleDbDataReader objLector = objComando.ExecuteReader();
                //Si hay registros ingresa
                if (objLector.HasRows)
                {
                    while (objLector.Read())
                    {
                        if (objLector.GetInt32(7) == parDni)
                        {
                            varCodigo_Profesor = objLector.GetInt32(0);
                            varNombre = objLector.GetString(1);
                            varApellido = objLector.GetString(2);
                            varTelefono = objLector.GetInt32(3);
                            varCorreo = objLector.GetString(4);
                            varActividades = objLector.GetInt32(5);
                            varSexo = objLector.GetString(6);
                            varDni = objLector.GetInt32(7);
                           
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
        public void Eliminar(Int32 parDni)
        {
            try
            {
                string varSentenciaSql = "DELETE FROM PROFESOR WHERE (" + parDni + "= [Dni])";
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
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
            }
        }
        public void Modificar(Int32 parDNI)
        {
            try
            {
                string varSentenciaSql = "UPDATE Profesor SET [NOMBRE]= '" + varNombre + "', [APELLIDO]='" + varApellido + "', [SEXO]='" + varSexo + "', [TELEFONO]=" + varTelefono + 
                    ", [CODIGO_ACTIVIDAD]=" + varActividades +  ",[EMAIL]='" + varCorreo + "' WHERE [DNI] =" + parDNI + "";
                //Conecto la base de datos
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                //El comando toma la conexion
                objComando.Connection = objConexion;
                //
                objComando.CommandType = CommandType.Text;
                objComando.CommandText = varSentenciaSql;
                //Modifica los datos de la tabla
                objComando.ExecuteNonQuery();
                //Cierra la conexion
                objConexion.Close();
                MessageBox.Show("Los datos se modificaron con exito");
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
            }
        }
        public string BuscarProfesor(Int32 parCodigoProfe)
        {
            try
            {
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                objComando.Connection = objConexion;
                objComando.CommandType = CommandType.TableDirect;
                objComando.CommandText = varTabla;
                OleDbDataReader objLector = objComando.ExecuteReader();
                string Profesor = "";
                if (objLector.HasRows)
                {
                    while (objLector.Read())
                    {
                        if (objLector.GetInt32(0) == parCodigoProfe)
                        {
                            Profesor = objLector.GetString(1);
                        }
                    }
                }
                objConexion.Close();
                return Profesor;
            }
            catch (Exception Mensajito)
            {
                return Mensajito.Message;
            }
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
                parLista.DisplayMember = "Nombre";
                parLista.ValueMember = "Codigo_Profesor";

                objConexion.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }

        }
    }
}
