using System.ComponentModel.DataAnnotations;

namespace FurnitureHub.Api.Models
{
    public class FurnitureItem
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Name { get; set; } = string.Empty;

        [Required]
        [MaxLength(50)]
        public string Category { get; set; } = string.Empty;

        [Required]
        public int Price { get; set; }

        [Required]
        public int StockQuantity { get; set; }
    }
}
