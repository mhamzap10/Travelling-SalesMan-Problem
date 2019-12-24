using Lab_8;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Travelling_SalesMan_Problem
{
    public partial class ShortestPath : Form
    {
        int check = 0;
        double speed = 50;
        float costPerKm = 4;
       static DynamicQueue boy = new DynamicQueue();
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
        public double[] geData(string Name)
        {
            double[] data = new double[2];
            StreamReader reader = new StreamReader(@"Data.csv");
            while (!reader.EndOfStream)
            {
                string line = reader.ReadLine();
                if (!String.IsNullOrWhiteSpace(line))
                {
                    string[] values = line.Split(',');
                    if (values[0].ToLower() == Name)
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
        public static void UpdateQueue(int id, InsertBoy _)
        {
            boy.Enque(new DeliveryBoy().GetData(id));
            MessageBox.Show("Updated Successfully");
            _.Dispose();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            
        }
       private void setDeliveryBoy()
        {
            if (check == 0)
            {
                Timer();
                StreamReader reader = new StreamReader(@"DeliveryBoy.csv");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        boy.Enque(new DeliveryBoy(int.Parse(values[0]), values[1].ToString(), values[2].ToString()));
                        Console.WriteLine("Hello");
                    }
                }
                check = -1;
            }
            else if (boy.UnderFlow())
            {
                
                DBoy.Text = "No DeliveryBoy Present at The Moment";
                return;
            }
            DBoy.Text = boy.Deque().getName();
        }
        private void FindRoute()
        {
            Route route = new Route(Address);
            setDeliveryBoy();
            printShortestRoute(new NearestNeighbour(this).FindShortestRoute(Address));
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            FindRoute();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Address = new ArrayList();
            Input.Text = null;
            output.Text = null;
            Distance.Text = null;
            Cost.Text = null;
            Time.Text = null;
            DBoy.Text = null;
        }
        private void Timer()
        {
            Timer timer1 = new Timer
            {
                Interval = 30000
            };
            timer1.Enabled = true;
            timer1.Tick += new System.EventHandler(OnTimerEvent);
        }
        private void OnTimerEvent(object sender, EventArgs e)
        {
            FindRoute();
        }
        private void button4_Click(object sender, EventArgs e)
        {
          new InsertBoy().ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            FindRoute();
        }
    }
}
