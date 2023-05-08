using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Class_Library
{
    public class Employee

    {
        //properties
        private string _employeeName;
        private int _employeeID;
        private string _employeeDept;
        private string _employeePosition;

        
        public Employee(string employeeName, int employeeID, string employeeDept, string employeePosition)//constructor1
        {
            _employeeName = employeeName;
            _employeeID = employeeID;
            _employeeDept = employeeDept;
            _employeePosition = employeePosition;
        }

        public Employee(string employeeName, int employeeID)//constructor2
        {
            _employeeName = employeeName;
            _employeeID = employeeID;
            _employeeDept = "";
            _employeePosition = "";
        }

        public Employee()//constructor3
        {
            _employeeName = "";
            _employeeID = 0;
            _employeeDept = "";
            _employeePosition = "";
        }

        public string EmployeeName
        {
            get { return _employeeName; }
            set { _employeeName = value; }
        }

        public int EmployeeID
        {
            get { return _employeeID; }
            set { _employeeID = value; }
        }

        public string EmployeeDept
        {
            get { return _employeeDept; }
            set { _employeeDept = value; }
        }

        public string EmployeePosition
        {
            get { return _employeePosition; }
            set { _employeePosition = value; }
        }

    }
}
