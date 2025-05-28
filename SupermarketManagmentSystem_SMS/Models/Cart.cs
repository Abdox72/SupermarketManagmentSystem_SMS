using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Menu;

namespace SupermarketManagmentSystem_SMS.Models
{
    public class Cart
    {
        [Key]
        public int CartID { get; set; }


        public int UserID { get; set; }

        [ForeignKey("UserID")]
        public required User User { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
        
        public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();

    }
}
