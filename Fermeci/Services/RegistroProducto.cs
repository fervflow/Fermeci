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
        private string codigo_producto;
        private string tipo_producto_cod;

        public RegistroProducto ()
        {
            conexion = new Conexion();
            codigo_producto = tipo_producto_cod = "";
        }

        public void Registrar (string nombre, string tipo, string marca, string precio_compra, string precio_venta, string cantidad, string descripcion)
        {
            try
            {
                string id_producto = "";
                conexion.abrirConexion();
                
                precio_compra = string.Format("{0:#.00}", Convert.ToDecimal(precio_compra));
                precio_venta = string.Format("{0:#.00}", Convert.ToDecimal(precio_venta));
                tipo = tipo.ToUpper();
                // tipo + nombre + numero_unico
                //codigo_prducto = 
                string sql = "INSERT INTO producto (nombre, tipo, marca, precio_compra, precio_venta, cantidad, descripcion)" +
                    "VALUES (@nombre, @tipo, @marca, @precio_compra, @precio_venta, @cantidad, @descripcion)";
                SqlCommand cmd = new SqlCommand(sql, conexion.conn);
                cmd.Parameters.AddWithValue("@nombre", nombre);
                cmd.Parameters.AddWithValue("@tipo", tipo);
                cmd.Parameters.AddWithValue("@marca", marca);
                cmd.Parameters.AddWithValue("@precio_compra", precio_compra);
                cmd.Parameters.AddWithValue("@precio_venta", precio_venta);
                cmd.Parameters.AddWithValue("@cantidad", cantidad);
                cmd.Parameters.AddWithValue("@descripcion", descripcion);
                //cmd.Parameters.AddWithValue("@codigo_producto", codigo_producto);

                try
                {

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                    {
                        sql = "SELECT TOP 1 p.id_producto, tp.codigo FROM producto AS p" +
                            "INNER JOIN tipo_producto AS tp ON p.tipo = tp.tipo" +
                            "ORDER BY id_producto DESC;";
                        cmd = new SqlCommand(sql, conexion.conn);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if(reader.Read())
                        {
                            id_producto = reader.GetString(0);
                            tipo_producto_cod = reader.GetString(1);
                        }
                        codigo_producto = genCode(nombre, tipo_producto_cod , id_producto);
                        sql = "UPDATE producto SET codigo_producto = @codigo WHERE id_producto = @id_producto";
                        cmd = new SqlCommand(sql, conexion.conn);
                        cmd.Parameters.AddWithValue("@codigo", codigo_producto);
                        cmd.Parameters.AddWithValue("@id_producto", id_producto);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        MessageBox.Show("Proveedor registrado correctamente.");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo registrar al Proveedor.");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error al registrar al proveedor: " + ex.Message);
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

        private string genCode(string nombre, string cod, string id)
        {
            string nomb = "";
            nomb += nombre[0];
            for (int i = 1, j = 1; i < nombre.Length; i++, j++)
            {
                if (nombre[i] == ' ')
                {
                    nomb = "" + nombre[0];
                }
                else
                {
                    nomb += nombre[i];
                }
            }
            return cod + '-' + nomb.Substring(0, 5).ToUpper() + '-' + id;
        }
    }
}
