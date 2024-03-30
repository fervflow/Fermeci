using Fermeci.Services;

namespace Fermeci
{
    public partial class FormRegistrarProveedor : Form
    {
        private RegistroProveedor registroProveedor;
        public FormRegistrarProveedor()
        {
            InitializeComponent();
            registroProveedor = new RegistroProveedor();
        }

        private void btX_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            string direccion = tbDireccion.Text;
            string num_telefono = tbTelefono.Text;
            string ubicacion = tbUbicacion.Text;

            if (string.IsNullOrEmpty(nombre))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }
            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("La dirección es obligatoria.");
                return;
            }
            if (string.IsNullOrEmpty(num_telefono))
            {
                MessageBox.Show("El numero de telefono es obligatorio.");
                return;
            }
            if (string.IsNullOrEmpty(ubicacion))
            {
                MessageBox.Show("La ubicación es obligatoria.");
                return;
            }

            registroProveedor.Registrar(nombre, direccion, num_telefono, ubicacion);

            /*try
            {
                Conexion objDB = new Conexion();
                objDB.registrarProveedor(nombre, direccion, num_telefono, ubicacion);
            }
            catch
            {
                MessageBox.Show("No se pudo registrar los datos del proveedor.");
            }*/
        }
    }
}
