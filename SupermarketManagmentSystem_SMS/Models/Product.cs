using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagmentSystem_SMS.Models
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }

        [Required]
        [MaxLength(100)]
        public required string Name { get; set; }

        //unique
        public string Barcode { get; set; } = string.Empty;


        public int? CategoryID { get; set; }
        [ForeignKey("CategoryID")]
        public Category? Category { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Price { get; set; }

        [Required]
        public int Quantity { get; set; }

        public string? ImagePath { get; set; }

        // Navigation
        public ICollection<SaleItem> SaleDetails { get; set; } = new List<SaleItem>();
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    }
}
