using System.ComponentModel.DataAnnotations;
using System;

namespace FirstProject.Models
{
    public class MembershipType
    {
        public int Id { get; set; }    

        [Required]
        public string Name { get; set; }

        public int SignUpFee { get; set; } //

        public int DurationInMonths { get; set; }  //12 months max

        public int DiscountRate { get; set; }  //between 0-100%

        
    }
}