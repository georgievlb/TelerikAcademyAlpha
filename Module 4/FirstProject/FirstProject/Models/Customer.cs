using System.ComponentModel.DataAnnotations;
using System;

namespace FirstProject.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)] //the process of applying attributes in order to override the EF conventions is called data annotations
        //the other approach is called Fluent API
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }  //navigation property - navigate from customer to their membership type

        //we don't need the whole MembershipType object, only its foreign key:
        [Display(Name = "Membership Type")]
        public int MembershipTypeId { get; set; }  //this property is treated as a foreign key
        
        [Display(Name = "Date of Birth")]
        public DateTime? Birthdate { get; set; }
    }
}