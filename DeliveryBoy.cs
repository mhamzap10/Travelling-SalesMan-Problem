using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling_SalesMan_Problem
{
    class DeliveryBoy
    {
        string Name;
        string Email;
        int id;
        public DeliveryBoy()
        {
            this.id = 0;
            this.Name = null;
            this.Email = null;
        }
        public DeliveryBoy(int id, string Name, string Email)
        {
            this.id = id;
            this.Name = Name;
            this.Email = Email;
        }
        public string getName()
        {
            return this.Name;
        }
        public string getEmail()
        {
            return this.Email;
        }
        public DeliveryBoy GetData(int id)
        {
            StreamReader reader = new StreamReader(@"DeliveryBoy.csv");
            while(!reader.EndOfStream)
            {
                string list = reader.ReadLine();
                string[] values = list.Split(',');
                if(id == int.Parse(values[0]))
                {
                    return new DeliveryBoy(int.Parse(values[0]), values[1].ToString(), values[2].ToString());
                }
            }
            return null;
        }
    }
}
