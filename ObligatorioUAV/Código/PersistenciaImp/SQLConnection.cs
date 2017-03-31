using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.Common;
using System.Configuration;
using System.Data.SqlClient;

namespace PersistenciaImp
{
    public class SQLConnection
    {
        private static SQLConnection instance;
        private SqlConnection connection;

        private SQLConnection()
        {
            connection = new SqlConnection("Data Source=.\\SQLEXPRESS; Initial Catalog = UAV; Integrated Security=True; Connect Timeout=30");
            //connection = new SqlConnection("Server=.\\SQLEXPRESS;Database=UAV; Trusted_Connection=True");

        }

        public static SQLConnection Instance
        {
            get
            {
                if (instance == null)
                    instance = new SQLConnection();

                return instance;
            }
        }

        public int obtenerID()
        {
            int num = -1;
            System.Data.ConnectionState cerrado = new System.Data.ConnectionState();
            try
            {
                if (connection.State == cerrado)
                    connection.Open();
                String consulta = "SELECT ultimoOID FROM OIDActual";
                SqlCommand comando = new SqlCommand(consulta, connection);
                SqlDataReader reader = comando.ExecuteReader();
                reader.Read();
                num = reader.GetInt32(0);
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return num + 1;
        }

        public string EjecutarSentencia(string sentencia)
        {
            SqlCommand comando = new SqlCommand(sentencia);
            System.Data.ConnectionState cerrado = new System.Data.ConnectionState();
            try
            {
                if (connection.State == cerrado)
                    connection.Open();
                comando.Connection = connection;
                comando.ExecuteNonQuery();
                return "OK";
            }
            catch (DbException ex)
            {
                if (ex.ErrorCode == -2146232060)
                {
                    return "El objeto no se puede borrar: Esta siendo utilizado en otro Componente";
                }
                return ex.Message;
            }
            finally
            {
                connection.Close();
            }
        }


        public SqlDataReader EjecutarConsulta(string consulta)
        {
            SqlCommand comando = new SqlCommand(consulta);
            SqlDataReader retorno;
            System.Data.ConnectionState cerrado = new System.Data.ConnectionState();
            try
            {
                if (connection.State == cerrado)
                    connection.Open();
                comando.Connection = connection;
                retorno = comando.ExecuteReader();
            }
            catch (DbException ex)
            {
                throw new Exception(ex.Message);
            }
            return retorno;
        }

        public void Cerrar()
        {
            connection.Close();
        }
    }
}

