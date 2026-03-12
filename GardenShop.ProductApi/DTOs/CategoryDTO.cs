using GardenShop.ProductApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GardenShop.ProductApi.DTOs
{
    public class CategoryDTO
    {
        public int CategoryId { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(50)]
        public string? Name { get; set; }
        public ICollection<Product>? Products { get; set; }
    }
}
