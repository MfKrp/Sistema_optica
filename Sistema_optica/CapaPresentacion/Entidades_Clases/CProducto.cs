using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Capa_datos
{
    internal class CProducto
    {
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //Metodo que da de alta un producto
        public void altaProducto(string TId_prod, string ComnboBox_Anteojo, string TPrecio, string ComboBox_Genero, string TColor, string TStock, string ComboBox_Marca, string ComboBox_Estilo)
        {
            //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Desarrollo de la funcion para dar de alta un producto
            //Se capturan los valores


            int idProd = int.Parse(TId_prod);
            string nombre = ComnboBox_Anteojo;
            float precioUnit = float.Parse(TPrecio);
            string generoProd = ComboBox_Genero/*.ValueMember.ToString()*/;
            string colorProd = TColor;
            int stockProd = int.Parse(TStock);
            int estiloProd = int.Parse(ComboBox_Estilo);
            int marcaProd = int.Parse(ComboBox_Marca);
            int tipoProd = int.Parse(ComboBox_Estilo);

            SqlConnection con = new SqlConnection(connectionString);

            string consulta = "INSERT INTO Producto (Id_producto, Nombre, Precio_unitario, Genero, Color, Stock, Estilo, Marca, Tipo, Estado_producto) VALUES (@Id_Producto, @Nombre, @Precio_unitario, @Genero, @Color, @Stock, @Estilo, @Marca, @Tipo, @Estado_producto)";

            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@Id_producto", idProd);
            comandoInsercion.Parameters.AddWithValue("@Nombre", nombre);
            comandoInsercion.Parameters.AddWithValue("@Precio_unitario", precioUnit);
            comandoInsercion.Parameters.AddWithValue("@Genero", generoProd);
            comandoInsercion.Parameters.AddWithValue("@Color", colorProd);
            comandoInsercion.Parameters.AddWithValue("@Stock", stockProd);
            comandoInsercion.Parameters.AddWithValue("@Estilo", estiloProd);
            comandoInsercion.Parameters.AddWithValue("@Marca", marcaProd);
            comandoInsercion.Parameters.AddWithValue("@Tipo", tipoProd);
            //El producto siempre que se da de alta es con un estado activo
            comandoInsercion.Parameters.AddWithValue("@Estado_producto", 1);

            try
            {
                con.Open();
                comandoInsercion.ExecuteNonQuery();
                MessageBox.Show("Registros insertados exitosamente", "Exito!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error Generado.\nDetalles: " + j.ToString(), "Error generado en insercion", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close(); //una vez insertados los registros se cierra la conexion
            }
        }

    }
}
