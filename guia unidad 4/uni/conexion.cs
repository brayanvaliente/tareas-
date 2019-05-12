using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data.Common;



namespace uni
{
    class conexion
    {

        SqlConnection cn;
        SqlCommand cdm;
        SqlDataReader dr;

        public conexion(){
            try 
	        {
                cn = new SqlConnection("Data Source=.;Initial Catalog=universidades;Integrated Security=True");
                cn.Open();
                MessageBox.Show("conectado");
	        }
	        catch (Exception ex)
	        {

                MessageBox.Show("no se conecta con la base de datos: "+ex.ToString());
            }
        }

        public string insertar(int id, string nombre, string ubicacion, string descripcion) {
            string salida = "si se inserto";
            try
            {
                cdm = new SqlCommand("INSERT INTO tipocarrera(id_tipocarrera,nombre,ubicacion,descripcion) VALUES("+id+",'"+nombre+"','"+ubicacion+"','"+descripcion+"')",cn);
                cdm.ExecuteNonQuery();

            }
            catch (Exception ex)
            {

                salida = "no se conecto"+ex.ToString();
                
            }
            return salida;


        }
    }

       
}
