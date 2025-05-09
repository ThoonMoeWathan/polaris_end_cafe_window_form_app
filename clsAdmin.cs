using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceBookingSystem_Eg
{
    internal class clsAdmin
    {
        string AdminID, AdminName, UserName, Password, EmailAdds, PhoneNum, Address;
        public string AdID
        {
            get
            {
                return AdminID;
            }
            set
            {
                AdminID = value;
            }
        }
        public string AdName
        {
            get
            {
                return AdminName;
            }
            set
            {
                AdminName = value;
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
                return EmailAdds;
            }
            set
            {
                EmailAdds = value;
            }
        }
        public string PN
        {
            get
            {
                return PhoneNum;
            }
            set
            {
                PhoneNum = value;
            }
        }
        public string Adds
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
