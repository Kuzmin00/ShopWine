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
        public string ImagePath { get; set; }
        public decimal Price { get; set; }
        public string Name { get; set; }
        public bool IsRemove { get; set; }
        public ICollection<ProductProporties> ProductProporties { get; set; }
        public Category Category { get; set; }

        public Product()
        {
            ProductProporties = new List<ProductProporties>();
        }
    }
}
