using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Entidades_Clases
{
    public class CCabecera
    {

        //String para conectarse en netbook
        string connectionStringEscritorio = "Data Source=DESKTOP-RUL54CM\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True;Encrypt=False";

        //String para conectarse en escritorio
        //string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";

        public int IdCabecera { get; set; }
        public DateTime Fecha_factura { get; set; }
        public bool Estado_factura { get; set; }

        public int IdFormaPago { get; set; }
        public int IdEmpleado { get; set; }
        public int IdCliente { get; set; }
        public float PrecioTotal { get; set; }

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

        /*
        public bool Registrar(CFactura obj, DataTable Detalle, out string Mensaje)
        {
            using (SqlConnection con = new SqlConnection(connectionStringEscritorio))
            {
                try
                {

                    //string query = "SELECT count(*) + 1 FROM Factura";
                    SqlCommand comandoInsercion = new SqlCommand("sp_RegistrarCompra", con);

                    comandoInsercion.Parameters.AddWithValue("Nro_factura", obj.Nro_factura);
                    comandoInsercion.Parameters.AddWithValue("Fecha_factura", obj.Fecha_factura);
                    comandoInsercion.Parameters.AddWithValue("Vendedor", obj.Vendedor.id_empleado);
                    comandoInsercion.Parameters.AddWithValue("Cliente", obj.Cliente.DNI);
                    comandoInsercion.Parameters.AddWithValue("Tipo_pago", obj.Tipo_pago);
                    comandoInsercion.Parameters.AddWithValue("Detalle", Detalle);

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
        */
        public void inicializarCabecera(float precioTotal ,int idUsuario, int idCliente, int idTipoPago, string fechaVenta)
        {
            SqlConnection con = new SqlConnection(connectionStringEscritorio);
            string insercion = "INSERT INTO Factura (IdCabecera, Fecha_factura, Vendedor, Cliente, ) VALUES (" + precioTotal + " , '" + fechaVenta + "' ," + idUsuario + ", " + idCliente + ", " + idTipoPago + ")";
            SqlCommand comandoInsercionVenta = new SqlCommand(insercion, con);

            try
            {
                con.Open();
                comandoInsercionVenta.ExecuteNonQuery();
                MessageBox.Show("Registros cargados exitosamente");
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error al registrar la venta \n" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
                con.Dispose();
            }
            
        }

        public void registrarCabecera (int nroFactura, float precioTotal, int idUsuario, int idCliente, int idTipoPago, string fechaVenta)
        {
            /*CCabecera nuevaCabecera = new CCabecera();
            nuevaCabecera.inicializarCabecera(nroFactura, precioTotal, idUsuario, idCliente, idTipoPago, fechaVenta);*/
        }


        public void registrarDetalle(int idDetalle,int cantidadProd, int idProd, int nroFactura, string color, string genero)
        {
            SqlConnection con = new SqlConnection(connectionStringEscritorio);
            string queryInsercionDetalle = "INSERT INTO Detalle (Id_detalle, Cantidad, ID_producto, Nro_factura, Color, Genero) VALUES (" + idDetalle + "," + cantidadProd + ", " + idProd + ", " + nroFactura + ", " + "'"+color+"'" + ", " + "'"+genero+"'" + ")";

            SqlCommand comandoInsercion = new SqlCommand(queryInsercionDetalle, con);

            try
            {
                con.Open();
                comandoInsercion.ExecuteNonQuery();
                MessageBox.Show("Venta Registrada con exito!", "Informacion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            } catch (Exception ex)
            {
                MessageBox.Show("Error generado " + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                con.Close();
            }

        }

        public int obtenerUltimoDetalle()
        {
            int ultimo = 0;
            string idUltimoDetalle = "SELECT TOP 1 Id_detalle FROM Detalle ORDER BY Id_detalle DESC";
            SqlConnection con = new SqlConnection(connectionStringEscritorio);
            SqlCommand ejecutar = new SqlCommand(idUltimoDetalle, con);

            con.Open();

            SqlDataReader leer = ejecutar.ExecuteReader();
            if (leer.Read() == true)
            {
                ultimo = Convert.ToInt32(leer["Id_detalle"].ToString());
                ultimo++;
                con.Close();
            }
            return ultimo;
        }
        //public int 

        /*
    public int obtenerUltimaCabecera()
    {
        SqlConnection con = new SqlConnection(connectionStringEscritorio);
        string query = "SELECT Nro_factura FROM Factura "
    }
        */

        public void verFacturasPersonales(DataGridView dataGridProductos, int idEmpleado)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Detalle WHERE Vendedor = " + idEmpleado, sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridProductos.DataSource = dtbl;
            }
        }

        public void verFacturasGenerales(DataGridView dataGridProductos)
        {
            using (SqlConnection sqlcon = new SqlConnection(connectionStringEscritorio))
            {
                sqlcon.Open();
                SqlDataAdapter sqlDa = new SqlDataAdapter("SELECT * FROM Detalle", sqlcon);
                DataTable dtbl = new DataTable();
                sqlDa.Fill(dtbl);

                dataGridProductos.DataSource = dtbl;
            }
        }
    }
}
