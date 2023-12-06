using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _16.while_Loop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0;
            Console.WriteLine("This is a while loop.");
            while(num <= 5)
            {
                Console.WriteLine(num);
                num++;
            }
            Console.WriteLine("This is a do while loop");
            int num2= 0;
            do
            {
                Console.WriteLine(num2);
                num2++;
            }
            while (num2 <= 5);
            Console.ReadLine();
        }
    }
}
