﻿using System;
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

        [Display(Name = "Membership Type")]
        public byte MembershipTypeId { get; set; } //Foreign Key for MembershipType

        [Display(Name =  "Date of Birth - ex: 1 Jan 2000")] 
        [Min18YearsIfAMember]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString ="{0:d MMM yyyy}")]
        public DateTime? Birthdate { get; set; }

    }
}