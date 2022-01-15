using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_Supplier
    {
        private string IdSupplier;
        private string NameSupplier;
        private string Address;
        private string MobilePhone;

        public string IDSUPPLIER
        {
            get
            {
                return IdSupplier;
            }
            set
            {
                IdSupplier = value;
                if (IdSupplier == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string NAMESUPPLIER
        {
            get
            {
                return NameSupplier;
            }
            set
            {
                NameSupplier = value;
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
