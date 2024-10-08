using System.ComponentModel.DataAnnotations.Schema;

namespace TechXtra.Infrastructures.Data.Models
{
    public class ProductLike
    {
        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;
    }
}
