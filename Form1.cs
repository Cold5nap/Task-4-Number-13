using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task_4_Number_13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void countQButton_Click(object sender, EventArgs e)
        {
            double avg = double.Parse(avgDistanceTextBox.Text);
            int num = int.Parse(numStationTextBox2.Text);
            string name = nameTextBox.Text;
            ComputerNetwork network = new ComputerNetwork(name, num, avg);
            QTextBox.Text = network.Q().ToString();
        }

        private void countQpButton_click(object sender, EventArgs e)
        {
            double avg = double.Parse(avgDistanceTextBox.Text);
            int num = int.Parse(numStationTextBox2.Text);
            string name = nameTextBox.Text;
            double avgS = double.Parse(avgSpeedTextBox.Text);
            var network = new HeirToTheComputerNetwork(avgS,name, num, avg);
            QpTextBox.Text = network.Q().ToString();
        }

        private void showInformation1LevelButton_Click(object sender, EventArgs e)
        {
            double avg = double.Parse(avgDistanceTextBox.Text);
            int num = int.Parse(numStationTextBox2.Text);
            string name = nameTextBox.Text;
            ComputerNetwork network = new ComputerNetwork(name, num, avg);
            information1LevelRichTextBox.Text = network.ToString();
        }

        private void showInformation2LevelButton_Click(object sender, EventArgs e)
        {
            double avg = double.Parse(avgDistanceTextBox.Text);
            int num = int.Parse(numStationTextBox2.Text);
            string name = nameTextBox.Text;
            double avgS = double.Parse(avgSpeedTextBox.Text);
            var network = new HeirToTheComputerNetwork(avgS,name, num, avg);
            information2levelRichTextBox.Text = network.ToString();
        }
    }
}
