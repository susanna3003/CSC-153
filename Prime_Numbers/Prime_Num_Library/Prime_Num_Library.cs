using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_Num_Library
{
    public static class Prime_Num_Library
    {

        public static bool IsPrime(int userInt)
        {
            //determine if userInt is prime by testing if divisible by itself and 1
            bool isIntPrime = true;
            int prime = 2;

            while (prime < userInt)
            {
                if (userInt % prime == 0)
                {
                    isIntPrime = false;
                }
                prime++;
            }

            return isIntPrime;
        }

    }
}
