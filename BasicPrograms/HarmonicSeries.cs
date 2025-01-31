﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    internal class HarmonicSeries
    {
        public int InputValue()
        {
            Console.WriteLine("Enter the Number to find the Harmonic value : ");
            int N = Convert.ToInt32(Console.ReadLine());
            return N;
        }
        public void Harmonic()
        {   
          //loop to apply the formula 
          //Hn = H1 + H2 + H3 ... + 
          //Hn-1 + Hn-1 + 1/n

            int N = InputValue();
            float harmonic = 1;
            for (int i = 2; i < N; i++)
            {
                harmonic += (float)1/ N;
            }
            Console.WriteLine("The Nth Harmonic Value" + N + " : " + harmonic);
        }
    }
}