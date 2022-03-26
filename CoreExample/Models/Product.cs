using System.ComponentModel.DataAnnotations;

namespace CoreExample.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }
        public string? ProductName { get; set; }
        public Category Category { get; set; }

        
    }
}
