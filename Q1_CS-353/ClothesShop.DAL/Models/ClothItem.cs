namespace ClothesShop.DAL.Models
{
    public class ClothItem
    {
        public int ItemId { get; set; }
        public string ItemName { get; set; } = string.Empty;
        public int Price { get; set; }
        public int StockQuantity { get; set; }

        public override string ToString()
        {
            return $"{ItemName} (PKR {Price} - {StockQuantity} in stock)";
        }
    }
}
