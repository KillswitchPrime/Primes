using Primes;

var isFinished = false;

do
{
    var wasValidInput = false;
    var primeSearchLimit = 0;

    while (!wasValidInput)
    {
        var input = Console.ReadLine();
        wasValidInput = int.TryParse(input, out var parsedPrimeSearchLimit);
        primeSearchLimit = parsedPrimeSearchLimit;
    }

    var primeList = PrimeSearcher.FindPrimes(primeSearchLimit);

    Console.WriteLine(primeList.Select(x => x.ToString()).Aggregate((s1, s2) => $"{s1}\n{s2}"));

    Console.WriteLine("New search? (Y/N)");

    var continueInput = Console.ReadLine();

    if(continueInput?.ToUpper() != "Y") isFinished = true;

} while (!isFinished);