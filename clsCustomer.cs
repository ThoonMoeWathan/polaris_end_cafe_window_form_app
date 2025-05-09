using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceBookingSystem_Eg
{
    internal class clsCustomer
    {
        string CustomerID, CustomerName, UserName, Password, EmailAddress, PhoneNumber, Address;
        public string CustrID
        {
            get
            {
                return CustomerID;
            }
            set
            {
                CustomerID = value;
            }
        }
        public string CustrName
        {
            get
            {
                return CustomerName;
            }
            set
            {
                CustomerName = value;
            }
        }
        public string UName
        {
            get
            {
                return UserName;
            }
            set
            {
                UserName = value;
            }
        }
        public string PW
        {
            get
            {
                return Password;
            }
            set
            {
                Password = value;
            }
        }
        public string Email
        {
            get
            {
                return EmailAddress;
            }
            set
            {
                EmailAddress = value;
            }
        }
        public string Phone
        {
            get
            {
                return PhoneNumber;
            }
            set
            {
                PhoneNumber = value;
            }
        }
        public string address
        {
            get
            {
                return Address;
            }
            set
            {
                Address = value;
            }
        }
        

    }
}
