using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Home_Secuirity_Domain.Models
{
    public class Device
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        [Required]
        public string DeviceInfo { get; set; }


        [ForeignKey(nameof(HouseId))]
        public int HouseId { get; set; }  
        public House House { get; set; }
    }



}
