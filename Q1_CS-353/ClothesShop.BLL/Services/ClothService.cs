using System;
using System.Collections.Generic;
using ClothesShop.DAL.Models;
using ClothesShop.DAL.Repositories;

namespace ClothesShop.BLL.Services
{
    public class ClothService
    {
        private readonly ClothRepository _clothRepository;

        public ClothService()
        {
            _clothRepository = new ClothRepository();
        }

        public List<ClothItem> GetAvailableItems()
        {
            return _clothRepository.GetAllItems();
        }

        public ClothItem GetItemDetails(int itemId)
        {
            var item = _clothRepository.GetItemById(itemId);
            if (item == null)
            {
                throw new KeyNotFoundException($"Cloth item with ID {itemId} not found.");
            }
            return item;
        }

        public void PurchaseItem(int itemId, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Purchase quantity must be greater than zero.");
            }

            var item = _clothRepository.GetItemById(itemId);
            if (item == null)
            {
                throw new KeyNotFoundException($"Cloth item with ID {itemId} not found.");
            }

            int newStock = item.StockQuantity + quantity;
            _clothRepository.UpdateStock(itemId, newStock);
        }

        public void SellItem(int itemId, int quantity)
        {
            if (quantity <= 0)
            {
                throw new ArgumentException("Sale quantity must be greater than zero.");
            }

            var item = _clothRepository.GetItemById(itemId);
            if (item == null)
            {
                throw new KeyNotFoundException($"Cloth item with ID {itemId} not found.");
            }

            if (item.StockQuantity < quantity)
            {
                throw new InvalidOperationException($"Insufficient stock for '{item.ItemName}'. Available stock is {item.StockQuantity}, but tried to sell {quantity}.");
            }

            int newStock = item.StockQuantity - quantity;
            _clothRepository.UpdateStock(itemId, newStock);
        }
    }
}
