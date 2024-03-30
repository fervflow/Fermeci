namespace Fermeci
{
    public partial class FormMenuEmpleado : Form
    {
        public FormMenuEmpleado()
        {
            InitializeComponent();
            personalizar();
        }
        private void personalizar()
        {
            pSubMenuRealizarVenta.Visible = false;
        }
        private void hideSubMenu()
        {
            if (pSubMenuRealizarVenta.Visible == true)
                pSubMenuRealizarVenta.Visible = false;
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

        private void btRealizarVenta_Click(object sender, EventArgs e)
        {
            showSubMenu(pSubMenuRealizarVenta);
        }


        private void btContado_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVentaContado());
            hideSubMenu();
        }

        private void btCredito_Click(object sender, EventArgs e)
        {
            openChildForm(new FormVentaCredito());
            hideSubMenu();
        }
        private void btRegistrarProducto_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistrarProducto());
            hideSubMenu();
        }
        private void btBuscarProducto_Click(object sender, EventArgs e)
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

        private void btRegistrarProveedor_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistrarProveedor());
            hideSubMenu();
        }

        private void btHistorialVentas_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btRegistrarCliente_Click(object sender, EventArgs e)
        {
            openChildForm(new FormRegistrarCliente());
            hideSubMenu();
        }
    }
}
