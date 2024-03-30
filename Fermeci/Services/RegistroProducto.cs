using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fermeci.Database;

namespace Fermeci.Services
{
    internal class RegistroProducto
    {
        private Conexion conexion;

        public RegistroProducto ()
        {
            conexion = new Conexion();
        }

        public void Registrar (string nombre, string tipo, string marca, string precio_compra, string precio_venta, string cantidad, string descripcion)
        {
            try
            {
                conexion.abrirConexion();
                precio_compra = string.Format("{0:#.00}", Convert.ToDecimal(precio_compra));
                precio_venta = string.Format("{0:#.00}", Convert.ToDecimal(precio_venta));
                tipo = tipo.ToUpper();
                // tipo + nombre + numero_unico
                //codigo_prducto = 
                string sql = "INSERT INTO producto (nombre, tipo, marca, precio_compra, precio_venta, cantidad, descripcion, codigo_producto)" +
                    "VALUES (@nombre, @tipo, @marca, @precio_compra, @precio_venta, @cantidad, @descripcion, @codigo_producto)";
                SqlCommand cmd = new SqlCommand(sql, conexion.conn);
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

            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
