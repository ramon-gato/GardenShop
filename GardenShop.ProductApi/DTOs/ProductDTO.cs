using GardenShop.ProductApi.Models;
using System.ComponentModel.DataAnnotations;

namespace GardenShop.ProductApi.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(3)]
        [MaxLength(50)]
        public string? Name { get; set; }

        [Required(ErrorMessage = "The Price is Required")]

        public decimal Price { get; set; }

        [Required(ErrorMessage = "The Name is Required")]
        [MinLength(5)]
        [MaxLength(200)]
        public string? Descripton { get; set; }

        [Required(ErrorMessage = "The Stock is Required")]
        [Range(1, 9999)]
        public long Stock { get; set; }
        public string? ImageUrl { get; set; }

        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
