using CapaPresentacion.Entidades_Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Superadmin
{
    public partial class Ver_empleados : Form
    {
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
            //Link de edicion   
            DataGridViewLinkColumn EditLink = new DataGridViewLinkColumn();
            EditLink.UseColumnTextForLinkValue = true;
            EditLink.HeaderText = "Edit";
            EditLink.DataPropertyName = "lnkColumn";
            EditLink.LinkBehavior = LinkBehavior.SystemDefault;
            EditLink.Text = "Edit";
            dataGridView1.Columns.Add(EditLink);

            //Link para borrar
            DataGridViewLinkColumn deleteLink = new DataGridViewLinkColumn();
            deleteLink.UseColumnTextForLinkValue = true;
            deleteLink.HeaderText = "Delete";
            deleteLink.DataPropertyName = "lnkColumn";
            deleteLink.LinkBehavior = LinkBehavior.SystemDefault;
            deleteLink.Text = "delete";
            dataGridView1.Columns.Add(deleteLink);
        }
    }
}
