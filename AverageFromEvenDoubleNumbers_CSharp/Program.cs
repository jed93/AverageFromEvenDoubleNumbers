using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageFromEvenDoubleNumbers_CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            List<double> myList = new List<double> { 18.261, 32.81, 55.75, 543, 4.009, 33, 199.55, 2 };
            double result = myList.ReturnAverageFromEvenNumbers();
            Console.WriteLine(result);

            Console.ReadLine();
        }
    }
}
