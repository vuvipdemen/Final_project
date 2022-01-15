using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace StoreManager.StoreStructor.EC
{
    class EC_Sector
    {
        private string IdSector;
        private string NameSector;

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
        public string NAMESECTOR
        {
            get
            {
                return NameSector;
            }
            set
            {
                NameSector = value;
            }
        }
    }
}
