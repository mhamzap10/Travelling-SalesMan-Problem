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
    public partial class Settings : Form
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(AvgSpeed.Text) && string.IsNullOrWhiteSpace(FuelPrice.Text))
                MessageBox.Show("Both Field Cannot be left empty");
            else
            {
                if (!string.IsNullOrWhiteSpace(AvgSpeed.Text))
                    ShortestPath.speed = Double.Parse(AvgSpeed.Text);
                if (!string.IsNullOrWhiteSpace(FuelPrice.Text))
                    ShortestPath.costPerKm = float.Parse(FuelPrice.Text) / 30.0f;
                MessageBox.Show("Updated Sucessfully");
                this.Dispose();
            }
            
        }
    }
}
