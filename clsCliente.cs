using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pryArlaIEFI_2
{
    internal class clsCliente
    {
        private OleDbConnection objConexion = new OleDbConnection();

        private OleDbCommand objComando = new OleDbCommand();

        private OleDbDataAdapter objAdaptador = new OleDbDataAdapter();

        private string varRuta = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source= " + "BD_GimnasioFinal.accdb";

        private string varTabla = "Socio";

        private string varNombre;
        private string varApellido;
        private Int32 varDni;
        private string varSexo;
        private decimal varTelefono;
        private string varDomicilio;
        private Int32 varBarrio;
        private Int32 varActividades;
        private Int32 varSaldo;
        private string varCorreo;
        private Int32 varCliente;
        private Int32 varMonto;
        private Int32 varDias;
      
       

        //Get: Retorna lo de las variables
        //Set: Toma el valor y lo almacena
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
        public decimal Telefono
        {
            get { return varTelefono; }
            set { varTelefono = value; }
        }
        public string Domicilio
        {
            get { return varDomicilio; }
            set { varDomicilio = value; }
        }
        public Int32 Barrio
        {
            get { return varBarrio; }
            set { varBarrio = value; }
        }
        public Int32 Actividades
        {
            get { return varActividades; }
            set { varActividades = value; }
        }
        public Int32 Saldo
        {
            get { return varSaldo; }
            set { varSaldo = value; }
        }
        public string Correo
        {
            get { return varCorreo; }
            set { varCorreo = value; }
        }
        public Int32 Cliente
        {
            get { return varCliente; }
            set { varCliente = value; }
        }
        public Int32 Monto
        {
            get { return varMonto; }
            set { varMonto = value; }
        }
        public Int32 Dias
        {
            get { return varDias; }
            set { varDias = value; }
        }


        public void Agregar()
        {
            try
            {
                string varSentenciaSql = "INSERT INTO Socio ([NOMBRE], [APELLIDO], [DNI], [SEXO], [TELEFONO], [DIRECCION], [CODIGO_BARRIO], [CODIGO_ACTIVIDAD], [SALDO], [EMAIL], [Dias])" +
                    "VALUES ('" + Nombre + "','" + Apellido + "','" + Dni + "','" + Sexo + "','" + Telefono + "','" + Domicilio + "','" + Barrio + "','" + Actividades + "','" + Saldo + "','" + Correo + "','" + Dias +"')";

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
                        if (objLector.GetInt32(0) == parDni)
                        {
                            varDni = objLector.GetInt32(0);
                            varNombre = objLector.GetString(1);
                            varApellido = objLector.GetString(2);
                            varTelefono = objLector.GetInt32(3);
                            varCorreo = objLector.GetString(4);
                            varDomicilio = objLector.GetString(5);
                            varBarrio = objLector.GetInt32(6);
                            varActividades = objLector.GetInt32(7);
                            varSaldo = objLector.GetInt32(8);
                            varSexo = objLector.GetString(9);
                            varDias = objLector.GetInt32(10);

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
        public void ListarPorActividad(DataGridView grlPrincipalActividad, Int32 parCodigoActividad)
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
            OleDbDataReader objLector = objComando.ExecuteReader();

            grlPrincipalActividad.Rows.Clear();
            varCliente = 0;
            varMonto = 0;

            clsActividad objActividad = new clsActividad();

            string varNombreActividad = "";
            if (objLector.HasRows)
            {
                while (objLector.Read())
                {
                    if (objLector.GetInt32(7) == parCodigoActividad)
                    {
                        varNombreActividad = objActividad.BuscarActividad(objLector.GetInt32(7));
                        grlPrincipalActividad.Rows.Add(objLector.GetInt32(0), objLector.GetString(1), objLector.GetString(2), varNombreActividad);
                        varCliente++;
                    }
                }
            }
        }
        public void ListarPorBarrio(DataGridView grlPrincipalBarrio, Int32 parCodigoBarrio)
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
            OleDbDataReader Lector = objComando.ExecuteReader();
            grlPrincipalBarrio.Rows.Clear();
            varCliente = 0;
            varMonto = 0;

            clsBarrio Barrios = new clsBarrio();
            string NombreBarrio = "";
            if (Lector.HasRows)
            {
                while (Lector.Read())
                {
                    if (Lector.GetInt32(6) == parCodigoBarrio)
                    {
                        NombreBarrio = Barrios.BuscarCodigo(Lector.GetInt32(8));
                        grlPrincipalBarrio.Rows.Add(Lector.GetInt32(0), Lector.GetString(1), Lector.GetString(2), NombreBarrio);
                        varCliente++;
                    }
                }
            }
        }
        public void Eliminar(Int32 parDni)
        {
            try
            {
                string varSentenciaSql = "DELETE FROM SOCIO WHERE (" + parDni + "= [Dni])";
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
                string varSentenciaSql = "UPDATE Socio SET [NOMBRE]= '" + varNombre + "', [APELLIDO]='" + varApellido   + "', [TELEFONO]=" + varTelefono + ", [DIRECCION]='" + varDomicilio + "', [CODIGO_BARRIO]= " + varBarrio + 
                    ", [CODIGO_ACTIVIDAD]=" + varActividades + ", [SALDO]=" + varSaldo + ",[EMAIL]='" + varCorreo + ",[Dias]=" + varDias + "' WHERE [DNI] =" + parDNI + "";

               
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
        public void BuscarSaldo()
        {
            ////Busca Mayor
            //string selectMayor = "SELECT MAX(Saldo) AS ValorMaximo FROM Socio Where Codigo_Actividad=" + parCodigo_Actividad;
            //OleDbCommand cmdMayor = new OleDbCommand(selectMayor, objConexion);
            //OleDbDataAdapter daMayor = new OleDbDataAdapter(cmdMayor);

            //lblMayor.Text = Convert.ToString(cmdMayor.ExecuteScalar());




            ////Buscar Menor   
            //string selectMenor = "SELECT MIN(Saldo) AS ValorMinimo FROM Socio WHERE Codigo_Actividad=" + parCodigo_Actividad;
            //OleDbCommand cmdMenor = new OleDbCommand(selectMenor, objConexion);
            //OleDbDataAdapter daMenor = new OleDbDataAdapter(cmdMenor);

            //lblMenor.Text = Convert.ToString(cmdMenor.ExecuteScalar());



            ////Total saldos
            //int[] vecSaldo = new int[100];
            //int indice = 0;

            //string selectSaldo = "SELECT Saldo FROM Socio WHERE Codigo_Actividad=" + parCodigo_Actividad;
            //OleDbCommand cmdSaldo = new OleDbCommand(selectSaldo, objConexion);
            //OleDbDataAdapter daSaldo = new OleDbDataAdapter(cmdSaldo);

            //OleDbDataReader objLector = cmdSaldo.ExecuteReader();
            //while (objLector.Read())
            //{
            //    vecSaldo[indice] = Convert.ToInt32(objLector[0]);
            //    indice++;
            //}

            //int suma = vecSaldo.Sum();
            //lblTotal.Text = suma.ToString();





            ////Sacar Promedio
            //int total = Convert.ToInt32(lblTotal.Text);
            //int cantidadRegistros = grlPrincipalActividad.Rows.Count;


            //varPromedio = total / cantidadRegistros;
            //lblPromedio.Text = Convert.ToString(varPromedio);

            //objConexion.Close();
        }
        public void GenerarReporte(Int32 parCodigo_Actividad)
        {
            try
            {
                objConexion.ConnectionString = varRuta;
                objConexion.Open();
                objComando.Connection = objConexion;
                objComando.CommandType = CommandType.TableDirect;
                objComando.CommandText = varTabla;

                OleDbDataReader objLectura = objComando.ExecuteReader();

                StreamWriter objArchivo = new StreamWriter("Reporte Por Actividad.csv", false);
                objArchivo.WriteLine("Listado por Actividad");
                objArchivo.WriteLine();
                objArchivo.WriteLine("Dni;Nombre;Apellido");

                if (objLectura.HasRows)
                {
                    while (objLectura.Read())
                    {
                        if (objLectura.GetInt32(7) == parCodigo_Actividad)
                        {
                            objArchivo.Write(objLectura.GetInt32(0));
                            objArchivo.Write(";");
                            objArchivo.Write(objLectura.GetString(1));
                            objArchivo.Write(';');
                            objArchivo.Write(objLectura.GetString(2));
                            objArchivo.Write("\n");
                        }
                       
                                            
                    }
                }
                objConexion.Close();
                objArchivo.Close();
            }
            catch (Exception Mensajito)
            {
                MessageBox.Show(Mensajito.Message);
                //throw;
            }
        }
        public void ImprimirActividad(PrintPageEventArgs parReporte)
        {
            try
            {
                Font LetraTitulo1 = new Font("Arial", 20);
                Font LetraTitulo2 = new Font("Arial", 12);
                Font TipoLetra = new Font("Arial", 8);

                Int32 linea = 200;
                //Imprime el encabezado del PDF
                parReporte.Graphics.DrawString("Listado de Clientes", LetraTitulo1, Brushes.Black, 100, 100);
                //Imprime nombres de las columnas del PDF

               //imprimo
                parReporte.Graphics.DrawString("Nombre", LetraTitulo2, Brushes.Black, 100, 150);
                //parReporte.Graphics.DrawString("Apellido", LetraTitulo2, Brushes.Black, 200, 150);
                parReporte.Graphics.DrawString("Dni", LetraTitulo2, Brushes.Black, 300, 150);

                objConexion.ConnectionString = varRuta;
                
                objConexion.Open();
                
                objComando.Connection = objConexion;
               //creamos tabla en ram
                objComando.CommandType = CommandType.TableDirect;
                //Seleccionamos la tabla q usaremos 
                objComando.CommandText = varTabla;

                objAdaptador = new OleDbDataAdapter(objComando);
                DataSet objLector = new DataSet();

                objAdaptador.Fill(objLector, varTabla);

                //Si el lector contiene filas
                if (objLector.Tables[varTabla].Rows.Count > 0)
                {

                    //mostramos
                    foreach (DataRow fila in objLector.Tables[varTabla].Rows)
                    {
                       
                        parReporte.Graphics.DrawString(fila["Nombre"].ToString(), TipoLetra, Brushes.Black, 100, linea);
                        //parReporte.Graphics.DrawString(fila["Apellido "].ToString(), TipoLetra, Brushes.Black, 200, linea);
                        parReporte.Graphics.DrawString(fila["DNI"].ToString(), TipoLetra, Brushes.Black, 300, linea);

                        linea = (linea + 20);
                        Cliente++;
                    }
                    parReporte.Graphics.DrawString("Cantidad Clientes" + "" + Cliente, LetraTitulo2, Brushes.Black, 100, linea + 20);

                }
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
