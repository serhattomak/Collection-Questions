//Checking Prime and Non-Prime Numbers

using System.Collections;

Console.WriteLine("Please enter 20 numbers: ");
string input = "";
int range = 0;
List<int> numberList = new List<int>();
List<int> primeNumbers = new List<int>();
List<int> nonPrimeNumbers = new List<int>();

while (range < 20)
{
    input = Console.ReadLine();
    int number1 = Convert.ToInt32(input);
    try
    {
        if (int.Parse(input) <= 0)
        {
            Console.WriteLine("Please do not enter zero or negative numbers!");
        }
        else
        {
            numberList.Add(number1);
            range++;
        }
    }
    catch (Exception e)
    {
        Console.WriteLine("Please do not leave blank or do not enter special characters!");
    }
}

for (int i = 0; i < 20; i++)
{
    if (IsPrime(Convert.ToInt32(numberList[i])))
    {
        primeNumbers.Add(numberList[i]);
    }
    else
    {
        nonPrimeNumbers.Add(numberList[i]);
    }
}

primeNumbers.Sort();
primeNumbers.Reverse();
nonPrimeNumbers.Sort();
nonPrimeNumbers.Reverse();

Console.WriteLine("**** Prime Numbers ****");
foreach (var item in primeNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("**** Non-Prime Numbers ****");
foreach (var item in nonPrimeNumbers)
{
    Console.WriteLine(item);
}

Console.WriteLine("Number of prime numbers: " + primeNumbers.Count);
Console.WriteLine("Number of non-prime numbers: " + nonPrimeNumbers.Count);

int sumPrime = 0;
int sumNonPrime = 0;

foreach (var item in primeNumbers)
{
    sumPrime += Convert.ToInt32(item);
}

foreach (var item in nonPrimeNumbers)
{
    sumNonPrime += Convert.ToInt32(item);
}

if (primeNumbers.Count == 0)
{
    Console.WriteLine("Average of the prime numbers: 0");
}
else
{
    double averagePrime = sumPrime / primeNumbers.Count;
    Console.WriteLine("Average of the prime numbers: " + Math.Round(averagePrime).ToString());
}

if (nonPrimeNumbers.Count == 0)
{
    Console.WriteLine("Average of the non-prime numbers: 0");
}
else
{
    double averageNonPrime = sumNonPrime / nonPrimeNumbers.Count;
    Console.WriteLine("Average of the non-prime numbers: " + Math.Round(averageNonPrime).ToString());
}

static bool IsPrime(int number)
{
    if (number == 1)
    {
        return false;
    }
    for (int i = 2; i < number; i++)
    {
        if (number % i == 0)
        {
            return false;
        }
    }
    return true;
}