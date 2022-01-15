using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_Product
    {
        private string IdProduct;
        private string NameProduct;
   
        private string IdSector;
        private string IdUnit;
      
  
        private string Quantity;
        private string PriceI;
        private string PriceS;
        private string thoaigianbh;


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
        public string NAMEPRODUCT
        {
            get
            {
                return NameProduct;
            }
            set
            {
                NameProduct = value;
            }
        }

        public string IDSECTOR
        {
            get
            {
                return IdSector;
            }
            set
            {
                IdSector = value;
                if (IdSector == "")
                {
                    throw new Exception("Mã không được bỏ trống");
                }
            }
        }
        public string IDUNIT
        {
            get
            {
                return IdUnit;
            }
            set
            {
                IdUnit = value;
                if (IdUnit == "")
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
        public string PRICEI
        {
            get
            {
                return PriceI;
            }
            set
            {
                PriceI = value;
            }
        }
        public string PRICEs
        {
            get
            {
                return PriceS;
            }
            set
            {
                PriceS = value;
            }
        }
        public string THOAIGIANBH
        {
            get
            {
                return thoaigianbh;
            }
            set
            {
                thoaigianbh = value;
            }
        }
    }
}
