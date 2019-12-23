using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_SalesMan_Problem
{
    public class City
    {
        public static readonly double EARTH_EQUATORIAL_RADIUS = 6378.1370D;
        public static readonly double CONVERT_DEGREES_TO_RADIANS = Math.PI / 180D;
        public static readonly double CONVERT_KM_TO_MILES = 0.621371;
        private double longitude;
        private double latitude;
        private string name;
        public City(string name, double latitude, double longitude)
        {
            this.name = name;
            this.longitude = longitude * CONVERT_DEGREES_TO_RADIANS;
            this.latitude = latitude * CONVERT_DEGREES_TO_RADIANS;
        }
        public string getName() { return name; }
        public double getLatitude() { return this.latitude; }
        public double getLongitude() { return this.longitude; }
        public double measureDistance(City city)
        {
            double deltaLongitude = (city.getLongitude() - this.getLongitude());
            double deltaLatitude = (city.getLatitude() - this.getLatitude());
            double a = Math.Pow(Math.Sin(deltaLatitude / 2D), 2D) + Math.Cos(this.getLatitude()) * Math.Cos(city.getLatitude()) * Math.Pow(Math.Sin(deltaLongitude / 2D), 2D);
            return CONVERT_KM_TO_MILES * EARTH_EQUATORIAL_RADIUS * 2D * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1D - a));
        }
    }
}
