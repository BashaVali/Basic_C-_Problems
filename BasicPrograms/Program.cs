﻿using BasicPrograms.LeapYear;
using BasicPrograms.PowerOf2;
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
            HarmonicSeries harmonic = new HarmonicSeries();
            harmonic.Harmonic();
            PrimeFactor primeFactor = new PrimeFactor();
            primeFactor.Factors();
            QuotientAndRemainder quotientAndRemainder = new QuotientAndRemainder();
            quotientAndRemainder.Divider();
            SwapNumber swapNumber = new SwapNumber();
            swapNumber.Swap();
            EvenorOdd evenorOdd = new EvenorOdd();  
            evenorOdd.EvenOdd();
            VowelsorConsonants vowelsorConsonants = new VowelsorConsonants();
            vowelsorConsonants.VowelorConsonant();
            
        } 
    }
}                   