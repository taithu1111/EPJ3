using System.ComponentModel.DataAnnotations;

namespace PRJ3.Models.Entities
{
    public class Users
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public int Phone { get; set; }
        //public virtual ICollection<PaymentMethods> PaymentMethods { get; set; }
        public virtual ICollection<Orders> Orders { get; set; }
        //public virtual ICollection<Images> Images { get; set; }

    }
}
