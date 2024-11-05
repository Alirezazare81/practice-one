using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practice_one
{
    class Program
    {
        static void Main(string[] args)
        {
            int adad1, adad2, miangin;
            Console.WriteLine("enter number one");
            adad1 = int.Parse(Console.ReadLine());
            Console.WriteLine("enter number two");
            adad2 = int.Parse(Console.ReadLine());
            miangin = (adad1 + adad2) / 2;
            Console.WriteLine("miangin:   "+miangin);
            Console.ReadKey();

        }
    }
}
