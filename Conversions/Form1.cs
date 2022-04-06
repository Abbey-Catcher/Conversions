using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversions
{
    public partial class Conversions : Form
    {
        public Conversions()
        {
            InitializeComponent();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            double value = Convert.ToDouble(conversionValueInput.Text);
            string choice = conversionChoiceInput.Text;
            if (choice == "1")
            {
                double answer = InchesToCm(value);
                outputLabel.Text = $"{value} inches = {answer} cm";
            }
            else if (choice == "2")
            {
                double answer = FeetToCm(value);
                outputLabel.Text = $"{value} feet = {answer} cm";
            }
            else if (choice == "3")
            {
                double answer = YardsToMetres(value);
                outputLabel.Text = $"{value} yards = {answer} metres";
            }
            else
            {
                double answer = MilesToKm(value);
                outputLabel.Text = $"{value} miles = {answer} km";
            }
        }

        public double InchesToCm(double inches)
        {
            double cm = inches * 2.54;
            return cm;
        }

        public double FeetToCm(double feet)
        {
            double cm = feet * 30.48;
            return cm;
        }

        public double YardsToMetres(double yards)
        {
            double metres = yards * 0.91;
            return metres;
        }
        
        public double MilesToKm(double miles)
        {
            double km = miles * 1.6;
            return km;
        }
    }
}
