using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWine_Domain.Models
{
    public class Order
    {
        public int Id { get; set; }

        public DateTime TimeOfOrder { get; set; }
        public string Status { get; set; }
        public bool IsRemove { get; set; }
        public List<Product> Products { get; set; }
        public User User { get; set; }
    }
}
