using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Fermeci.Database;

namespace Fermeci
{
    public partial class FormBuscarProducto : Form
    {
        public FormBuscarProducto()
        {
            InitializeComponent();
        }


        private void tbBuscar_TextChanged(object sender, EventArgs e)
        {

        }

        private void tbBuscar_Enter(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "Buscar producto")
            {
                tbBuscar.Text = "";
            }
        }

        private void tbBuscar_Leave(object sender, EventArgs e)
        {
            if (tbBuscar.Text == "")
            {
                tbBuscar.Text = "Buscar producto";
            }
        }

        private void FormBuscarProducto_Load(object sender, EventArgs e)
        {
            Conexion objCon = new Conexion();
            string consulta = "SELECT * FROM dbo.producto";
            dtgProductos.DataSource = objCon.EjecutarConsultaTabla(consulta);
        }

        private void dtgProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                Conexion objCon = new Conexion();
                string buscar = tbBuscar.Text;
                string consulta = ("SELECT * FROM dbo.producto Where nombre = @buscar");
                dtgProductos.DataSource = objCon.EjecutarConsultaTablaBuscar(consulta,"@buscar", buscar);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Producto no encontrado" + ex);
            }
        }
    }
}
