using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using domain;
namespace bussines
{
    public class connection
    {
        private SqlConnection con;  //conexion a la que se conecta la aplicacion
        private SqlCommand com;
        private SqlDataReader reader; //crea un lector de datos que alojara todos los datos 

        public connection()
        {
            con = new SqlConnection("server=.\\SQLEXPRESS; database=tecnoSystem; integrated security=true");
            com = new SqlCommand();

        }

        public void setQuery(string query) //asigna la query
        {
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = query;
        }
        public void getConnectionAndExecuteReader() //realiza la lectura y conecta con la base de datos
        {
            try
            {
                com.Connection = con;
                con.Open();
                reader = com.ExecuteReader();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            

        }
        public void getConnectionAndExecuteAction()
        {
            try
            {
                com.Connection = con;
                con.Open();
                com.ExecuteNonQuery(); //ejecuta sentencia

            }
            catch (Exception e) { throw e; }
        }

        public void closeConnection() //cierra el lector y la conexion
        {
            if (reader!= null) { reader.Close(); }

            con.Close();
        }
        public SqlDataReader getReader() { return reader; }
        public SqlCommand getCommand() { return com; }
    }

}
