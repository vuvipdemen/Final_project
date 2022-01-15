using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_IB
    {
        private string IdIB;
        private string IdStaff;
        private string ngaynhan;
        private string IdSupplier;
        private string tongtien;

        public string IDIB
        {
            get
            {
                return IdIB;
            }
            set
            {
                IdIB = value;
                if (IdIB == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string IDStaff
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
        public string NGAYNHAN
        {
            get
            {
                return ngaynhan;
            }
            set
            {
                ngaynhan = value;
            }
        }
        public string IDSupplier
        {
            get
            {
                return IdSupplier;
            }
            set
            {
                IdSupplier = value;
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
