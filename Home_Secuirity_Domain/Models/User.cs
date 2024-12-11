using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Secuirity_Domain.Models
{
    public class User
    {

        [Key]
        public int Id { get; set; }


        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        [Required]
        public string PhoneNumber { get; set; }
     
        //[ForeignKey(nameof(HouseId))]
        //public int HouseId { get; set; }
        //public House House { get; set; }

        public List<Image> Images { get; set; }
         
    }

}
