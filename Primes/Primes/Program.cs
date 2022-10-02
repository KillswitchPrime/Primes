using Primes;

var isFinished = false;

do
{
    var wasValidInput = false;
    var primeSearchLimit = 0;

    Console.WriteLine("Enter search limit for finding primes: ");

    while (!wasValidInput)
    {
        var input = Console.ReadLine();
        wasValidInput = int.TryParse(input, out var parsedPrimeSearchLimit);
        primeSearchLimit = parsedPrimeSearchLimit;
        Console.WriteLine();
    }

    var primeList = PrimeSearcher.FindPrimes(primeSearchLimit);

    Console.WriteLine("Showing 10 largest primes:");
    Console.WriteLine(primeList.Skip(primeList.Count - 10).Select(x => x.ToString()).Aggregate((s1, s2) => $"{s1}\n{s2}"));
    Console.WriteLine();

    Console.WriteLine($"Total number of primes: {primeList.Count + 2}\n");

} while (!isFinished);