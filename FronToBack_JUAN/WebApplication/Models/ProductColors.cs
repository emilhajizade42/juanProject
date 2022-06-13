using System.Collections.Generic;

namespace WebApplication.Models
{
    public class ProductColors
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int ColorId { get; set; }
        public ICollection<Colors> Colors { get; set; }
        public ICollection<Product> Product { get; set; }
    }
}
