using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechXtra.Infrastructures.Data.Models
{
    public class Employee
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

        [ForeignKey(nameof(Store))]
        public Guid? StoreId { get; set; }
        public Store? Store { get; set; }
    }
}
