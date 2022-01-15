using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_Unit
    {
        private string IdUnit;
        private string NameUnit;

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
        public string NAMEUNIT
        {
            get
            {
                return NameUnit;
            }
            set
            {
                NameUnit = value;
            }
        }
    }
}
