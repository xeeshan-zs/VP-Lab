using System;
using Microsoft.Data.SqlClient;

namespace ClothesShop.DAL.Data
{
    public static class DatabaseHelper
    {
        private const string MasterConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=master;Trusted_Connection=True;TrustServerCertificate=True;";
        public const string ConnectionString = @"Server=(localdb)\MSSQLLocalDB;Database=ClothesShopDB;Trusted_Connection=True;TrustServerCertificate=True;";

        public static void InitializeDatabase()
        {
            try
            {
                // 1. Create DB if it doesn't exist
                using (var masterConn = new SqlConnection(MasterConnectionString))
                {
                    masterConn.Open();
                    string checkDbQuery = "SELECT database_id FROM sys.databases WHERE name = 'ClothesShopDB'";
                    using (var checkCmd = new SqlCommand(checkDbQuery, masterConn))
                    {
                        var result = checkCmd.ExecuteScalar();
                        if (result == null)
                        {
                            string createDbQuery = "CREATE DATABASE ClothesShopDB";
                            using (var createCmd = new SqlCommand(createDbQuery, masterConn))
                            {
                                createCmd.ExecuteNonQuery();
                            }
                        }
                    }
                }

                // 2. Create Table & Seed Data if it doesn't exist
                using (var dbConn = new SqlConnection(ConnectionString))
                {
                    dbConn.Open();
                    string checkTableQuery = "SELECT OBJECT_ID(N'dbo.ClothItems', N'U')";
                    bool tableExists = false;
                    using (var checkCmd = new SqlCommand(checkTableQuery, dbConn))
                    {
                        var result = checkCmd.ExecuteScalar();
                        if (result != DBNull.Value && result != null)
                        {
                            tableExists = true;
                        }
                    }

                    if (!tableExists)
                    {
                        // Create Table
                        string createTableQuery = @"
                            CREATE TABLE ClothItems (
                                ItemId INT IDENTITY(1,1) PRIMARY KEY,
                                ItemName NVARCHAR(100) NOT NULL,
                                Price INT NOT NULL,
                                StockQuantity INT NOT NULL
                            )";
                        using (var createCmd = new SqlCommand(createTableQuery, dbConn))
                        {
                            createCmd.ExecuteNonQuery();
                        }

                        // Seed Data
                        string seedQuery = @"
                            INSERT INTO ClothItems (ItemName, Price, StockQuantity) VALUES 
                            (N'Premium Denim Jeans', 4500, 120),
                            (N'Vibrant Graphic T-Shirt', 2000, 250),
                            (N'Classic Leather Jacket', 13000, 45),
                            (N'Cozy Woolen Sweater', 6000, 80),
                            (N'Sporty Hooded Sweatshirt', 4000, 150),
                            (N'Elegant Cotton Shirt', 3000, 200),
                            (N'Casual Cargo Shorts', 3500, 90),
                            (N'Soft Cotton Socks (5-pack)', 1000, 500)";
                        
                        using (var seedCmd = new SqlCommand(seedQuery, dbConn))
                        {
                            seedCmd.ExecuteNonQuery();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Database Initialization failed: {ex.Message}", ex);
            }
        }
    }
}
