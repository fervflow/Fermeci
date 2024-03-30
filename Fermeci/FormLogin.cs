using Fermeci.Database;

namespace Fermeci
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            llenarComboLogin();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tbContraseña_TextChanged(object sender, EventArgs e)
        {

        }

        private void FormLogin_Load(object sender, EventArgs e)
        {
            //Conexion c = new Conexion();
            cbCargo.SelectedIndex = 0;
        }
        private void llenarComboLogin()
        {
            List<string> cargosLogin = new List<string>();
            cargosLogin.Add("Empleado");
            cargosLogin.Add("Propietario");
            cbCargo.DataSource = cargosLogin;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            String usuario = "", contrasena = "", nombre = "", tipo = "";
            usuario = tbNombreUsuario.Text;
            contrasena = tbContraseña.Text;
            tipo = cbCargo.SelectedValue.ToString();
            if (tipo.CompareTo("Empleado") == 0)
            {
                Conexion objBD = new Conexion();
                nombre = objBD.consultarAccessoEmpleado(usuario, contrasena);
                if (nombre == null)
                    MessageBox.Show("Datos inválidos");
                else
                {
                    //MessageBox.Show("Bienvenido " + nombre + " (Empleado)");
                    //Abrir la interfaz del empleado
                    this.Hide();
                    Form1 mainForm = new Form1();
                    mainForm.Show();
                }
            }
            else if (tipo.CompareTo("Propietario") == 0)
            {
                Conexion objBD = new Conexion();
                int ci = 0;
                try
                {
                    ci = Int32.Parse(usuario);
                }
                catch (Exception)
                {
                    Console.Write("Error al convertir");
                }
                nombre = objBD.consultarAccessoPropietario(ci, contrasena);
                if (nombre == null)
                    MessageBox.Show("Datos inválidos");
                else
                {
                    MessageBox.Show("Bienvenido " + nombre + " (Propietario)");
                    //Abrir la interfaz del propietario
                    this.Hide();
                    FormPropietario mainForm = new FormPropietario();
                    mainForm.Show();
                }
            }
        }

        private void tbNombreUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbCargo_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
