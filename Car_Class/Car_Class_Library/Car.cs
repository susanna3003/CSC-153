using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car_Class_Library
{
    public class Car
    {
            private string _carYear;
            private string _carMake;
            private int _carSpeed = 0;

            public Car()
            {

            }

            public Car(string carYear, string carMake) //constructor
            {
                _carYear = carYear;
                _carMake = carMake;
                
            }

            public string CarYear
            {
                get { return _carYear; }
                set { _carYear = value; }
            }

            public string CarMake
            {
                get { return _carMake; }
                set { _carMake = value; }
            }

            public int CarSpeed
            {
                get { return _carSpeed; }
                set { _carSpeed = value; }
            }

            public void AccelerateCar() //accelerate method
            {
                CarSpeed += 5;
            }

            public void BrakeCar() //brake method
            {
            if (CarSpeed <= 0)
            {
                CarSpeed = 0;
            } 
            else
            {
                CarSpeed -= 5;
            }
            }
    }
}
