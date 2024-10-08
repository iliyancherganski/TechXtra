using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;
using TechXtra.Common;

namespace TechXtra.Infrastructures.Data.Models
{
    public class Product
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.PRODUCT_NAME_MAX_LENGTH)]
        public string ProductName { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.PRODUCT_DESCRIPTION_MAX_LENGTH)]
        public string ProductDescription { get; set; } = null!;

        [ForeignKey(nameof(Category))]
        public int CategoryId { get; set; }
        public Category Category { get; set; } = null!;

        [Required]
        public decimal ProductOriginalPrice { get; set; }

        [AllowNull]
        public int? ProductDiscountPercentage{ get; set; }

        public List<IndividualProduct> IndividualProducts { get; set;} = new List<IndividualProduct>();
        public List<ProductLike> ProductLikes { get; set; } = new List<ProductLike>();
        public List<ProductShoppingCart> ProductShoppingCarts { get; set; } = new List<ProductShoppingCart>();
    }
}
