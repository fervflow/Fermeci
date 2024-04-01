using Fermeci.Services;

namespace Fermeci
{
    public partial class FormRegistrarProducto : Form
    {
        private RegistroProducto registroProducto;
        public FormRegistrarProducto()
        {
            InitializeComponent();
            registroProducto = new RegistroProducto();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbPrecioCompra_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre = "", tipo = "", marca = "", precio_compra;
            string precio_venta, cantidad = "", descripcion = "";
            precio_compra = precio_venta = "0.00";

            nombre = tbNombre.Text;
            tipo = cbTipo.Text;
            marca = tbMarca.Text;
            precio_compra = tbPrecioCompra.Text;
            precio_venta = tbPrecioVenta.Text;
            cantidad = nCantidad.Text;
            descripcion = tbDescripcion.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }
            if (string.IsNullOrEmpty(tipo))
            {
                MessageBox.Show("El tipo es obligatorio");
                return;
            }
            if (string.IsNullOrEmpty(marca))
            {
                MessageBox.Show("La marca es obligatoria");
                return;
            }
            if (string.IsNullOrEmpty(precio_compra))
            {
                MessageBox.Show("El precio de la compra es obligatoria");
                return;
            }
            if (string.IsNullOrEmpty(precio_venta))
            {
                MessageBox.Show("El precio de la venta es obligatoria");
                return;
            }
            if (string.IsNullOrEmpty(cantidad))
            {
                MessageBox.Show("La cantidad  de productos a adquirir es obligatoria");
                return;
            }
            if (string.IsNullOrEmpty(descripcion))
            {
                MessageBox.Show("La descripcion del producto es obligatoria");
                return;
            }
            registroProducto.Registrar(nombre, tipo, marca, precio_compra, precio_venta, cantidad, descripcion);
        }
    }
}
