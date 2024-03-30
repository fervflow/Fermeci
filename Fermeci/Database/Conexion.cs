/*namespace Fermeci
{
    internal class Conexion
    {
        private string cadenaConexion = "";
        private SqlConnection conn;
        public Conexion()
        {
            cadenaConexion = @"Data Source=LABREDES;Initial Catalog=ProyectoFermeci;User ID=daniel;Password=12345678";
            conn = new SqlConnection(cadenaConexion);
            try
            {
                conn.Open();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error :("+e.Message,"Error inesperado",MessageBoxButtons.OK);
            }
        }
    }
}
*/


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

        public void registrarCliente(string nombres, string apellidos, string ci, string direccion, string telefono)
        {
            abrirConexion();
            try
            {
                string sql = "INSERT INTO cliente (nombres, apellidos, ci, direccion, telefono) VALUES (@Nombres, @Apellidos, @CI , @Direccion, @Telefono)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.Parameters.AddWithValue("@CI", ci);
                cmd.Parameters.AddWithValue("@Nombres", nombres);
                cmd.Parameters.AddWithValue("@Apellidos", apellidos);
                cmd.Parameters.AddWithValue("@Direccion", direccion);
                cmd.Parameters.AddWithValue("@Telefono", telefono);

                try
                {

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Cliente registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar al cliente.");
                    }
                }
                catch (SqlException ex)
                {
                    // Mostrar el mensaje de error específico de la base de datos
                    MessageBox.Show("Error al registrar al cliente: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Mostrar cualquier otro error que ocurra
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }


                cerrarConexion();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }
        }

        public void registrarProveedor(string nombre, string direccion, string telefono, string ubicacion)
        {
            abrirConexion();
            try
            {
                string sql = "INSERT INTO proveedor (nombre, direccion, telefono, ubicacion) VALUES (@nombre, @direccion, @telefono, @ubicacion)";
                SqlCommand cmd = new SqlCommand(sql, conn);
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
                catch (SqlException ex)
                {
                    // Mostrar el mensaje de error específico de la base de datos
                    MessageBox.Show("Error al registrar al proveedor: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Mostrar cualquier otro error que ocurra
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

        public void registrarProducto(string nombre, string tipo, string marca, string precio_compra, string precio_venta, string cantidad, string descripcion)
        {
            abrirConexion();
            try
            {
                precio_compra = string.Format("{0:#.00}", Convert.ToDecimal(precio_compra));
                precio_venta = string.Format("{0:#.00}", Convert.ToDecimal(precio_venta));
                tipo = tipo.ToUpper();
                // tipo + nombre + numero_unico
                //codigo_prducto = 
                string sql = "INSERT INTO producto (nombre, tipo, marca, precio_compra, precio_venta, cantidad, descripcion, codigo_producto)" +
                    "VALUES (@nombre, @tipo, @marca, @precio_compra, @precio_venta, @cantidad, @descripcion, @codigo_producto)";
                SqlCommand cmd = new SqlCommand(sql, conn);
                //cmd.Parameters.AddWithValue("@nombre", nombre);
                //cmd.Parameters.AddWithValue("@direccion", direccion);
                //cmd.Parameters.AddWithValue("@telefono", telefono);
                //cmd.Parameters.AddWithValue("@ubicacion", ubicacion);

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
                catch (SqlException ex)
                {
                    // Mostrar el mensaje de error específico de la base de datos
                    MessageBox.Show("Error al registrar al proveedor: " + ex.Message);
                }
                catch (Exception ex)
                {
                    // Mostrar cualquier otro error que ocurra
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}