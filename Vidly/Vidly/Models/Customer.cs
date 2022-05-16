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
        public string LastName { get; set; }
        public bool IsSubscribedToNewsletter { get; set; }
        public MembershipType MembershipType { get; set; }
        public byte MembershipTypeId { get; set; }

        //methods
        public string Name { get { return $"{FirstName} {LastName}"; } }
    }
}