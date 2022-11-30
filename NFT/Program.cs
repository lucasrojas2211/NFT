using NFT;
using System;
using System.Data.SqlClient;

namespace ConnectionStrings
{

    class Program
    {
        static void Main(string[] args)
        {
            String connectionString = "Server=sql.bsite.net\\MSSQL2016;Database=lucasrojas_ ;User Id=lucasrojas_;Password=Lun4Roj4;";
            try
            {
               
                Console.WriteLine("Creando la conexxión");
                using (SqlConnection sqlConnection = new SqlConnection(connectionString))
                   
                {
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Usuario ", sqlConnection))
                    {

                        
                        List<Usuario> Lista = new List<Usuario>();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())

                                {
                                    Usuario usuario = new Usuario();
                                    usuario.Id = long.Parse(reader["Id"].ToString());
                                    usuario.Nombre = reader.GetString(1);
                                    usuario.Apellido = reader.GetString(2);
                                    usuario.NombreUsuario = reader.GetString(3);
                                    usuario.Contrasenia = reader.GetString(4);
                                    usuario.Mail = reader.GetString(5);

                                    Lista.Add(usuario);
                                }
                                Console.WriteLine("Imprimir Lista Usuario ");
                                foreach (Usuario usuario in Lista)
                                {
                                    Console.WriteLine("Id " + usuario.Id);
                                    Console.WriteLine("Nombre " + usuario.Nombre);
                                    Console.WriteLine("Apellido " + usuario.Apellido);
                                    Console.WriteLine("NombreUsuario " + usuario.NombreUsuario);
                                    Console.WriteLine("Contrasenia " + usuario.Contrasenia);
                                    Console.WriteLine("Mail" + usuario.Mail);






                                }

                            }
                            else
                            {
                                Console.WriteLine("no tiene registros...");
                            }
                        }

                        sqlConnection.Close();
                    }

                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Producto ", sqlConnection))
                    {


                        List<Producto> Lista = new List<Producto>();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())

                                {
                                    Producto producto = new Producto();
                                    producto.Id = long.Parse(reader["Id"].ToString());
                                   
                                    producto.Descripciones = reader.GetString(1);

                                    producto.Costo = reader["Costo"].ToString();



                                    producto.PrecioVenta = reader["PrecioVenta"].ToString();

                                    producto.Stock = reader["Stock"].ToString();

                                    producto.IdUsuario = reader["IdUsuario"].ToString();

                                    Lista.Add(producto);
                                }
                                Console.WriteLine("Imprimir Lista Producto");
                                foreach (Producto producto in Lista)
                                {
                                    Console.WriteLine("Id " + producto.Id);
                                    Console.WriteLine("Descripciones " + producto.Descripciones);
                                    Console.WriteLine("Costo " + producto.Costo);
                                   Console.WriteLine("PrecioVenta " + producto.PrecioVenta);
                                    Console.WriteLine("Stock " + producto.Stock);
                                    Console.WriteLine("IdUsuario " + producto.IdUsuario);






                                }

                            }
                            else
                            {
                                Console.WriteLine("no tiene registros...");
                            }

                           




                        }




                        sqlConnection.Close();




                    }
                    sqlConnection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM Venta ", sqlConnection))
                    {

                        sqlConnection.Open();
                        List<Venta> Lista = new List<Venta>();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())

                                {
                                    Venta venta = new Venta();

                                    venta.Comentarios = reader["Comentarios"].ToString();



                                    venta.IdUsuarios = reader["IdUsuarios"].ToString();




                                    Lista.Add(venta);
                                }
                                Console.WriteLine("Imprimir Lista Ventas");
                                foreach (Venta venta in Lista)
                                {
                                    Console.WriteLine("Comentarios " + venta.Comentarios);

                                    Console.WriteLine("IdUsuario " + venta.IdUsuarios);
                                   

                                }

                            }
                            else
                            {
                                Console.WriteLine("no tiene registros...");
                            }
                        }

                        sqlConnection.Close();
                    }
                    sqlConnection.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT * FROM ProductoVendido ", sqlConnection))
                    {

                       
                        List<ProductoVendido> Lista = new List<ProductoVendido>();
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.HasRows)
                            {
                                while (reader.Read())

                                {
                                    ProductoVendido productovendido = new ProductoVendido();

                                    productovendido.Stock = reader["Stock"].ToString();



                                    productovendido.IdProducto = reader["IdProducto"].ToString();
                                    
                                    productovendido.IdVenta = reader["IdVenta"].ToString();



                                    Lista.Add(productovendido);
                                }
                                Console.WriteLine("Imprimir Lista Productos Vendidos");
                                foreach (ProductoVendido productovendido in Lista)
                                {
                                    Console.WriteLine("Stock " + productovendido.Stock);

                                    Console.WriteLine("IdProducto " + productovendido.IdProducto);

                                    Console.WriteLine("IdVenta " + productovendido.IdVenta);

                                   

                                }

                            }
                            else
                            {
                                Console.WriteLine("no tiene registros...");
                            }
                        }

                        sqlConnection.Close();
                    }
                }



                    
               
            }

            catch (Exception ex)

            {
                Console.WriteLine(ex.Message);

            }

          


        }
    }



}