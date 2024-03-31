using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Globalization;

namespace CapaDatos
{
    public class CDCompra
    {
        //String para conectarse en netbook
        //string connectionStringEscritorio = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //String para conectarse en escritorio
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";
        public int ObtenerCorrelativo()
        {
            int idCorrelativo = 0;
            
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {
                    string query = "SELECT count(*) + 1 FROM Factura";
                    SqlCommand comandoInsercion = new SqlCommand(query, con);
                    comandoInsercion.CommandType = CommandType.Text;

                    con.Open();

                    idCorrelativo = Convert.ToInt32(comandoInsercion.ExecuteScalar());
                }
                catch (SqlException ex)
                {
                    idCorrelativo = 0;
                }
            }
                return idCorrelativo;
        }

        /*public bool Registrar (Factura obj, DataTable)
        {

        }*/

    }
}
