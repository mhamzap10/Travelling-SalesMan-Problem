using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_SalesMan_Problem
{
    class NearestNeighbour
        
    {
        public ShortestPath display;
        public NearestNeighbour(ShortestPath display)
        {
            this.display = display;
        }
        public Route FindShortestRoute(ArrayList cities)//calculate the total distance 
        {
            ArrayList ShortestRouteCities = new ArrayList();
            Console.WriteLine("");
            Console.WriteLine("                 ***************  TRAVELLING SALESMAN PROBLEM *****************");
            Console.WriteLine("");
            Console.WriteLine("---------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("Initial route     ==> " + getCitiesName(cities));
            Console.WriteLine(" w/ Total Distance Between All Cities :" + new Route(cities).calculateTotalDistance() + " miles");
            Console.WriteLine("----------------------------------------------------------------------------------------------------------------------");
            Console.WriteLine("");

            City city = (City)cities[0];// cities will be picked from here

            updatesRoutes(ShortestRouteCities, cities, city);
            while (cities.Count >= 1)
            {
                city = getNextCity(cities, city);
                updatesRoutes(ShortestRouteCities, cities, city);
            }
            printShortestRout(ShortestRouteCities);
            return new Route(ShortestRouteCities);
        }
        public string getCitiesName(ArrayList cities)// it provide list of cities in the form of String
        {
            string result = null;
            foreach (City city in cities)// iterrate on cities to print next name of city
            {
                result += city.getName() + ",";

            }

            return result;
        }
        private void printShortestRout(ArrayList shortestRouteCities)
        {
            this.display.output.Text = null;
            foreach (City city in shortestRouteCities)// iterrate on cities to print next name of city
            {
                this.display.output.Text = this.display.output.Text + city.getName() + "\n";
            }
            City end = (City)shortestRouteCities[0];
            this.display.output.Text = this.display.output.Text + end.getName() + "\n";
        }
        private void updatesRoutes(ArrayList shortestRouteCities, ArrayList cities, City city)//we update the list after picking any city from the list
        {
            shortestRouteCities.Add(city);
            cities.Remove(city);

            Console.WriteLine("Cities in shortest route   ==> {" + getCitiesName(shortestRouteCities) + "}");
            //Console.WriteLine("Remaining cities    ==> {" + getCitiesName(cities) + "}");
            Console.WriteLine("");
        }

        private City getNextCity(ArrayList cities, City city) // find the minimum distance from list of cities and pick the city with minimum distance.
        {
            int min_index = 0;
            double minDistance = city.measureDistance((City)cities[0]);
            for (int row = 0; row < cities.Count - 1; row++)
            {
                double minDistanceNext = city.measureDistance((City)cities[row + 1]);

                if (minDistanceNext == 0)
                    continue;
                if (minDistance == 0 || minDistanceNext < minDistance)
                {
                    min_index = row + 1;
                    minDistance = minDistanceNext;
                }
            }
            return (City)cities[min_index];


        }
    }
}
