using System;
using System.Collections.Generic;
using System.Data.SqlClient;

namespace Model
{
    /// <summary>
    /// Products 
    /// </summary>
    public static class Products
    {
        /// <summary>
        /// Connection String
        /// </summary> 
        private const string connectionString = @"Data Source=localhost\SQLEXPRESS; Initial Catalog=shop; Integrated Security=SSPI";

        /// <summary>
        /// Get all products from the database
        /// </summary>
        public static List<Product> GetAll()
        {
            var productList = new List<Product>();
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM products", connection);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var product = new Product()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            Stock = reader.GetInt32(3)
                        };
                        productList.Add(product);
                    }

                }
            }
            return productList;
        }

        /// <summary>
        /// Get single product from the database by id
        /// </summary>
        public static Product Get(int id)
        {
            Product product = null;
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("SELECT * FROM products WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id);
                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        product = new Product()
                        {
                            Id = reader.GetInt32(0),
                            Name = reader.GetString(1),
                            Price = reader.GetDecimal(2),
                            Stock = reader.GetInt32(3)
                        };
                    }

                }
            }
            return product;
        }

        /// <summary>
        /// Add single product to the database
        /// </summary>
        public static void Add(Product product)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("INSERT INTO products (Name, Price, Stock) VALUES (@name, @price, @stock)", connection);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Update singe product in the database
        /// </summary>
        public static void Update(Product product)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("UPDATE products SET Name=@name, Price=@price, Stock=@stock WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", product.Id);
                command.Parameters.AddWithValue("@name", product.Name);
                command.Parameters.AddWithValue("@price", product.Price);
                command.Parameters.AddWithValue("@stock", product.Stock);
                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// Delete a product from the database by Id
        /// </summary>
        public static bool Delete(int id)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                var command = new SqlCommand("DELETE FROM products WHERE Id=@id", connection);
                command.Parameters.AddWithValue("@id", id.ToString());
                connection.Open();
                return command.ExecuteNonQuery() > 0;
            }
        }

    }
}
