using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Capa_datos
{
    internal class CProducto
    {
        //String que se usa para conectarse en Netbook
        string connectionStringEscritorio = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        
        //String que se usa para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";


        public int ID_producto { get; set; }
        public float Precio_unitario { get; set; }
        public int Stock { get; set; }
        public int EstiloProd{ get; set; }
        public int MarcaProd { get; set;}
        public int TipoProducto { get; set; }
        public bool EstadoProducto { get; set; }
        
        //Metodo que da de alta un producto
        public void altaProducto(string TId_prod,
            string ComboBox_Anteojo,
            string TPrecio,
            string TStock,
            string ComboBox_Marca,
            string ComboBox_Estilo)
        {
            //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Desarrollo de la funcion para dar de alta un producto
            //Se capturan los valores


            int idProd = int.Parse(TId_prod);
            float precioUnit = float.Parse(TPrecio);
            int stockProd = int.Parse(TStock);
            int estiloProd = int.Parse(ComboBox_Estilo);
            int marcaProd = int.Parse(ComboBox_Marca);
            int tipoProd = int.Parse(ComboBox_Anteojo);

            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            string consulta = "INSERT INTO Producto (Id_producto, Precio_unitario, Stock, Estilo, Marca, Tipo, Estado_producto) VALUES (@Id_Producto, @Precio_unitario, @Stock, @Estilo, @Marca, @Tipo, @Estado_producto)";

            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@Id_producto", idProd);
            comandoInsercion.Parameters.AddWithValue("@Precio_unitario", precioUnit);
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

        public void verProductos(DataGridView dataGridProductos)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Producto", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridProductos.DataSource = dtbl;
            }
        }

        public void modificacionProducto(int id_prod,
            float precProd,
            int stockProd,
            int estiloProd,
            int marcaProd,
            int tipoProd,
            DataGridView dataGridProductos)
        {
            DataGridViewRow fila = dataGridProductos.SelectedRows[0];
            //El ID del empleado no sera modificable ya que sera su numero de identificacion
            int id_producto = (int)fila.Cells["Id_producto"].Value;
            float precioProducto = precProd;//TApellido.Text;
            int stockProducto = stockProd;//TTelefono.Text;
            int estiloProducto = estiloProd;//TCorreo.Text;
            int marcaProducto = marcaProd;//DTPFechaNac.Value.ToShortDateString();
            int tipoProducto = tipoProd;//TDni.Text;
            string query = "UPDATE Producto SET Id_producto = @Id_producto, Precio_unitario = @Precio_unitario, Stock = @Stock, Estilo = @Estilo, Marca = @Marca, Tipo = @Tipo WHERE Id_producto = @Id_producto";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {

                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                comandoBaja.Parameters.AddWithValue("@Id_producto", id_producto);
                comandoBaja.Parameters.AddWithValue("Precio_unitario", precioProducto);
                comandoBaja.Parameters.AddWithValue("Stock", stockProducto);
                comandoBaja.Parameters.AddWithValue("Estilo", estiloProducto);
                comandoBaja.Parameters.AddWithValue("Marca", marcaProducto);
                comandoBaja.Parameters.AddWithValue("Tipo", tipoProducto);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Si el producto se ha modificado con exito se debe refrescar el datagridview de los productos para poder ver los cambios
                CProducto verProductos = new CProducto();
                verProductos.verProductos(dataGridProductos);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al hacer modificacion de producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bajaProducto (DataGridView dataGridProd)
        {
            //Funcion que da de baja un producto
            DataGridViewRow fila = dataGridProd.SelectedRows[0];
            int id_producto = (int)fila.Cells["Id_producto"].Value;
            bool estadoProducto = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Producto SET Estado_producto = @Estado_producto WHERE Id_producto = @Id_producto";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@Estado_producto", estadoProducto);
                comandoBaja.Parameters.AddWithValue("@Id_producto", id_producto);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de baja el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.verProductos(dataGridProd);
                
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            
        }

        public void restaurarProd (DataGridView dataGridProd)
        {
            //Fila que vuelve el estado del producto activo nuevamente
            DataGridViewRow fila = dataGridProd.SelectedRows[0];
            int id_producto = (int)fila.Cells["Id_producto"].Value;
            bool estadoProducto = true;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Producto SET Estado_producto = @Estado_producto WHERE Id_producto = @Id_producto";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@Estado_producto", estadoProducto);
                comandoBaja.Parameters.AddWithValue("@Id_producto", id_producto);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha restaurado el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.verProductos(dataGridProd);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al restaurar el producto", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void descontarStock(int cantidadElegida, int id_producto)
        {

            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            try
            {
                string queryUpdate = "UPDATE Producto set Stock = Stock - @cantidad where Id_producto = @id_producto";
                SqlCommand comandoAct = new SqlCommand(queryUpdate, con);
                comandoAct.Parameters.AddWithValue("@cantidad", cantidadElegida);
                comandoAct.Parameters.AddWithValue("@id_producto", id_producto);
                con.Open();
                comandoAct.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
