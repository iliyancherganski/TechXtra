using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TechXtra.Infrastructures.Data.Models
{
    public class IndividualProduct
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Product))]
        public Guid ProductId { get; set; }
        public Product Product { get; set; } = null!;

        [ForeignKey(nameof(Store))]
        public Guid StoreId { get; set; }
        public Store Store { get; set; } = null!;

        [Required]
        public bool IsSold { get; set; }

        [Required]
        public decimal IndividualProductPrice { get; set; }

        public List<ClientOrder> ClientOrders { get; set; } = new List<ClientOrder>();
    }
}
