using System;
using System.Collections.Generic;

namespace WebApplication.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public int? DiscountPercent { get; set; }
        public string Description { get; set; } 
        public bool? IsInStock { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? UpdatedAt { get; set; }
        public bool? IsNew { get; set; }
        public ProductColors Color { get; set; }
        public ICollection<ProductImages> ProductImages { get; set; }
        public ProductCategory ProductCategory { get; set; }
    }
}
