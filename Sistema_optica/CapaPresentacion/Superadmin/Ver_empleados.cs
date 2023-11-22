using CapaPresentacion.Entidades_Clases;
using CapaPresentacion.Secretaria;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace CapaPresentacion.Superadmin
{
    public partial class Ver_empleados : Form
    {
        private static ToolStripMenuItem menuActivo = null;
        private static Form formActivo = null;

        //Strings de conexion a la base de datos
        //string connectionString = "Data Source=DESKTOP-0KBKDQS\\SQLEXPRESS;Initial Catalog=OpticaMaribel;Integrated Security=True";
        string connectionStringEscritorio = "Data Source=DESKTOP-3O1V6FN;Initial Catalog=OpticaMaribel;Integrated Security=True";
        public Ver_empleados()
        {
            InitializeComponent();
        }

        private void BVerEmpleados_Click(object sender, EventArgs e)
        {
            CEmpleado verEmpleados = new CEmpleado();
            verEmpleados.verEmpleados(dataGridView1);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Ver_empleados_Load(object sender, EventArgs e)
        {

        }

        private void BEliminarReg_Click(object sender, EventArgs e)
        {
            //Se Comprueba que al menos se haya seleccionado una fila
            if (dataGridView1.SelectedRows.Count > 0)
            {
                CEmpleado bajaEmpleado = new CEmpleado();
                bajaEmpleado.darDeBajaEmpleado(dataGridView1);
            }
            else
            {
                //Sino se muestra un mensaje de error
                MessageBox.Show("Seleccione almenos una fila para dar de baja al empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            /*
            DataGridViewRow fila = dataGridView1.SelectedRows[0];
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
            actualizarEmpleados.verEmpleados(dataGridView1);
            */
        }

        private void BModificarReg_Click(object sender, EventArgs e)
        {
            Modif_Empleado modificacionEmp = new Modif_Empleado();
            modificacionEmp.Show();
            this.Hide();
        }

        private void BHabilitar_Click(object sender, EventArgs e)
        {

            //Se comprueba que almenos se haya seleccionado una fila
            if (dataGridView1.SelectedRows.Count == 1)
            {
                //Despues de comprobar que se haya seleccionado una fila se debe comprobar que esa fila este deshabilitada para volver a habilitarla
                CEmpleado resturarEmpleado = new CEmpleado();
                resturarEmpleado.restaurarEmpleado(dataGridView1);
            }
            else
            {
                MessageBox.Show("Seleccione almenos una fila para habilitar un empleado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
