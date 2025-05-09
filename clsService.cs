using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ServiceBookingSystem_Eg
{
    internal class clsService
    {
        string ServiceID, ServiceName, ServiceTypeID, ServiceImage, Description;
        int Price;
        public string sid
        {
            get
            {
                return ServiceID;
            }
            set
            {
                ServiceID = value;
            }
        }
        public string sname
        {
            get
            {
                return ServiceName;
            }
            set
            {
                ServiceName = value;
            }
        }
        public string stid
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
        public int p
        {
            get
            {
                return Price;
            }
            set
            {
                Price = value;
            }
        }
        public string simage
        {
            get
            {
                return ServiceImage;
            }
            set
            {
                ServiceImage = value;
            }
        }
        public string des
        {
            get
            {
                return Description;
            }
            set
            {
                Description = value;
            }
        }
    }
}
