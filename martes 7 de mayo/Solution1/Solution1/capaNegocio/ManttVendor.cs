using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace capaNegocio
{
    public class ManttVendor
    {
        bdConex test= new bdConex();
        private string codVendedor, nombreVendeor;

        public string NombreVendeor
        {
            get { return nombreVendeor; }
            set { nombreVendeor = value; }
        }

        public string CodVendedor
        {
            get { return codVendedor; }
            set { codVendedor = value; }
        }
        //insert into VENDEDOR (VENDEDOR,NOMBRE) values(,) 
        public void insertVendedor()
        {
            try {
                string insert = "insert into VENDEDOR (VENDEDOR,NOMBRE) values('"+codVendedor +"','"+nombreVendeor+"')";
                test.Conectar();
                test.consultaSQL(insert);
                test.Desconectar();


            }
            catch
            {

            }
        
        }
        public void actVendedor()
        {
            try
            {
                string update = "update VENDEDOR set NOMBRE='" + nombreVendeor + "' WHERE actVendedor ='" + codVendedor + "'";
                test.Conectar();
                test.consultaSQL(update);
                test.Desconectar();


            }
            catch
            {

            }    

        }
        public void deleteVendor()
        {
            try
            {
                string delete = "delete from vendedor where vendedor= '"+ codVendedor+"' " ;
                test.Conectar();
                test.consultaSQL(delete);
                test.Desconectar();


            }
            catch
            {

            }

        }





        public String prueba()
        {
            String mensaje;
            if (test.Conectar() == true)
            {
                test.Desconectar();
                mensaje = "Conexion realizada";
            }
            else {
                test.Desconectar();
                mensaje = "Conexion no realizada";
            }
            return mensaje;

        }
    }
}
