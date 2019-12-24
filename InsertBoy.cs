using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Travelling_SalesMan_Problem
{
    public partial class InsertBoy : Form
    {
        DeliveryBoy insertBoy = new DeliveryBoy();
        public InsertBoy()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ShortestPath.UpdateQueue(int.Parse(id.Text),this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            insertBoy = insertBoy.GetData(int.Parse(id.Text));
            if (insertBoy == null)
                MessageBox.Show("Incorrect Id");
            else
            {
                BoyName.Text = insertBoy.getName();
                Email.Text = insertBoy.getEmail();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
