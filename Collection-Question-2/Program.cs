// Finding lowest 3 and highest 3 numbers on given 20 numbers and getting their averages and also summing their averages.

using System;

Console.WriteLine("Please enter 20 numbers: ");
Console.WriteLine("----------------------------------------");
int number = 0;
bool controlledEntry;
int[] array = new int[20];
int sumLowest = 0;
int sumBiggest = 0;

for (int i = 0; i < 20; i++)
{
    try
    {
        number = int.Parse(Console.ReadLine());
        array[i] = number;
    }
    catch (Exception)
    {
        Console.WriteLine("Please do not leave blank or do not enter special characters!");
        i--;
    }
}

Array.Sort(array);
Console.WriteLine("----------------------------------------");
Console.WriteLine("3 Lowest value on the given numbers: ");
Console.WriteLine("----------------------------------------");
for (int i = 0; i < 3; i++)
{
    Console.WriteLine(array[i].ToString());
    sumLowest += array[i];
}
Console.WriteLine("----------------------------------------");
Console.WriteLine("3 Biggest value on the given numbers: ");
Console.WriteLine("----------------------------------------");
for (int i = 17; i < 20; i++)
{
    Console.WriteLine(array[i].ToString());
    sumBiggest += array[i];
}

double lowestAverage = sumLowest / 3;
double biggestAverage = sumBiggest / 3;

Console.WriteLine("----------------------------------------");
Console.WriteLine($"Average of the 3 lowest numbers: {lowestAverage}");
Console.WriteLine($"Average of the 3 biggest numbers: {biggestAverage}");
Console.WriteLine("----------------------------------------");
Console.WriteLine($"Sum of the averages: {lowestAverage + biggestAverage}");

