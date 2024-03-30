namespace Fermeci
{
    public partial class FormRegistrarProducto : Form
    {
        public FormRegistrarProducto()
        {
            InitializeComponent();
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


        }
    }
}
