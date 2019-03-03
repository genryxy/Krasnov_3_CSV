using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasnov_3
{
    public class Headquarter
    {       
        public int ROWNUM { get; set; }
        public string Name { get; set; }
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string Address { get; set; }
        public string PublicPhone { get; set; }
        public string ExtraInfo { get; set; }
        public string X_WGS { get; set; }
        public string Y_WGS { get; set; }
        public string GLOBALID { get; set; }
        private Location GeoLocation { get; set; }

        // в отношении композиции с классом Location
        /*public Headquarter(string ROWNUM, string Name, string Address, string PublicPhone, string ExtraInfo,
            string GLOBALID, string AdmArea, string District, string X_WGS, string Y_WGS)
        {
            this.ROWNUM = ROWNUM;
            this.Name = Name;
            this.Address = Address;
            this.PublicPhone = PublicPhone;
            this.ExtraInfo = ExtraInfo;
            this.GLOBALID = GLOBALID;
            GeoLocation = new Location(AdmArea, District, X_WGS, Y_WGS);
        }*/
        public Headquarter(params string[] args)
        {
            if (args.Length != 11)
                throw new ArgumentException("Должно быть 11 столбцов!");
            ROWNUM = int.Parse(args[0]);
            Name = args[1];
            Address = args[4];
            PublicPhone = args[5];
            ExtraInfo = args[6];
            GLOBALID = args[9];
            GeoLocation = new Location(args[2], args[3], args[7], args[8]);
        }

        public override string ToString()
        {
            return $"ROWNUM:{ROWNUM}, Name:{Name}";
        }
    }
}
