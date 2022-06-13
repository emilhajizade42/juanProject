using System.Collections.Generic;

namespace WebApplication.Models
{
    public class ProductCategory
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public ICollection<Product> Products { get; set; }
        public ICollection<Category> Category { get; set; }
    }
}
