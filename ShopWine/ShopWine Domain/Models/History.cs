using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWine_Domain.Models
{
    public class History
    {
        public int Id { get; set; }

        public ICollection<Order> Orders { get; set; }
    }
}
