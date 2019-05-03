using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace capaDatos
{
    public class bdConex
    {
        string cadenaConex = "Data Source=.;Persist Security Info=True;User ID=juan_perez2";
        SqlDataAdapter adaptador;
        SqlCommandBuilder comm;
        SqlConnection conexion = new SqlConnection();
        SqlCommand comando;

        public SqlConnection Conexion {

            get { return conexion; }
            set { conexion = value; }

        }
        public bool conecta()
        {
            bool conn = false;
            try
            {
                conexion.ConnectionString = cadenaConex;
                conexion.Open();
                conn = true;
            }
            catch (Exception ex)
            {
                conn = false;
            }
            return conn;
        }
        public void desconectar() {
            conexion.Close();
            }
        
    }
        
        
        
        
}
