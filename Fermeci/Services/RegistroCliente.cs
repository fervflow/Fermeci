using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Fermeci.Database;

namespace Fermeci.Services
{
    internal class RegistroCliente
    {
        private Conexion conexion;

        public RegistroCliente()
        {
            conexion = new Conexion();
        }

        public void Registrar(string nombres, string apellidos, string ci, string direccion, string telefono)
        {
            conexion.abrirConexion();
            try
            {
                string sql = "INSERT INTO cliente (nombres, apellidos, ci, direccion, telefono) VALUES (@Nombres, @Apellidos, @CI , @Direccion, @Telefono)";
                SqlCommand cmd = new SqlCommand(sql, conexion.conn);
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
                    MessageBox.Show("Error al registrar al cliente: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error inesperado: " + ex.Message);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error inesperado: " + ex.Message);
            }

            finally
            {
                conexion.cerrarConexion();
            }
        }
    }
}
