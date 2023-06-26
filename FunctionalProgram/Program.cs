using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            Console.WriteLine("CHOOSE YOUR CHOICE FROM BELOW");
            Console.WriteLine("1-FlipCoin");
            Console.WriteLine("2-LeapYear");
            Console.WriteLine("3-PowerOfTwo");
            Console.WriteLine("4-Harmonic Number");
            Console.WriteLine("5-FactorofNumber");
            Console.WriteLine("6-Division");
            Console.WriteLine("7-SwapingNumbers");
            Console.WriteLine("8-Even.Odd");
            Console.WriteLine("9-Alphabets");
            Console.WriteLine("10-ComparingThreeNumbers");

            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("The Flip coin Program");
                    FlipCoin f = new FlipCoin();
                    f.Display();
                    break;
                case 2:
                    Console.WriteLine("Leap Year");
                    LeapYear le = new LeapYear();
                    le.year();
                    break;
                case 3:
                    Console.WriteLine("Power of two Program");
                    PowerOfTwo Power = new PowerOfTwo();
                    Power.oftwo();
                    break;
                case 4:
                    Console.WriteLine("Harmonic Series Program");
                    HarmonicNumber h = new HarmonicNumber();
                    h.Series();
                    break;
                case 5:
                    Console.WriteLine("FactorsofNumber Program");
                    Factor factors = new Factor();
                    factors.Ofnumber();
                    break;
                case 6:
                    Console.WriteLine("Division Program");
                    Division division = new Division();
                    division.Math(33, 2);
                    break;
                case 7:
                    Console.WriteLine("Swaping two numbers");
                    SwapNum swap = new SwapNum();
                    swap.TwoNumbers(7, 2);
                    break;
                case 8:
                    Console.WriteLine("Even or odd Number");
                    EvenOdd even = new EvenOdd();
                    even.Odd();
                    break;
                case 9:
                    Console.WriteLine("Consonants and vowels");
                   VowelConsonant consonant = new VowelConsonant();
                    consonant.Vowels();
                    break;
                case 10:
                    Console.WriteLine("Comparing three numbers");
                    LargestNum  compare = new LargestNum();
                    compare.Numbers();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }


            Console.ReadLine();
        }
    }
}
