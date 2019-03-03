using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasnov_3
{
    public class Location
    {
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string X_WGS { get; set; }
        public string Y_WGS { get; set; }
        public List<Coordinates> listCoord = new List<Coordinates>();

        public Location(string admArea, string district, string x_WGS, string y_WGS)
        {
            AdmArea = admArea;
            //District = district;
            listCoord.Add(new Coordinates(district, x_WGS, y_WGS));
        }

        public List<Coordinates> GetCoodinatesFromOneArea(string nameArea, string x_WGS, string y_WGS)
        {
            List<Coordinates> coordFromArea = new List<Coordinates>();
            for (int i = 0; i < listCoord.Count; i++)
            {
                if (listCoord[i].District == nameArea)
                    coordFromArea.Add(new Coordinates(listCoord[i].X_WGS, listCoord[i].Y_WGS));
            }
            return coordFromArea;
        }

        public override string ToString()
        {
            return $"   Location: Area:{AdmArea}";
        }
    }
}
