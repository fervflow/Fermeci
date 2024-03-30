using Fermeci.Database;
using System.Data.SqlClient;

namespace Fermeci.Services
{
    internal class RegistroProveedor
    {
        private Conexion conexion;

        public RegistroProveedor()
        {
            conexion = new Conexion();
        }

        public void Registrar(string nombre, string direccion, string telefono, string ubicacion)
        {
            try
            {
                conexion.abrirConexion();
                string sql = "INSERT INTO proveedor (nombre, direccion, telefono, ubicacion)" +
                    "VALUES (@nombre, @direccion, @telefono, @ubicacion)";
                SqlCommand cmd = new SqlCommand(sql, conexion.conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@direccion", direccion);
                cmd.Parameters.AddWithValue("@telefono", telefono);
                cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

                try
                {

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Proveedor registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar al Proveedor.");
                    }
                }
                // Mensaje de error específico de la base de datos
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al registrar al proveedor: " + ex.Message);
                }
                // Mensaje de otro tipo de error
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
