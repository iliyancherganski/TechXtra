using System.ComponentModel.DataAnnotations;

using TechXtra.Common;

namespace TechXtra.Infrastructures.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.CITY_NAME_MAX_LENGHT)]
        public string Name { get; set; } = null!;
    }
}
