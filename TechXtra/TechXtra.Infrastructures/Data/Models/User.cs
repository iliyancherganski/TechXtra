using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechXtra.Common;

namespace TechXtra.Infrastructures.Data.Models
{
    public class User : IdentityUser
    {
        [Required]
        [MaxLength(ValidationConstants.FIRST_NAME_USER_MAX_LENGTH)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(ValidationConstants.LAST_NAME_USER_MAX_LENGTH)]
        public string LastName { get; set; } = null!;

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City City { get; set; } = null!; 
    }
}
