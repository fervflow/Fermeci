namespace Fermeci
{
    public partial class FormPropietario : Form
    {
        public FormPropietario()
        {
            InitializeComponent();
            personalizar();
        }
        private void personalizar()
        {
            pSubMenuRegistrar.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pSubMenuRegistrar.Visible == true)
                pSubMenuRegistrar.Visible = false;
        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void FormPropietario_Load(object sender, EventArgs e)
        {

        }

        private void btRegistrarEmpleadoProveedor_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubMenuRegistrar);
        }

        private void btRegistrarEmpleado_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistroEmpleado());
            hideSubMenu();
        }

        private void btRegistrarProveedor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistrarProveedor());
            hideSubMenu();
        }

        private void btHistorialVentas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btGenerarPedido_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void btDarBaja_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void ObtenerReporte_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }
        private Form activeForm = null;
        private void openChildForm(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            pContenedor.Controls.Add(childForm);
            pContenedor.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }
    }
}
