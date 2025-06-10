using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SupermarketManagmentSystem_SMS.Models
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }

        [MaxLength(100)]
        public required string Name { get; set; }
        public string? Description { get; set; }

        public ICollection<Product> Products { get; set; } = new List<Product>();
    }
}
