using System;

namespace Krasnov_3
{
    public class Headquarter
    {       
        public int ROWNUM { get; set; }
        public string Name { get; set; }
        //public string AdmArea { get; set; }
       // public string District { get; set; }
        public string Address { get; set; }
        public string PublicPhone { get; set; }
        public string ExtraInfo { get; set; }
        //public string X_WGS { get; set; }
        //public string Y_WGS { get; set; }
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

        // если будут " " в начале слова и конце
        /*public Headquarter(params string[] args)
        {
            if (args.Length != 11)
                throw new ArgumentException("Должно быть 11 столбцов!");
            ROWNUM = int.Parse(args[0]);
            Name = GetNormalString(args[1]);
            Address = GetNormalString(args[4]);
            PublicPhone = GetNormalString(args[5]);
            ExtraInfo = GetNormalString(args[6]);
            GLOBALID = GetNormalString(args[9]);
            GeoLocation = new Location(GetNormalString(args[2]), GetNormalString(args[3]),
                GetNormalString(args[7]), GetNormalString(args[8]));
        }

        private string GetNormalString(string str)
        {
            return str.Substring(1, str.Length - 2);            
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

        public string this[int index]
        {
            get
            {
                switch(index)
                {
                    case 0: return ROWNUM.ToString();
                    case 1: return Name;
                    case 2: return GeoLocation.AdmArea;
                    case 3: return GeoLocation.listCoord[0].District;
                    case 4: return Address;
                    case 5: return PublicPhone;
                    case 6: return ExtraInfo;
                    case 7: return GeoLocation.listCoord[0].X_WGS;
                    case 8: return GeoLocation.listCoord[0].Y_WGS;
                    case 9: return GLOBALID;
                    default: return "-1";
                }

            }
        }
        public override string ToString()
        {
            return $"ROWNUM:{ROWNUM}, Name:{Name}, {Address}, {PublicPhone}, {ExtraInfo}, {GLOBALID}, {GeoLocation}";
        }
    }
}
