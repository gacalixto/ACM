using System;
using System.Collections.Generic;

namespace ACM.BL
{
    public class Customer : EntityBase
    {
        public Customer()
            :this(0)//<-Constructor Chaining, constructor calls another
        {
                
        }

        public Customer(int customerId)
        {
            this.CustomerId = customerId;
            AddressList = new List<Address>();//<- This help to avoid a null value exception

        }
        public int CustomerType{ get; set; }

        public static int InstanceCount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string  EmailAddress { get; set; }
        public List<Address> AddressList { get; set; }
        public int CustomerId { get; private set; }

        public string FullName
        {
            get
            {
                string fullName = LastName;
                if(!string.IsNullOrWhiteSpace(FirstName))
                {
                    if(!string.IsNullOrWhiteSpace(fullName))
                    {
                        fullName += ", ";
                    }

                    fullName += FirstName;
                }
                return fullName;

            }
        }

        public Customer Retrieve(int customerId)
        {
            return new Customer();
        }

        public List<Customer> Retrieve()
        {
            return new List<Customer>();
        }

        public bool Save()
        {
            return true;
          
        }

        public override bool Validate()
        {
            var isValid = true;
            if (string.IsNullOrWhiteSpace(LastName)) isValid = false;
            if (string.IsNullOrWhiteSpace(EmailAddress)) isValid = false;

            return isValid;
        }

        public override string ToString()
        {
            return FullName;
        }


    }
}
