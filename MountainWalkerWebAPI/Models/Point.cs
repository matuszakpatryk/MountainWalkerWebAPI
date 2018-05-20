using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MountainWalkerWebAPI.Models
{
    public class Point
    {
        public int PointID { get; set; }
        public string Name { get; set; }
        public double Latitude { get; set; }
        public double Longtitude { get; set; }

        public Point(int id, string name, double lat, double longt)
        {
            PointID = id;
            Name = name;
            Latitude = lat;
            Longtitude = longt;
        }
    }
}
