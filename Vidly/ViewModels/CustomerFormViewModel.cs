﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; } //plural as iteration, collection
        public Customer Customer { get; set; } //re-use from the domain model reference

        public string TitleCustomer
        {
            get
            {
                return (Customer.Id != 0) ? "Edit Customer" : "New Customer";
            }
        }
    }
}