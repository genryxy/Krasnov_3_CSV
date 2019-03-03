using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasnov_3
{
    public class Headquarter
    {       
        public string ROWNUM { get; set; }
        public string Name { get; set; }
        //public string AdmArea { get; set; }
        //public string District { get; set; }
        public string Address { get; set; }
        public string PublicPhone { get; set; }
        public string ExtraInfo { get; set; }
        //public string X_WGS { get; set; }
        //public string Y_WGS { get; set; }
        public string GLOBALID { get; set; }
        public Location GeoLocation { get; set; }

        // в отношении композиции с классом Location
        public Headquarter(string rOWNUM, string name, string address, string publicPhone, string extraInfo,
            string gLOBALID, string admArea, string district, string x_WGS, string y_WGS)
        {
            ROWNUM = rOWNUM;
            Name = name;
            Address = address;
            PublicPhone = publicPhone;
            ExtraInfo = extraInfo;
            GLOBALID = gLOBALID;
            GeoLocation = new Location(admArea, district, x_WGS, y_WGS);
        }
    }
}
