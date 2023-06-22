using Desafio01.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio01.Repository
{
    public class Metodos
    {
        static string connectionString = " Server =localhost, Database = SistemaGestion, Trusted_Connection = True";

        public static List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Descripciones, Costo, PrecioVenta, Stock, IdUsuario FROM Producto";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Producto producto = new Producto();
                    producto.Id = Convert.ToInt32(reader["Id"]);
                    producto.Descripcion = (string)reader["Description"];
                    producto.Costo = Convert.ToInt32(reader["Costo"]);
                    producto.PrecioVenta = Convert.ToInt32(reader["PrecioVenta"]);
                    producto.Stock = Convert.ToInt32(reader["Stock"]);
                    producto.IdUsuario = Convert.ToInt32(reader["IdUsuario"]);

                    productos.Add(producto);

                }

                connection.Close();

            }

            return productos;

        }

        public static List<ProductoVendido> ObtenerProductosVendidos()
        {
            List<ProductoVendido> productosVendido = new List<ProductoVendido>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Stock, IdProducto, IdVenta FROM ProductoVendido";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    ProductoVendido productoVendido = new ProductoVendido();
                    productoVendido.Id = Convert.ToInt32(reader["Id"]);
                    productoVendido.Stock = Convert.ToInt32(reader["Stock"]);
                    productoVendido.IdProducto = Convert.ToInt32(reader["IdProducto"]);
                    productoVendido.IdVenta = Convert.ToInt32(reader["IdVenta"]);
                    productosVendido.Add(productoVendido);

                }

                connection.Close();

            }

            return productosVendido;

        }

        public static List<Usuario> ObtenerUsuarios()
        {
            List<Usuario> usuarios = new List<Usuario>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contrasena, Mail FROM Usuario";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Usuario usuario = new Usuario();
                    usuario.Id = Convert.ToInt32(reader["Id"]);
                    usuario.Nombre = (string)reader["Nombre"];
                    usuario.Apellido = (string)reader["Apellido"];
                    usuario.NombreUsuario = (string)reader["NombreUsuario"];
                    usuario.Contraseña = (string)reader["Contrasena"];
                    usuario.Mail = (string)reader["Mail"];
                    usuarios.Add(usuario);

                }

                connection.Close();

            }

            return usuarios;

        }

        public static List<Venta> ObtenerVentas()
        {
            List<Venta> ventas = new List<Venta>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT Id, Comentarios, CantidadVentas FROM Venta";

                SqlCommand command = new SqlCommand(query, connection);

                connection.Open();

                SqlDataReader reader = command.ExecuteReader();

                while (reader.Read())
                {
                    Venta venta = new Venta();
                    venta.Id = Convert.ToInt32(reader["Id"]);
                    venta.Comentarios = (string)reader["Nombre"];
                    venta.CantidadVentas = Convert.ToInt32(reader["CantidadVentas"]);
                    ventas.Add(venta);

                }

                connection.Close();

            }

            return ventas;

        }

        public static Usuario IniciarSesion(string nombreUsuario, string contraseña)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                const string query = @"SELECT Id, Nombre, Apellido, NombreUsuario, Contrasena, Mail FROM Usuario WHERE Nombre = @nombreUsuario and Contrasena = @contraseña ";

                using (var command = new SqlCommand(query, connection))
                {

                    command.Parameters.AddWithValue("@nombreUsuario", nombreUsuario);
                    command.Parameters.AddWithValue("@contraseña", contraseña);

                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {

                            return new Usuario
                            {
                                Id = Convert.ToInt32(reader[0]),
                                Nombre = reader.GetString(1),
                                Apellido = reader.GetString(2),
                                NombreUsuario = reader.GetString(3),
                                Contraseña = reader.GetString(4),
                                Mail = reader.GetString(5),

                            };
                        }
                        else
                        {
                            return null;                        
                        }

                    }

                }
                connection.Close();
            }

        }

    }
}
