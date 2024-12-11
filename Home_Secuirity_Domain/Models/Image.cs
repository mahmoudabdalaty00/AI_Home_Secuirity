using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Secuirity_Domain.Models
{
    public class Image
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string URl { get; set; }



        [ForeignKey(nameof(UserId))]
        public int UserId { get; set; }
        public User User { get; set; }
    }

}
