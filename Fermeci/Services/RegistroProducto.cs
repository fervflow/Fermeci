using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography;
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

        public void Registrar(string nombre, string tipo, string marca, double precio_compra, double precio_venta, int cantidad, string descripcion)
        {
            try
            {
                conexion.abrirConexion();

                // Generar un código aleatorio para el producto
                string codigo_producto = generarCodigoProducto(tipo, nombre);

                string sql = "INSERT INTO producto (nombre, tipo, marca, precio_compra, precio_venta, cantidad, descripcion, codigo_producto)" +
                    "VALUES (@nombre, @tipo, @marca, @precio_compra, @precio_venta, @cantidad, @descripcion, @codigo_producto)";
                SqlCommand cmd = new SqlCommand(sql, conexion.conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@precio_compra", precio_compra);
                cmd.Parameters.AddWithValue("@precio_venta", precio_venta);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                cmd.Parameters.AddWithValue("@codigo_producto", codigo_producto);

                try
                {
                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        MessageBox.Show("Producto registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar el Producto.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al registrar el producto: " + ex.Message);
                }
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

        private string generarCodigoProducto(string tipoProducto, string nombre)
        {
            Random random = new Random();
            int valorNumerico = random.Next(10000, 99999);

            string codigo = tipoProducto.Substring(0, 2) + nombre.Substring(0, 2) + valorNumerico.ToString();
            return codigo;
        }
    }
}
