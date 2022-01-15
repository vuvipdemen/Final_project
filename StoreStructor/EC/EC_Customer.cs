using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{ 
    class EC_Customer
    {
        private string IdCustomer;
        private string NameCustomer;
        private string Address;
        private string MobilePhone;

        public string IDCustomer
        {
            get
            {
                return IdCustomer;
            }
            set
            {
                IdCustomer = value;
                if (IdCustomer == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string NAMECUSTOMER
        {
            get
            {
                return NameCustomer;
            }
            set
            {
                NameCustomer = value;
            }
        }
        public string ADDRESS
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
        public string MOBILEPHONE
        {
            get
            {
                return MobilePhone;
            }
            set
            {
                MobilePhone = value;
            }
        }
    }
}
