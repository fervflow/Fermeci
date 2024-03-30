using System.Data.SqlClient;
namespace Fermeci.Database
{
    internal class Conexion
    {
        private string cadenaConexion = "";
        public SqlConnection conn;

        public Conexion()
        {
            cadenaConexion = @"Data Source=localhost;Initial Catalog=fermeci;User ID=fermeci_admin;Password=admin123";
            conn = new SqlConnection(cadenaConexion);
        }

        public void abrirConexion()
        {
            try
            {
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al abrir la conexión a la BD: " + ex.Message);
            }
        }

        public void cerrarConexion()
        {
            try
            {
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cerrar la conexión a la BD: " + ex.Message);
            }
        }

        public string consultarAccessoEmpleado(string usuario, string codigoAcceso)
        {
            string nombre = "", apellido = "";
            abrirConexion();
            try
            {
                string sql = "SELECT p.nombre, p.apellido FROM personal AS p INNER JOIN empleado AS e ON p.id_personal = e.id_empleado WHERE p.usuario = @Usuario AND p.codigo_acceso = @CodigoAcceso";
                SqlCommand comandosql = new SqlCommand(sql, conn);
                comandosql.Parameters.AddWithValue("@Usuario", usuario);
                comandosql.Parameters.AddWithValue("@CodigoAcceso", codigoAcceso);
                SqlDataReader resultado = comandosql.ExecuteReader();

                if (resultado.Read())
                {
                    nombre = resultado.GetString(0);
                    apellido = resultado.GetString(1);
                }

                comandosql.Dispose();
                cerrarConexion();

                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
                {
                    return nombre + " " + apellido;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cerrarConexion();
                MessageBox.Show("Error al consultar la BD: " + ex.Message);
                return null;
            }
        }

        public string consultarAccessoPropietario(int ci, string pa)
        {
            string nombre = "", apellido = "";
            abrirConexion();
            try
            {
                string sql = "SELECT p.nombre, p.apellido FROM personal AS p INNER JOIN propiertario AS pr ON p.id_personal = pr.id_propietario WHERE p.ci = @CI AND p.codigo_acceso = @PASSWORD";
                SqlCommand comandosql = new SqlCommand(sql, conn);
                comandosql.Parameters.AddWithValue("@CI", ci);
                comandosql.Parameters.AddWithValue("@PASSWORD", pa);
                SqlDataReader resultado = comandosql.ExecuteReader();

                if (resultado.Read())
                {
                    nombre = resultado.GetString(0);
                    apellido = resultado.GetString(1);
                }

                comandosql.Dispose();
                cerrarConexion();
                if (!string.IsNullOrEmpty(nombre) && !string.IsNullOrEmpty(apellido))
                {
                    return nombre + " " + apellido;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                cerrarConexion();
                MessageBox.Show("Error al consultar la BD: " + ex.Message);
                return null;
            }
        }
    }
}