﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
   namespace LeapYear
    {
        public class LeapYears
        {
            int year;
            public void LeapYear()
            {
                

                Console.WriteLine("Enter The Year ");
                year = Convert.ToInt32(Console.ReadLine());

                if (((year % 4 == 0) && (year % 100 != 0) || (year % 400 == 0)))
                {
                    Console.WriteLine("The " + year + " is a leap year");
                }
                else
                {
                    Console.WriteLine("The " + year + " is not a leap year");
                }
            }
        }
    }
}