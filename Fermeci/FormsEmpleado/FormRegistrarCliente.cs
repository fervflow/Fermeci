using Fermeci.Services;

namespace Fermeci
{
    public partial class FormRegistrarCliente : Form
    {
        private RegistroCliente registroCliente;
        public FormRegistrarCliente()
        {
            InitializeComponent();
            registroCliente = new RegistroCliente();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombres = tbNombres.Text;
            string apellidos = tbApellidos.Text;
            string ci = tbCi.Text;
            string direccion = tbDireccion.Text;
            string telefono = tbTelefono.Text;

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
            
            registroCliente.Registrar(nombres, apellidos, ci, direccion, telefono);
        }
    }
}