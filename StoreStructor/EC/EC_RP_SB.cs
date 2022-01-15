using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_RP_SB
    {
        private string IdSB;
        private string IdProduct;
        private string Quantity;
        private string TotalMoney;

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
