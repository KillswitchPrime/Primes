using System.Runtime.CompilerServices;

namespace Primes
{
    public static class PrimeSearcher
    {
        public static List<int> FindPrimes(int primeSearchLimit)
        {
            if(primeSearchLimit < 20) primeSearchLimit = 20;

            var primes = new List<int> { 3, 5, 7, 11, 13, 17};

            for(var primeCandidate = 19; primeCandidate < primeSearchLimit; primeCandidate += 2)
            {
                var isPrime = true; 

                for(var index = 0; index < primes.Count && isPrime && primes[index] < Math.Sqrt(primeCandidate); index++)
                {
                    isPrime = primeCandidate % primes[index] !== 0;
                }

                if (isPrime) primes.Add(primeCandidate);
            }

            return primes;
        }
    }
}
