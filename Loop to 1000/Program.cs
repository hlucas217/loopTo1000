using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop_to_1000
{
    class Program   
    {
        static void Main(string[] args)
        {
            // Use a loop to total all the numbers from 1 to 1000 = (1 + 2 + ... + 1000)

            int newTotal = 0;
            for (int i = 1; i <= 1000; i++)
            {
                Console.WriteLine(i);
                newTotal = i + newTotal;
            }
            Console.WriteLine(newTotal);
            Console.ReadLine();
        }
    }
}
