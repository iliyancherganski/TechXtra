using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechXtra.Common;
using TechXtra.Common.Enums;

namespace TechXtra.Infrastructures.Data.Models
{
    public class ClientOrder
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(Client))]
        public Guid ClientId { get; set; }
        public Client Client { get; set; } = null!;

        [ForeignKey(nameof(IndividualProduct))]
        public Guid IndividualProductId { get; set; }
        public IndividualProduct IndividualProduct { get; set; } = null!;

        [Required]
        public OrderStatus OrderStatus { get; set; }

        public DateTime? ExpectedDeliveryDate { get; set; }

        public DateTime? ReceivedProdductDate { get; set; }

        [Required]
        [MaxLength(ValidationConstants.ADDRESS_MAX_LENGHT)]
        public string ClientAddress { get; set; } = null!;
    }
}
