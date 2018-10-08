using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using System.Data.Sql;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PROYECTO_CATEDRA_MAG
{
   public  class Conexion
    {

       
        public SqlCommand cmd;
        public SqlDataReader dr;
        public SqlDataAdapter da;
        public DataTable dt;


       public string con = "Data Source=kelvisinstance.ckonyymt7xwi.us-east-2.rds.amazonaws.com;Initial Catalog=Proyecto_MAG;Persist Security Info=True;User ID=programador;Password=Progra123456";

        public SqlConnection conexion = new SqlConnection();

       

    //Creacion de constructor de la clase 
        public Conexion()
        {
            conexion.ConnectionString = con;
        }

        public void abrir()
        {
            try
            {
                conexion.Open();
                MessageBox.Show("Conexion abierta");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir BD" + ex.ToString());

            }
        }

    public void cerrar()
        {
            conexion.Close();
        }

    }
}
