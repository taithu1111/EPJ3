using System.ComponentModel.DataAnnotations;

namespace PRJ3.Models.Entities
{
    public class OrderDetail
    {
        [Key]
        public Guid Id { get; set; }
        public Guid OrderId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public string InforCreditCard { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }
        public string Status { get; set; }
        public string AddressShip { get; set; }
        //public virtual PaymentMethods PaymentMethods { get; set; }
        public virtual Orders Orders { get; set; }
        public virtual Images Images { get; set; }
       
    }
}
