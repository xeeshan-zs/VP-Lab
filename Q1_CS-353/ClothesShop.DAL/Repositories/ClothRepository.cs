using System;
using System.Collections.Generic;
using System.Data;
using Microsoft.Data.SqlClient;
using ClothesShop.DAL.Data;
using ClothesShop.DAL.Models;

namespace ClothesShop.DAL.Repositories
{
    public class ClothRepository
    {
        public List<ClothItem> GetAllItems()
        {
            var items = new List<ClothItem>();
            string query = "SELECT ItemId, ItemName, Price, StockQuantity FROM ClothItems ORDER BY ItemName ASC";

            try
            {
                using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                items.Add(new ClothItem
                                {
                                    ItemId = reader.GetInt32(0),
                                    ItemName = reader.GetString(1),
                                    Price = reader.GetInt32(2),
                                    StockQuantity = reader.GetInt32(3)
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving cloth items: {ex.Message}", ex);
            }

            return items;
        }

        public ClothItem? GetItemById(int itemId)
        {
            string query = "SELECT ItemId, ItemName, Price, StockQuantity FROM ClothItems WHERE ItemId = @ItemId";

            try
            {
                using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = itemId;
                        conn.Open();
                        using (var reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                return new ClothItem
                                {
                                    ItemId = reader.GetInt32(0),
                                    ItemName = reader.GetString(1),
                                    Price = reader.GetInt32(2),
                                    StockQuantity = reader.GetInt32(3)
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error retrieving cloth item by ID: {ex.Message}", ex);
            }

            return null;
        }

        public void UpdateStock(int itemId, int newStock)
        {
            string query = "UPDATE ClothItems SET StockQuantity = @StockQuantity WHERE ItemId = @ItemId";

            try
            {
                using (var conn = new SqlConnection(DatabaseHelper.ConnectionString))
                {
                    using (var cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.Add("@StockQuantity", SqlDbType.Int).Value = newStock;
                        cmd.Parameters.Add("@ItemId", SqlDbType.Int).Value = itemId;

                        conn.Open();
                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected == 0)
                        {
                            throw new Exception($"No item found with ID {itemId} to update stock.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Error updating stock in database: {ex.Message}", ex);
            }
        }
    }
}
