using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsEven
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("Please enter a number");
            string input = Console.ReadLine();
            Int32.TryParse(input, out num);

            if(num % 2 == 0) // Modulus to check if even
            {
                Console.WriteLine("The number" + num + " is even");
                Console.ReadKey();
            }
            else if(num % 2) // else if added, to demonstrate modulus functionality
            {
                Console.WriteLine("The number " + num + " is even");
                Console.ReadKey();
            }
        }
    }
}
