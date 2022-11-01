using BasicPrograms.LeapYear;
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
            
        } 
    }
}                   