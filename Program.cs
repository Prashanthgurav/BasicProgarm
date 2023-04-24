
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To The Basic Core Program");
            Console.WriteLine("Please Choose One From Below Option: ");
            Console.WriteLine("1.FlipCoin\n 2.LeapYear\n 3.PowerOfTwo\n 4.HarmonicSeries\n 5.EvenorOdd");
            int Option = Convert.ToInt32(Console.ReadLine());
            switch (Option)
            {
                case 1:
                    FlipCoins.Flip();
                    break;
                   case 2:
                    LeapYear.TheLeapYear();
                    Console.ReadKey();
                    break;
                    case 3:
                    PowerOfTwo.CalPow();
                    Console.ReadKey();
                    break;
                    case 4:
                    Harmonic.HarmonicSeries();
                    Console.ReadKey();
                    break;
                    case 5:
                    EvenorOdd.FindEvenOrOdd();
                    Console.ReadKey();
                    break;
                default:
                    Console.WriteLine("Please Choose Program With Given Option");
                    break;
            }
        }
    }
}