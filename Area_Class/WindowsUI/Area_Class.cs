using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Area_Library;

namespace WindowsUI
{
    public partial class Area_Class : Form
    {
        public Area_Class()
        {
            InitializeComponent();
        }

        private void circleButton_Click(object sender, EventArgs e)
        {
            double circleRad = double.Parse(circleRadTextBox.Text);
            
            Area circle = new Area(circleRad);

            MessageBox.Show($"The area of the circle is {circle}");
        }

        private void rectangleButton_Click(object sender, EventArgs e)
        {
            int width = int.Parse(widthTextBox.Text);
            int length = int.Parse(lengthTextBox.Text);

            Area rectangle = new Area(width, length);

            MessageBox.Show($"The area of the rectangle is {rectangle}");
        }

        private void cylinderButton_Click(object sender, EventArgs e)
        {
            double height = double.Parse(heightTextBox.Text);
            double cylinderRad = double.Parse(cylRadTextBox.Text);

            Area cylinder = new Area(height, cylinderRad);

            MessageBox.Show($"The area of the cylinder is {cylinder}");
        }
    }
}
