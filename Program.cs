using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FizzBuzz fizzBuzz = new FizzBuzz();

            while (true)
            {
                Console.WriteLine("Podaj proszę liczbę. Gdy bedzie podzielna przez 3 lub 5 lub oba pojawi się stosowny komunikat");

                var number = GetNumber();

                Console.WriteLine(fizzBuzz.Play(number));
            }

            

        }

        private static int GetNumber()
        {
            while (true)
            {
                if (!int.TryParse(Console.ReadLine(), out var number))
                {
                    Console.WriteLine("Podałeś nieprawidłowe dane");
                    continue;
                }
                {
                    return number;
                }
            }
        }
    }
}
