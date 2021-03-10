using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWine_Domain.Models
{
    public class Product
    {
        public int Id { get; set; }
        public ICollection<ProductProporties> ProductProporties { get; set; }

        public Product()
        {
            ProductProporties = new List<ProductProporties>();
        }
    }
}
