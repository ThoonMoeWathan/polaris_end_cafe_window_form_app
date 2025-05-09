using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceBookingSystem_Eg
{
    internal class clsServiceType
    {
        string ServiceTypeID, ServiceTypeName;
        public string ServiceTName
        {
            get
            {
                return ServiceTypeName;
            }
            set
            {
                ServiceTypeName = value;
            }
        }
        public string ServiceTID
        {
            get
            {
                return ServiceTypeID;
            }
            set
            {
                ServiceTypeID = value;
            }
        }
    }
}
