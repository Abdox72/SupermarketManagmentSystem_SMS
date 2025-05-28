using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SupermarketManagmentSystem_SMS.Utilities;

namespace SupermarketManagmentSystem_SMS.Models
{
    public class User
    {
        public int ID { get; set; }

        [MaxLength(30)]
        public required string FirstName { get; set; }        
        [MaxLength(30)]
        public required string LastName { get; set; }

        public required string NationalID{ get; set; }

        public required string PasswordHash { get; set; }

        public UserRole Role { get; set; } = UserRole.Cashier;

        public ICollection<Sale> Sales { get; set; } = new List<Sale>();

        public ICollection<Cart> Carts { get; set; } = new List<Cart>(); 

    }
}
