using System;
using System.Collections.Generic;

namespace PrimeFactors
{
    public class PrimeFactors
    {
        public static List<Int32> Generate(Int32 number)
        {
            var factors = new List<Int32>();

            for (var i = 2; i <= number; i++)
            {
                while (number % i == 0)
                {
                    factors.Add(i);
                    number /= i;
                   
                    if (number <= 1)
                        return factors;
                }
            } 
            
            return factors;
        }
    }
}
