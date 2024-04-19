using System.ComponentModel.DataAnnotations;

namespace PRJ3.Models.Entities
{
    public class PaymentMethods
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string CardNumber { get; set; }
        public string Cvv { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        //public virtual Users Users { get; set; }
    }
}
