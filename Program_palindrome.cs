int numberOfDigits, palindrome = 0;

Console.Write("Enter a positive integer number: ");
int input = int.Parse(Console.ReadLine()!), inputCopy = input, inputCopy2 = input;

for (numberOfDigits = 0; inputCopy > 0; numberOfDigits++)
{
    inputCopy = inputCopy / 10;
}

for (int counter= 0; counter != numberOfDigits; counter++)
{
    palindrome = palindrome * 10 + (input % 10);
    input = (input - (input % 10)) / 10;
}

if (palindrome == inputCopy2)
{
    Console.WriteLine("This number is a palindrome.");
}
else 
{
    System.Console.WriteLine("This number is not a palindrome.");
}

