//Finding vowels in the entered sentence.
Console.WriteLine("Please enter a sentence: ");
Console.WriteLine("--------------------");
string input =Console.ReadLine();
input.ToLower();
string vowels = "aeıioöuü";
char[] vowelsArray=new char[input.Length];

if (input.Length == 0)
{
    Console.WriteLine("--------------------");
    Console.WriteLine("There are no vowels in entered sentence.");
}
else
{
    Console.WriteLine("--------------------");
    Console.WriteLine("Vowels in this sentence: ");
    for (int i = 0; i < input.Length; i++)
    {
        if (vowels.Contains(input[i]))
        {
            vowelsArray[i] = input[i];
        }
        Console.WriteLine(vowelsArray[i]);
    }
}