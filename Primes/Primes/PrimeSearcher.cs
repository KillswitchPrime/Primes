﻿using System.Runtime.CompilerServices;

namespace Primes
{
    public static class PrimeSearcher
    {
        public static List<int> FindPrimes(int primeSearchLimit)
        {
            if(primeSearchLimit < 20) primeSearchLimit = 20;

            var primes = new List<int> { 3, 5, 7, 11, 13};

            for(var i = 17; i < primeSearchLimit; i += 2)
            {
                var isPrime = true; 

                for(var index = 0; index < primes.Count; index++)
                {
                    if(i % primes[index] == 0)
                    {
                        isPrime = false;
                    }
                }

                if (isPrime)
                {
                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}