using System.ComponentModel.DataAnnotations;
using TechXtra.Common;

namespace TechXtra.Infrastructures.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.CATEGORY_NAME_MAX_LENGHT)]
        public string CategoryName { get; set; } = null!;
    }
}
