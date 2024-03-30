namespace Fermeci
{
    public partial class FormVentaCredito : Form
    {
        private const double TasaInteresMensual = 0.005;
        public FormVentaCredito()
        {
            InitializeComponent();
        }

        private void btX2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            lbFechaHora.Text = "Fecha y hora de venta: " + now.ToString("dd/MM/yyyy HH:mm:ss");
        }
        private void CalcularTotal()
        {
            if (double.TryParse(tbPrecioUnitario.Text, out double precioUnitario) &&
                int.TryParse(tbCantidad.Text, out int cantidad) &&
                cbPlazoPago.SelectedItem != null)
            {
                // Obtener el plazo de pago seleccionado
                int plazoPago = int.Parse(cbPlazoPago.SelectedItem.ToString());

                // Calcular el total sin interés
                double totalSinInteres = precioUnitario * cantidad;

                // Calcular el interés total
                double interesTotal = totalSinInteres * TasaInteresMensual * plazoPago;

                // Calcular el total a pagar con interés
                double totalConInteres = totalSinInteres + interesTotal;

                // Mostrar el total en el TextBox tbTotal
                tbTotalPagar.Text = totalConInteres.ToString();
            }
            else
            {
                // Si uno de los valores no es numérico, mostrar un mensaje de error o dejar el total en blanco
                tbTotalPagar.Text = "";
            }
        }

        private void tbCantidad_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void tbPrecioUnitario_TextChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }

        private void cbPlazoPago_SelectedIndexChanged(object sender, EventArgs e)
        {
            CalcularTotal();
        }
    }
}
