using CrudWithoutOrm.Common;
using System.Data.SqlClient;

/// <summary>
/// Task "CRUD without ORM" namespace.
/// </summary>
namespace CrudWithoutOrm.Data
{
    /// <summary>
    /// Task "CRUD without ORM" database class
    /// </summary>
    public class ProductData
    {
        /// <summary>
        /// Get All Products
        /// </summary>
        /// <returns>Return Products Collection</returns>
        public List<Product> GetAll()
        { 
            List<Product> products = new List<Product>();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [Products]", connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    // return false, when thera are no more records in the database
                    while (reader.Read())
                    { 
                        Product product = new Product
                        (
                            id: reader.GetInt32(0), // Id
                            name: reader.GetString(1), // Name
                            price: reader.GetDecimal(2), // Price
                            stock: reader.GetInt32(3) // Stock
                        );

                        products.Add(product);
                    }

                } // Dispose Sql Data Reader

            } // Dispose Sql Connection

            return products;
        }

        /// <summary>
        /// Get Single Product
        /// </summary>
        /// <param name="id">Identifyer</param>
        /// <returns>Product</returns>
        public Product Get(int id) 
        {
            Product product = new Product();

            using (SqlConnection connection = Database.GetConnection())
            {
                connection.Open();

                SqlCommand command = new SqlCommand("SELECT * FROM [Products] WHERE [Id]=@Id", connection);
                
                // Using parameter saves us from SQL injenctions
                command.Parameters.AddWithValue("id", id);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if(reader.Read())
                    {
                        product = new Product
                        (
                            id: reader.GetInt32(0), // Id
                            name: reader.GetString(1), // Name
                            price: reader.GetDecimal(2), // Price
                            stock: reader.GetInt32(3) // Stock
                        );
                    }

                } // Dispose Sql Data Reader

            } // Dispose Sql Connection

            return product;
        }

        /// <summary>
        /// Add Product
        /// </summary>
        /// <param name="product">Product</param>
        public void Add(Product product)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                // SQL
                SqlCommand command = new SqlCommand("INSERT INTO [Products] ([Name],[Price],[Stock]) VALUES(@Name,@Price,@Stock)", connection);

                // Using parameter saves us from SQL injenctions
                command.Parameters.AddWithValue("Name", product.Name);
                command.Parameters.AddWithValue("Price", product.Price);
                command.Parameters.AddWithValue("Stock", product.Stock);

                // Open, Execute and Close
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            } // Dispose Sql Connection
        }

        /// <summary>
        /// Update Product
        /// </summary>
        /// <param name="product">Product</param>
        public void Update(Product product)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                // SQL
                SqlCommand command = new SqlCommand("UPDATE [Products] SET [Name]=@Name,[Price]=@Price,[Stock]=@Stock WHERE [Id]=@Id", connection);

                // Using parameter saves us from SQL injenctions
                command.Parameters.AddWithValue("Id", product.Id);
                command.Parameters.AddWithValue("Name", product.Name);
                command.Parameters.AddWithValue("Price", product.Price);
                command.Parameters.AddWithValue("Stock", product.Stock);

                // Open, Execute and Close
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            } // Dispose Sql Connection
        }

        /// <summary>
        /// Delete Product
        /// </summary>
        /// <param name="product">Product</param>
        public void Delete(int id)
        {
            using (SqlConnection connection = Database.GetConnection())
            {
                // SQL
                SqlCommand command = new SqlCommand("DELETE [Products] WHERE [Id]=@Id", connection);

                // Using parameter saves us from SQL injenctions
                command.Parameters.AddWithValue("Id", id);

                // Open, Execute and Close
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();

            } // Dispose Sql Connection
        }
    }
}
