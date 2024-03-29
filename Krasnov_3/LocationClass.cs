﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Krasnov_3
{
    public class LocationClass
    {
        public string AdmArea { get; set; }
        public string District { get; set; }
        public string X_WGS { get; set; }
        public string Y_WGS { get; set; }
        public static List<Coordinates> listCoord = new List<Coordinates>();

        public LocationClass() { }

        public LocationClass(string admArea, string district, string x_WGS, string y_WGS)
        {
            X_WGS = x_WGS;
            Y_WGS = y_WGS;
            AdmArea = admArea;
            District = district;

            Coordinates temp = new Coordinates(district, x_WGS, y_WGS);
            if (!listCoord.Contains(temp))
                listCoord.Add(temp);
        }
        
        /// <summary>
        /// Возвращает список координат (x, y), принадлежащих одному району.
        /// </summary>
        /// <param name="nameDistrict">имя района</param>
        /// <returns></returns>
        public static List<Coordinates> GetCoodinatesFromOneArea(string nameDistrict)
        {
            List<Coordinates> coordFromArea = new List<Coordinates>();
            for (int i = 0; i < listCoord.Count; i++)
            {
                if (listCoord[i].District == nameDistrict)
                    coordFromArea.Add(new Coordinates(nameDistrict, listCoord[i].X_WGS, listCoord[i].Y_WGS));
            }
            return coordFromArea;
        }

        public override string ToString()
        {
            return $"{AdmArea}; {District}; {X_WGS}; {Y_WGS};";
        }
    }
}
