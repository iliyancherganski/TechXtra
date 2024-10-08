using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechXtra.Infrastructures.Data.Models
{
    public class Client
    {
        [Key]
        public Guid Id { get; set; }

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

        public decimal ClientBalance{ get; set; }


        public List<ClientOrder> ClientOrders { get; set; } = new List<ClientOrder>();
        public List<ProductShoppingCart> ProductShoppingCarts { get; set; } = new List<ProductShoppingCart>();
        public List<ProductLike> ProductLikes { get; set; } = new List<ProductLike>();
    }
}
