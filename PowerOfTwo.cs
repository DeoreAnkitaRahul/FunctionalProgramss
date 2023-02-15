using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunctionalProgramss
{
    public class PowerOfTwo
    { 
        public static void PowerOfTwoNumber()
    {
        int A = 2;
        int result = 1;

        Console.WriteLine("enter a power number");
        int power = Convert.ToInt32(Console.ReadLine());
        if (power >= 0 && power < 31)
        {
            for (int i = 0; i < power; i++)
            {
                Console.WriteLine((result = result * A) + " ");
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("enter a power between 0 and 31s");
        }
    }
}
}
