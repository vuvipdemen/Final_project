using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_Staff
    {
        private string IdStaff;
        private string NameStaff;
        private string Gender;
        private string DoB;
        private string MobilePhone;
        private string Address;
        private string ghichu;
        private string maca;
        private string macv;

        public string IDSTAFF
        {
            get
            {
                return IdStaff;
            }
            set
            {
                IdStaff = value;
                if (IdStaff == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string NAMESTAFF
        {
            get
            {
                return NameStaff;
            }
            set
            {
                NameStaff = value;
            }
        }
        public string GENDER
        {
            get
            {
                return Gender;
            }
            set
            {
                Gender = value;
            }
        }
        public string DOB
        {
            get
            {
                return DoB;
            }
            set
            {
                DoB = value;
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
    }
}
