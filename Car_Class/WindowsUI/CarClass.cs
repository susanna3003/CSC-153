using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Car_Class_Library;

namespace WindowsUI
{
    public partial class carClassForm : Form
    {
        public carClassForm()
        {
            InitializeComponent();
        }

        Car thisCar = new Car();

        private void accelButton_Click(object sender, EventArgs e)
        {
            thisCar.CarMake = carMakeTextBox.Text;
            thisCar.CarYear = carYearTextBox.Text;

            thisCar.AccelerateCar();

            MessageBox.Show($"Your {thisCar.CarYear} {thisCar.CarMake} is going {thisCar.CarSpeed} MPH.");
        }

        private void brakeButton_Click(object sender, EventArgs e)
        {
            thisCar.BrakeCar();

            MessageBox.Show($"Your {thisCar.CarYear} {thisCar.CarMake} is going {thisCar.CarSpeed} MPH.");
        }
    }
}
    
    

