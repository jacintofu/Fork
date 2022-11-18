using System.ComponentModel.DataAnnotations;

namespace Task3.Models
{
    public class Products
    {
        //[Key]
        public int Id { get; set; }
        public string Description { get; set; }
        public double Price { get; set; }
        public string Image { get; set; }
    }
}
