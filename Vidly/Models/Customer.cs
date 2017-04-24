using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace Vidly.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required] //DataAnnotation or Attribute
        [StringLength(255)]
        public string Name { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }
        public MembershipType MembershipType { get; set; } //Navigation Property - use for relational model
        public byte MembershipTypeId { get; set; } //Foreign Key for MembershipType
        public DateTime? Birthdate { get; set; }

    }
}