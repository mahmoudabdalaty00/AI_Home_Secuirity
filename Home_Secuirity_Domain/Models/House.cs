using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Secuirity_Domain.Models
{
    public class House
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string City { get; set; }
        [Required]
        public string Region { get; set; }
        [Required]
        public string PostalCode { get; set; }

        public List<Device> Devices { get; set; }

        public List<User> Users { get; set; }
       
        //[ForeignKey(nameof(UserId))]
        //public int UserId { get; set; }
        //public User User { get; set; }
    }

}
