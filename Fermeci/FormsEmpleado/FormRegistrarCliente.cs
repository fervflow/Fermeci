using Fermeci.Database;

namespace Fermeci
{
    public partial class FormRegistrarCliente : Form
    {
        public FormRegistrarCliente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            // Obtener los valores de los campos de entrada
            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            string ci = tbCi.Text;
            string direccion = tbDireccion.Text;
            string telefono = tbTelefono.Text;

            // Validar los datos
            if (string.IsNullOrEmpty(nombres))
            {
                MessageBox.Show("El nombre es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(apellidos))
            {
                MessageBox.Show("El apellido es obligatorio.");
                return;
            }

            if (string.IsNullOrEmpty(ci))
            {
                MessageBox.Show("La cédula de identidad es obligatoria.");
                return;
            }

            if (string.IsNullOrEmpty(direccion))
            {
                MessageBox.Show("La dirección es obligatoria.");
                return;
            }

            if (string.IsNullOrEmpty(telefono))
            {
                MessageBox.Show("El teléfono es obligatorio.");
                return;
            }

            try
            {
                Conexion objDB = new Conexion();
                objDB.registrarCliente(nombres, apellidos, ci, direccion, telefono);
            }
            catch
            {
                MessageBox.Show("No se pudo registrar los datos del cliente.");
            }
        }
    }
}