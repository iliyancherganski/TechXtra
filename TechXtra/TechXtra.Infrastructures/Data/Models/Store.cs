using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using TechXtra.Common;

namespace TechXtra.Infrastructures.Data.Models
{
    public class Store
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        [MaxLength(ValidationConstants.ADDRESS_MAX_LENGHT)]
        public string StoreAddress { get; set; } = null!;

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City City { get; set; } = null!;

        public List<Employee> Employees { get; set; } = new List<Employee>();

        public List<IndividualProduct> IndividualProducts { get; set; } = new List<IndividualProduct>();

    }
}
