﻿using System;

namespace Krasnov_3
{
    public class Headquarter
    {       
        //public int ROWNUM { get; set; } // не надо отображать
        public string Name { get; set; }
        public string Address { get; set; }
        public string PublicPhone { get; set; }
        public string ExtraInfo { get; set; }
        public string GLOBALID { get; set; }
        public LocationClass GeoLocation { get; set; }

        public Headquarter() { }

        // в отношении композиции с классом Location
        public Headquarter(params string[] args)
        {
            if (args.Length != 11)
                throw new ArgumentException("Должно быть 11 столбцов!");
            Name = args[1];
            Address = args[4];
            PublicPhone = args[5];
            ExtraInfo = args[6];
            GLOBALID = args[9];
            GeoLocation = new LocationClass(args[2], args[3], args[7], args[8]);
        }

        public string this[int index]
        {
            get
            {
                switch(index)
                {
                    case 1: return Name;
                    case 2: return GeoLocation.AdmArea;
                    case 3: return GeoLocation.District;
                    case 4: return Address;
                    case 5: return PublicPhone;
                    case 6: return ExtraInfo;
                    case 7: return GeoLocation.X_WGS;
                    case 8: return GeoLocation.Y_WGS;
                    case 9: return GLOBALID;
                    default: return "-1";
                }
            }          
        }
        public override string ToString()
        {
            return $"{Name}; {Address}; {PublicPhone}; {ExtraInfo}, {GLOBALID}; {GeoLocation}";
        }
    }
}
