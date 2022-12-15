using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Capa_Datos
{
    public class GestorConexion
    {
            private string cadenaConexion;
            public SqlConnection conectarDB;


            public GestorConexion()
            {
                cadenaConexion = "Data Source = DESKTOP-Q9LJMJV;Initial Catalog=BD_Alq_Hab;User ID=sa;Password=kakaroto27";
                conectarDB = new SqlConnection();
                conectarDB.ConnectionString = cadenaConexion;
            }

            public void abrirConexion()
            {
                try
                {
                    conectarDB.Open();
                    MessageBox.Show("La conexión está abierta");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("La conexión no se pudo abrir" + ex);
                }
            }
            public void cerrarConexion()
            {
                conectarDB.Close();
                MessageBox.Show("La conexión se cerró");
            }

            //Devolver el objeto completo, es como devolver cualquier variable generada

            public SqlConnection getConexion()
            {
                return conectarDB;
            }

        
    }
}
