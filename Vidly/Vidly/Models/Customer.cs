using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        //properties
        public int Id { get; set; }
        [Required]
        [StringLength(26)]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        public DateTime? Birthdate { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        //methods
        //get full name
        public string Name { get { return $"{FirstName} {LastName}"; } }

        //check if birthdate is set
        public bool BirthdateIsSet() { return Birthdate != null; }

        //get birthdate in preset or custom format
        public string BirthdateToString(string format = "yyyy/MM/dd") { 
            if(BirthdateIsSet())
                return ((DateTime)Birthdate).ToString(format);
            return "NAN";
        }
    }
}