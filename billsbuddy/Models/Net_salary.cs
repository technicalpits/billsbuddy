using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;

namespace billsbuddy.Models
{
    public class Net_salary
    {
        [Key]
        public int Id_net_salary { get; set; }
        [Required]
        [DisplayName("Amount")]
        [Range(0, 10000)]
        public double amount { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        public int Id_user { get; set; }
        [ForeignKey("Id_user")]
        [ValidateNever]
        public Users Users { get; set; }
    }  
}
