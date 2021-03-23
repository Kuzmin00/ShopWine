﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopWine_Domain.Models
{

    public class Category
    {
        
        public int Id { get; set; }
        public string Name { get; set; }

        public Product Product { get; set; }
        public int? ProductId { get; set; }
    }
}
