using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Travelling_SalesMan_Problem
{
    public partial class ShortestPath : Form
    {
        double speed = 50;
        float costPerKm = 4;
        ArrayList Address = new ArrayList();
        public ShortestPath()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void printShortestRoute(Route shortestRoute)
        {
            
            Console.WriteLine("Shortest route found so far is :{" + new NearestNeighbour(this).getCitiesName(shortestRoute.getCities()) + "}");
            Console.WriteLine(" w/ Total distance : " + shortestRoute.calculateTotalDistance() + " miles");
            ArrayList city = shortestRoute.getCities();
            City final = (City)city[city.Count - 1];
            double distance = (shortestRoute.calculateTotalDistance() * 1.609)+ final.measureDistance((City)city[0]);
            Distance.Text = distance.ToString("0.##") + " Km";
            Time.Text = ((distance / speed)+0.5).ToString("0.##") +" hrs";
            Cost.Text = "Rs "+(costPerKm * distance).ToString("0.##");



            //Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");
        }
        public double[] getData(string Name)
        {
            double[] data = new double[2];
            StreamReader reader = new StreamReader(@"Data.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if(values[0].ToLower() == Name)
                    {
                        data[0] = double.Parse(values[1]);
                        data[1] = double.Parse(values[2]);
                        return data;
                    }
                }
            }
            data[0] = -1;
            return data;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double[] data = getData(Area.Text.ToLower());
            if (data[0] == -1)
                MessageBox.Show("Area Not Found. Make sure you have write correct spellings");
            else
            {
                Address.Add(new City(House.Text + " , " + Area.Text, data[0], data[1]));
                Input.Text = Input.Text + House.Text + " , " + Area.Text + "\n";
            }
            House.Text = null;
            Area.Text = null;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Route route = new Route(Address);

            printShortestRoute(new NearestNeighbour(this).FindShortestRoute(Address));
        }
    }
}
