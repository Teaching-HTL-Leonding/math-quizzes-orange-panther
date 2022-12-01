Console.Write("Largest number: ");
int n = int.Parse(Console.ReadLine()!);

Console.Write("Fizz: ");
int a = int.Parse(Console.ReadLine()!);

Console.Write("Buzz: ");
int b = int.Parse(Console.ReadLine()!);

for (int i = 1; i <= n; i++)
{
    if (i % a == 0 && i % b == 0)
    {
        Console.Write("FizzBuzz ");
    }
    else if (i % a == 0)
    {
        Console.Write("Fizz ");
    }
    else if (i % b == 0)
    {
        Console.Write("Buzz ");
    }
    else { Console.Write(i + " "); }
}