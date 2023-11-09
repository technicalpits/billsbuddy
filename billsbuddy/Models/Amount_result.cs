using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace billsbuddy.Models
{
    public class Amount_result
    {
        [Key]
        public int Id_amt_result { get; set; }
        public double grocery { get; set; }
        public double emergency_money { get; set; }
        public double eat_outside { get; set; }
        public double house { get; set; }
        public double donation { get; set; }
        public double petrol { get; set; }
        public double utility { get; set; }
        public double car { get; set; }
        public double saving { get; set; }
        public DateTime Date { get; set; }

        public int Id_user { get; set; }
        [ForeignKey("Id_user")]
        [ValidateNever]
        public Users Users { get; set; }
    }
}
