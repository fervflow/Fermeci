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
            string nombre = "", tipo = "", marca = "", descripcion = "";
            double precio_venta, precio_compra;
            int cantidad;
            precio_compra = precio_venta = 0.00;
            nombre = tbNombre.Text;
            tipo = cbTipo.Text;
            marca = tbMarca.Text;
            descripcion = tbDescripcion.Text;
            precio_venta = double.Parse(tbPrecioVenta.Text);
            precio_compra = double.Parse(tbPrecioCompra.Text);
            cantidad = int.Parse(nCantidad.Text);

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
            if (precio_compra == 0)
            {
                MessageBox.Show("El precio de la compra es obligatoria");
                return;
            }
            if (precio_venta == 0)
            {
                MessageBox.Show("El precio de la venta es obligatoria");
                return;
            }
            if (cantidad == 0)
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
