using Fermeci.Database;
using Microsoft.Win32;
using System.Data.SqlClient;
using System.Diagnostics;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Fermeci
{
    public partial class FromDespedir : Form
    {
        public FromDespedir()
        {
            InitializeComponent();
        }

        private void btDespedir_Click(object sender, EventArgs e)
        {
            Conexion objCon = new Conexion();
            objCon.abrirConexion();
            string ci = tbCI.Text;
            string selecIDEmpleado = "SELECT id_personal FROM dbo.personal WHERE ci = @ci ";
            SqlCommand cmd = new SqlCommand(selecIDEmpleado, objCon.conn);
            cmd.Parameters.AddWithValue("@ci", ci);

            int idPersonal = 0;
            try
            {
                idPersonal = Convert.ToInt32(cmd.ExecuteScalar());
                if (idPersonal == 0)
                {
                    MessageBox.Show("No existe un empleado con el CI " + ci, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string eliminarReferencia = "DELETE FROM dbo.empleado WHERE id_empleado = @idPersonal";
                SqlCommand deletReference = new SqlCommand(eliminarReferencia, objCon.conn);
                deletReference.Parameters.AddWithValue("@idPersonal", idPersonal);
                deletReference.ExecuteNonQuery();

                string consulta = "DELETE FROM dbo.personal WHERE ci = @ci";
                SqlCommand deletRegsitro = new SqlCommand(consulta, objCon.conn);
                deletRegsitro.Parameters.AddWithValue("@ci", ci);
                deletRegsitro.ExecuteNonQuery();

                MessageBox.Show("El registro del empleado con CI " + ci + " ha sido eliminado.", "Eliminación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Se produjo un error al intentar eliminar el registro del empleado: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                objCon.cerrarConexion();
            }
            FromDespedir_Load(sender, e);
        }



        private void tbCI_TextChanged(object sender, EventArgs e)
        {


        }

        private void dtgEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void FromDespedir_Load(object sender, EventArgs e)
        {
            try
            {
                Conexion objCon = new Conexion();
                string consulta = ("SELECT * FROM dbo.personal WHERE usuario != 'admin'");
                dtgEmpleados.DataSource = objCon.EjecutarConsultaTabla(consulta);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al intentar mostrar los emplados" + ex);
            }

        }
    }
}
