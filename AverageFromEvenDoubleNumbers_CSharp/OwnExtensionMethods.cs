using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageFromEvenDoubleNumbers_CSharp
{
    public static class OwnExtensionMethods
    {
        public static double ReturnAverageFromEvenNumbers(this List<double> doubleList)
        {
            var evenNumbersList = new List<double>();
              
            foreach (var number in doubleList)
            {
                double unityNumber = Math.Floor(number);

                // Sprawdzam podzielność przez 2
                double numberDividedByTwo = unityNumber / 2;
                if (numberDividedByTwo == Math.Round(numberDividedByTwo))
                {
                    evenNumbersList.Add(number);
                }
            }

            double globalSum = 0;

            foreach (var evenNumber in evenNumbersList)
            {
                globalSum += evenNumber;
            }

            return evenNumbersList.Count() > 0 ? globalSum / evenNumbersList.Count() : 0;
        }
    }
}
