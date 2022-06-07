using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Vidly.Models;

//data transfer objects are used to pass objects in api's for extra safetly
namespace Vidly.Dtos
{
    public class CustomerDto
    {
        //properties
        public int Id { get; set; }

        [Required]
        [StringLength(26)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(40)]
        public string LastName { get; set; }

        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public byte MembershipTypeId { get; set; }
    }
}