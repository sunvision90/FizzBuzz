using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class FizzBuzz
    {
       public string Play(int number)
        {
            if (number % 3 == 0 || number % 5 == 0)
            
                return "FizzBuzz";
                        
            if (number % 3 == 0)
                return "Fizz";
            
            if ((number % 5) == 0) 
                return "Buzz";

            else
                return "Liczba nie jest podzielna ani przez 3 ani przez 5. Sprobuj ponownie";
        }
    }
}
