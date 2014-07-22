﻿using System;

namespace CustoDN.Domain
{
    public class Customer
    {
        public Customer()
        { Id = Guid.NewGuid(); }

        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string BillingAddress { get; set; }

        public override int GetHashCode()
        {
            return Id.GetHashCode();
        }

        //I couldn't get the TimeStamp comparison to work because for some reason they're always a few milliseconds off. 
        public override bool Equals(object obj)
        {
            var customer = obj as Customer;
            return customer != null && (Id == customer.Id
                                    && FirstName == customer.FirstName
                                    && LastName == customer.LastName
                                    && CompanyName == customer.CompanyName
                                    && Email == customer.Email
                                    && Phone == customer.Phone
                                    && BillingAddress == customer.BillingAddress);
        }
    }
}
