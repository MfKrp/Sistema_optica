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
    internal class CAnteojo
    {
        //String que se usa para conectarse en Netbook
        string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";
        
        //String que se usa para conectarse en Pc de escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";


        public int IdAnteojo { get; set; }
        public int IdTipoAnteojo  { get; set; }
        public float GraduacionIzq { get; set; }
        public float GraduacionDer { get; set; }
        public float PrecioUnitario { get; set; }
        public bool EstadoAnteojo { get; set; }
        public int StockAnteojo { get; set; }
        //Campo que tendra el la imagen
        //
        public int IdForm { get; set; }
        public int IdMarca { get; set; }
        public int IdEstilo { get; set; }
        public int IdCristal { get; set; }
        public char Genero { get; set; }
        public string Color { get; set; }
        public byte[] ImagenAnteojo { get; set; }
        
        //Metodo que da de alta un producto
        public void altaProducto(string ComboBoxtipoAnteojo,
            string GradIzq,
            string GradDer,
            string TPrecioUnit,
            string TStock,
            string idForma,
            string idMarca,
            string idEstilo,
            string idCristal,
            string color,
            string genero,
            byte[] imagen)
        {

            int IdTipoAnteojo = int.Parse(ComboBoxtipoAnteojo); //Este combobox tiene el codigo que identificara si es un anteojo terapeutico o un anteojo de accesorio
            float precioUnit = float.Parse(TPrecioUnit);
            float graduacionIzq = float.Parse(GradIzq);
            float graduacionDer = float.Parse(GradDer);
            int stockProd = int.Parse(TStock);
            int formaAnt = int.Parse(idForma);
            int marcaAnt = int.Parse(idMarca);
            int estiloAnt = int.Parse(idEstilo);
            int cristal = int.Parse(idCristal);
            string colorAnt = color;
            string generoAnt = genero;
            byte[] imagenAnt = imagen;

            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            string consulta = "INSERT INTO Anteojo (IdTipoAnteojo, GraduacionIzq, GraduacionDer, PrecioUnitario, StockAnteojo, ImagenAnteojo, IdForm, IdMarca, IdEstilo, IdCristal, Genero, Color) VALUES (@IdTipoanteojo, @GraduacionIzq, @GraduacionDer, @PrecioUnitario, @StockAnteojo, @ImagenAnteojo, @IdForm, @IdMarca, @IdEstilo, @IdCristal, @Genero, @Color)";

            SqlCommand comandoInsercion = new SqlCommand(consulta, con);

            comandoInsercion.Parameters.AddWithValue("@IdTipoAnteojo", IdTipoAnteojo);
            comandoInsercion.Parameters.AddWithValue("@PrecioUnitario", precioUnit);
            comandoInsercion.Parameters.AddWithValue("@StockAnteojo", stockProd);
            comandoInsercion.Parameters.AddWithValue("@IdForm", formaAnt);
            comandoInsercion.Parameters.AddWithValue("@IdMarca", marcaAnt);
            comandoInsercion.Parameters.AddWithValue("@IdEstilo", estiloAnt);
            comandoInsercion.Parameters.AddWithValue("@IdCristal", cristal);
            comandoInsercion.Parameters.AddWithValue("@Genero", generoAnt);
            comandoInsercion.Parameters.AddWithValue("@Color", color);
            //El producto siempre que se da de alta es con un estado activo
            comandoInsercion.Parameters.AddWithValue("@EstadoAnteojo", 1);
            comandoInsercion.Parameters.AddWithValue("@ImagenAnteojo", imagenAnt);

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
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Anteojo", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridProductos.DataSource = dtbl;
            }
        }

        public void modificacionProducto(string ComboBoxtipoAnteojo,
            string GradIzq,
            string GradDer,
            string TPrecioUnit,
            string TStock,
            string idForma,
            string idMarca,
            string idEstilo,
            string idCristal,
            string color,
            string genero,
            DataGridView dataGridProductos)
        {
            DataGridViewRow fila = dataGridProductos.SelectedRows[0];
            //El ID del empleado no sera modificable ya que sera su numero de identificacion
            int id_producto = (int)fila.Cells["IdAnteojo"].Value;
            int IdTipoAnteojo = int.Parse(ComboBoxtipoAnteojo); //Este combobox tiene el codigo que identificara si es un anteojo terapeutico o un anteojo de accesorio
            float precioUnit = float.Parse(TPrecioUnit);
            float graduacionIzq = float.Parse(GradIzq);
            float graduacionDer = float.Parse(GradDer);
            int stockProd = int.Parse(TStock);
            int formaAnt = int.Parse(idForma);
            int marcaAnt = int.Parse(idMarca);
            int estiloAnt = int.Parse(idEstilo);
            int cristal = int.Parse(idCristal);
            string colorAnt = color;
            string generoAnt = genero;
            string query = "UPDATE Anteojo SET IdAnteojo = @IdAnteojo, IdTipoAnteojo = @IdTipoAnteojo, GraduacionIzq = @GraduacionIzq, GraduacionDer = @GraduacionDer,  PrecioUnitario = @PrecioUnitario, StockAnteojo = @StockAnteojo, IdForm = @IdForm, IdMarca = @IdMarca, IdEstilo = @IdEstilo, IdCristal = @IdCristal, Genero = @Genero, Color = @Color WHERE IdAnteojo= @IdAnteojo";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {

                /*comandoBaja.Parameters.AddWithValue("@estadoEmpleado", estadoEmpleado);*/
                comandoBaja.Parameters.AddWithValue("@IdAnteojo", id_producto);
                comandoBaja.Parameters.AddWithValue("@IdTipoAnteojo", IdTipoAnteojo);
                comandoBaja.Parameters.AddWithValue("@GraduacionIzq", graduacionIzq);
                comandoBaja.Parameters.AddWithValue("@GraduacionDer", graduacionDer);
                comandoBaja.Parameters.AddWithValue("@PrecioUnitario", precioUnit);
                comandoBaja.Parameters.AddWithValue("@StockAnteojo", stockProd);
                comandoBaja.Parameters.AddWithValue("@IdForm", formaAnt);
                comandoBaja.Parameters.AddWithValue("@IdMarca", marcaAnt);
                comandoBaja.Parameters.AddWithValue("@IdEstilo", estiloAnt);
                comandoBaja.Parameters.AddWithValue("@IdCristal", cristal);
                comandoBaja.Parameters.AddWithValue("@Genero", generoAnt);
                comandoBaja.Parameters.AddWithValue("@Color", colorAnt);

                //esta linea se usa cuando se hace modificacion, por lo tanto siempre debe ir incluida, caso opuesto en las lecturas que se usa ExecuteReader
                comandoBaja.ExecuteNonQuery();

                MessageBox.Show("Se ha modificado con exito el producto", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Si el producto se ha modificado con exito se debe refrescar el datagridview de los productos para poder ver los cambios
                CAnteojo verProductos = new CAnteojo();
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
            int id_producto = (int)fila.Cells["IdAnteojo"].Value;
            bool estadoProducto = false;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Anteojo SET EstadoAnteojo = @EstadoAnteojo WHERE IdAnteojo = @IdAnteojo";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@EstadoAntejo", estadoProducto);
                comandoBaja.Parameters.AddWithValue("@IdAntejo", id_producto);
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
            int id_producto = (int)fila.Cells["IdAnteojo"].Value;
            bool estadoProducto = true;
            //MessageBox.Show("Valor de la celda " + @ID_empleado);
            string query = "UPDATE Anteojo SET EstadoAnteojo = @EstadoAnteojo WHERE IdAnteojo= @IdAnteojo";
            SqlConnection conexion = new SqlConnection(connectionStringEscritorio);
            conexion.Open();
            SqlCommand comandoBaja = new SqlCommand(query, conexion);

            try
            {
                comandoBaja.Parameters.AddWithValue("@EstadoAnteojo", estadoProducto);
                comandoBaja.Parameters.AddWithValue("@IdAnteojo", id_producto);
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
                string queryUpdate = "UPDATE Anteojo set StockAnteojo = StockAnteojo - @cantidad where IdAnteojo = @IdAnteojo";
                SqlCommand comandoAct = new SqlCommand(queryUpdate, con);
                comandoAct.Parameters.AddWithValue("@cantidad", cantidadElegida);
                comandoAct.Parameters.AddWithValue("@IdAnteojo", id_producto);
                con.Open();
                comandoAct.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        public void recuperarStock(int cantidadElegida, int id_producto)
        {
            SqlConnection con = new SqlConnection(connectionStringEscritorio);

            try
            {
                string queryUpdate = "UPDATE Anteojo set StockAnteojo = StockAnteojo + @cantidad WHERE IdAnteojo = @IdAnteojo";
                SqlCommand comandoAct = new SqlCommand(queryUpdate, con);
                comandoAct.Parameters.AddWithValue("@cantidad", cantidadElegida);
                comandoAct.Parameters.AddWithValue("@IdAnteojo", id_producto);
                con.Open();
                comandoAct.ExecuteNonQuery();
            } catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
