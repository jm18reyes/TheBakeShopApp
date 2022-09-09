using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace theBakeShopApi.Entities
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        public string ProductName { get; set; }

        [MaxLength(200)]
        public string? ProductDescription { get; set; }

        public int ProductPrice { get; set; } = 0;

        public string ImageUrl { get; set; } = string.Empty;

        public Product()
        {
        }
    }
}
