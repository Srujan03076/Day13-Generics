using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Day_13_Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Find max Number");
            int output = MaximumNumberCheck.MaximumIntegerNumber(11, 22, 33);
            Console.WriteLine(output);
        }
    }
}