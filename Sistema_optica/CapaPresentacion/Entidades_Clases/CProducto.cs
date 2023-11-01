using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Capa_datos
{
    internal class CProducto
    {
        string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";

        //Metodo que da de alta un producto
        public void altaProducto(string TId_prod, string ComboBox_Anteojo, string TPrecio, string ComboBox_Genero, string TColor, string TStock, string ComboBox_Marca, string ComboBox_Estilo)
        {
            //MessageBox.Show("Esta Funcion todavia se encuentra en desarrollo", "Funcion no disponible", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //Desarrollo de la funcion para dar de alta un producto
            //Se capturan los valores


            int idProd = int.Parse(TId_prod);
            string nombre = ComboBox_Anteojo;
            float precioUnit = float.Parse(TPrecio);
            //string generoProd = ComboBox_Genero/*.ValueMember.ToString()*/;
            //string colorProd = TColor;
            int stockProd = int.Parse(TStock);
            int estiloProd = int.Parse(ComboBox_Estilo);
            int marcaProd = int.Parse(ComboBox_Marca);
            int tipoProd = int.Parse(ComboBox_Anteojo);

            SqlConnection con = new SqlConnection(connectionString);

            string consulta = "INSERT INTO Producto (Id_producto, Nombre, Precio_unitario, Stock, Estilo, Marca, Tipo, Estado_producto) VALUES (@Id_Producto, @Nombre, @Precio_unitario, @Stock, @Estilo, @Marca, @Tipo, @Estado_producto)";

            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@Id_producto", idProd);
            comandoInsercion.Parameters.AddWithValue("@Nombre", nombre);
            comandoInsercion.Parameters.AddWithValue("@Precio_unitario", precioUnit);
            //comandoInsercion.Parameters.AddWithValue("@Genero", generoProd);
            //comandoInsercion.Parameters.AddWithValue("@Color", colorProd);
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
            using (SqlConnection sqlcon = new SqlConnection(connectionString))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Producto", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridProductos.DataSource = dtbl;
            }
        }

        public void modificacionProducto(int id_prod,
            string nombreProd,
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
            string nombreProducto = nombreProd;//TNombre.Text;
            float precioProducto = precProd;//TApellido.Text;
            int stockProducto = stockProd;//TTelefono.Text;
            int estiloProducto = estiloProd;//TCorreo.Text;
            int marcaProducto = marcaProd;//DTPFechaNac.Value.ToShortDateString();
            int tipoProducto = tipoProd;//TDni.Text;
            string query = "UPDATE Producto SET Id_producto = @Id_producto, Nombre = @Nombre, Precio_unitario = @Precio_unitario, Stock = @Stock, Estilo = @Estilo, Marca = @Marca, Tipo = @Tipo WHERE Id_producto = @Id_producto";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {

                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                comandoBaja.Parameters.AddWithValue("@Id_producto", id_producto);
                comandoBaja.Parameters.AddWithValue("Nombre", nombreProducto);
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
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void bajaProducto (DataGridView dataGridProd)
        {
            DataGridViewRow fila = dataGridProd.SelectedRows[0];
            int id_empleado = (int)fila.Cells["ID_empleado"].Value;
            bool estadoEmpleado = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE UsuarioEmpleado SET Estado_empleado = @estadoEmpleado WHERE ID_empleado = @ID_empleado";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);
                comandoBaja.Parameters.AddWithValue("@ID_empleado", id_empleado);
                //esta linea se usa cuando se hace modificacion
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha dado de baja al empleado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (SqlException j)
            {
                MessageBox.Show("Error en: " + j.ToString(), "Error al dar de baja", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            CEmpleado actualizarEmpleados = new CEmpleado();
            actualizarEmpleados.verEmpleados(dataGridEmpleado);
        }

        public void restaurarProd (DataGridView dataGridProd)
        {

        }
    }
}
