using Lab_8;
using System;
using System.Collections;
using System.IO;
using System.Windows.Forms;

namespace Travelling_SalesMan_Problem
{
    public partial class ShortestPath : Form
    {
        int interval = 1;
        string receiver = "";
        int check = 0;
       public static double speed = 50;
        public static float costPerKm = 4;
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
            ArrayList city = shortestRoute.getCities();
            City final = (City)city[city.Count - 1];
            double distance = (shortestRoute.calculateTotalDistance() * 1.609)+ final.measureDistance(new City("Bahria University", 24.893277, 67.08818145));
            Distance.Text = distance.ToString("0.##") + " Km";
            Time.Text = ((distance / speed)+0.5).ToString("0.##") +" hrs";
            Cost.Text = "Rs "+(costPerKm * distance).ToString("0.##");
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
            if(interval == 1)
            {
                Timer.Enabled = true;
                Timer.Start();
                RouteTimer.Enabled = true;
                RouteTimer.Start();
            }
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
                StreamReader reader = new StreamReader(@"DeliveryBoy.csv");
                while (!reader.EndOfStream)
                {
                    string line = reader.ReadLine();
                    if (!String.IsNullOrWhiteSpace(line))
                    {
                        string[] values = line.Split(',');
                        boy.Enque(new DeliveryBoy(int.Parse(values[0]), values[1].ToString(), values[2].ToString()));
                    }
                }
                check = -1;
            }
            else if (boy.UnderFlow())
            {
                
                DBoy.Text = "No DeliveryBoy Present at The Moment";
                return;
            }
            DeliveryBoy temp = boy.Deque();
            DBoy.Text = temp.getName();
            receiver = temp.getEmail();
        }
        private void FindRoute()
        {
            Route route = new Route(Address);
            setDeliveryBoy();
            printShortestRoute(new NearestNeighbour(this).FindShortestRoute(Address));
            RouteTimer.Stop();
            Timer.Stop();
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
            interval = 0;
            Timer.Stop();
            second.Text = "0";
            RouteTimer.Stop();
        }
        
        private void button4_Click(object sender, EventArgs e)
        {
          new InsertBoy().ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            new Email().SendEmail(receiver, output.Text + "\n Distance: " + Distance.Text + "\n Expected Cost: " + Cost.Text+"\n Expected Time: "+Time.Text);
            MessageBox.Show("Email Send Successfully");
        }

        private void Timer_Tick_1(object sender, EventArgs e)
        {
            interval++;
            second.Text = interval.ToString();
        }

        private void RouteTimer_Tick(object sender, EventArgs e)
        {
            FindRoute();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            new Settings().ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Timer.Start();
            RouteTimer.Start();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Timer.Stop();
            RouteTimer.Stop();
        }
        public void NoInternet()
        {
            MessageBox.Show("No Internet Connection");
        }
        private void ShortestPath_Load(object sender, EventArgs e)
        {

        }
    }
}
