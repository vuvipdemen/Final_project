using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_RP_IB
    {
        private string IdIB;
        private string IdProduct;
        private string Quantity;
        private string UnitPrice;
        private string giamgia;
        private string TotalMoney;

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
        public string IDPRODUCT
        {
            get
            {
                return IdProduct;
            }
            set
            {
                IdProduct = value;
                if (IdProduct == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string QUANTITY
        {
            get
            {
                return Quantity;
            }
            set
            {
                Quantity = value;
            }
        }
        public string UNITPRICE
        {
            get
            {
                return UnitPrice;
            }
            set
            {
                UnitPrice = value;
            }
        }

        public string TOTALMONEY
        {
            get
            {
                return TotalMoney;
            }
            set
            {
                TotalMoney = value;
            }
        }
    }
}
