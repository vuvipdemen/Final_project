using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_SB
    {
        private string IdSB;
        private string IdStaff;
        private string DateSale;
        private string IdCustomer;
        private string tongtien;

        public string IDSB
        {
            get
            {
                return IdSB;
            }
            set
            {
                IdSB = value;
                if (IdSB == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
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
        public string DATESALE
        {
            get
            {
                return DateSale;
            }
            set
            {
                DateSale = value;
            }
        }
        public string IDCUSTOMER
        {
            get
            {
                return IdCustomer;
            }
            set
            {
                IdCustomer = value;
            }
        }
        public string TONGTIEN
        {
            get
            {
                return tongtien;
            }
            set
            {
                tongtien = value;
            }
        }
    }
}
