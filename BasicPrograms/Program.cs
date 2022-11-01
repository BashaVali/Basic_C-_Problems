using BasicPrograms;
using BasicPrograms.LeapYear;
using BasicPrograms.PowerOf2;
using System;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            FlipCoins flipCoin = new FlipCoins();
            flipCoin.FlipCoin();
            LeapYears leapYear = new LeapYears();
            leapYear.LeapYear();
            PowerOf2s powerOf2 = new PowerOf2s();
            powerOf2.PowerOf2();
        }
    }
}