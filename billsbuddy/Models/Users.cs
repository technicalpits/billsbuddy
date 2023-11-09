using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace billsbuddy.Models
{
    public class Users
    {
        [Key]
        public int Id_user { get; set; }
        [Required]
        [MaxLength(30)]
        [DisplayName("Email")]
        public string email { get; set; }
        [MaxLength(30)]
        [DisplayName("Password")]
        public string password { get; set; }
        [MaxLength(30)]
        [DisplayName("Phone Number")]
        public string phone { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
    }
}
