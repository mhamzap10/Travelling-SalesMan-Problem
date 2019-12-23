using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_SalesMan_Problem
{
    class Route
    {
        private ArrayList cities = new ArrayList();
        public Route(ArrayList cities)

        {
            this.cities.AddRange(cities);
        }
        public ArrayList getCities()
        {
            return cities;
        }
        public double calculateTotalDistance()// it calculate the total distance between all cities
        {
            int citySize = this.cities.Count;
            Double sum = 0;
            for (int i = 0; i < citySize - 1; i++)
            {
                City currentCity = (City)this.cities[i];
                City nextCity = (City)this.cities[i + 1];
                sum += currentCity.measureDistance(nextCity);
            }
            return sum;
        }
    }
}
