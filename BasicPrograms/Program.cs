using BasicPrograms;
using BasicPrograms.LeapYear;
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
        }
    }
}