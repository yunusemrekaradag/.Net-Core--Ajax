using CoreExample.Models;

namespace CoreExample
{
    public class ViewModel
    {
        public List<Category> CategoryList { get; set; }
        public List<Product> ProductList { get; set; }
        public Category Category { get; set; }
        public Product Product { get; set; }

    }
}
