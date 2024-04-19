using System.ComponentModel.DataAnnotations;

namespace PRJ3.Models.Entities
{
    public class Images
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Size { get; set; }
        public string Kindpaper { get; set; }      
        public virtual ICollection<OrderDetail> Details { get; set; }   
        //public virtual Users Users { get; set; }
    }
}
