using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_FIRST_PROJECT.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please enter customers name.")]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSubscribedToNewsLetterCustomer { get; set; }

        public MembershipType MembershipType { get; set; }
        [Display(Name ="Membership Type")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Date of Birth")]
        [DataType(DataType.Date)]
        [CustomValidationMin18IfAMember]
        public DateTime? BirthDate { get; set; }
    }
}