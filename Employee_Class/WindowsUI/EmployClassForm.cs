using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Employee_Class_Library;

/**
* 5/4/2023
* CSC 153
* Susanna Quayle
* Employee Class
*/

namespace WindowsUI
{
    public partial class employeeClassForm : Form
    {
        public employeeClassForm()
        {
            InitializeComponent();
        }

        Employee susanEmployee = new Employee();
        Employee markEmployee = new Employee();
        Employee joyEmployee = new Employee();

        private void susanButton_Click(object sender, EventArgs e)
        {
            susanEmployee.EmployeeName = "Susan Meyers";
            susanEmployee.EmployeeID = 47899;
            susanEmployee.EmployeeDept = "Accounting";
            susanEmployee.EmployeePosition = "Vice President";

            string newLine = Environment.NewLine;
            susanTextBox.Text = ($"NAME: {susanEmployee.EmployeeName}" + newLine + $"ID NUMBER: {susanEmployee.EmployeeID}" + newLine + $"DEPARTMENT: {susanEmployee.EmployeeDept}" + newLine + $"POSITION: {susanEmployee.EmployeePosition}");
        }

        private void markButton_Click(object sender, EventArgs e)
        {
            markEmployee.EmployeeName = "Mark Jones";
            markEmployee.EmployeeID = 39119;
            markEmployee.EmployeeDept = "IT";
            markEmployee.EmployeePosition = "Programmer";

            string newLine = Environment.NewLine;
            markTextBox.Text = ($"NAME: {markEmployee.EmployeeName}" + newLine + $"ID NUMBER: {markEmployee.EmployeeID}" + newLine + $"DEPARTMENT: {markEmployee.EmployeeDept}" + newLine + $"POSITION: {markEmployee.EmployeePosition}");
        }

        private void joyButton_Click(object sender, EventArgs e)
        {
            joyEmployee.EmployeeName = "Joy Rogers";
            joyEmployee.EmployeeID = 81774;
            joyEmployee.EmployeeDept = "Manufacturing";
            joyEmployee.EmployeePosition = "Engineer";

            string newLine = Environment.NewLine;
            joyTextBox.Text = ($"NAME: {joyEmployee.EmployeeName}" + newLine + $"ID NUMBER: {joyEmployee.EmployeeID}" + newLine + $"DEPARTMENT: {joyEmployee.EmployeeDept}" + newLine + $"POSITION: {joyEmployee.EmployeePosition}");
        }
    }
}
