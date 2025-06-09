using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagmentSystem_SMS.Models
{
    public class Sale
    {
        [Key]
        public int SaleID { get; set; }

        [Required]
        public DateTime SaleDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal TotalAmount { get; set; }

        // Foreign Key

        public int? CashierID { get; set; }

        // Navigation
        [ForeignKey("CashierID")]
        public User? Cashier { get; set; }
        public ICollection<SaleItem> SaleItem { get; set; } = new List<SaleItem>();
        public DateTime Date { get; internal set; }
    }
}
