using System.ComponentModel.DataAnnotations;

namespace PRJ3.Models.Entities
{
    public class Orders
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime OrderDate { get; set; }
        public Guid UserId { get; set; }
        public virtual ICollection<OrderDetail> Details { get; set; }
        public virtual PaymentMethods PaymentMethods { get; set; }
        public virtual Users Users { get; set; }
    }
}
