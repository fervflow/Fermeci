namespace Fermeci
{
    public partial class FormVentaContado : Form
    {
        public FormVentaContado()
        {
            InitializeComponent();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbFechaHora.Text = "Fecha y hora de venta: " + now.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void tbPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
        private void CalcularTotal()
        {
            if (double.TryParse(tbPrecioUnitario.Text, out double precioUnitario) &&
                int.TryParse(tbCantidad.Text, out int cantidad))
            {
                double total = precioUnitario * cantidad;
                tbTotalPagar.Text = total.ToString();
            }
            else
            {
                tbTotalPagar.Text = "";
            }
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
