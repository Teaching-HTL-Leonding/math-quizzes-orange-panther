int n = 1, counterN = 0;
int i = 1, counterI = 0;

do
{
    if (n <= 0)
    {
        System.Console.WriteLine("Invalid input. the number has to be positive. Please try again.");
    }
    Console.Write("Enter a positve integer value: ");
    n = int.Parse(Console.ReadLine()!);
}
while (n <= 0);

do
{
    if (i <= 0)
    {
        System.Console.WriteLine("Invalid input. the number has to be positive. Please try again.");
    }
    Console.Write("Enter a second positve integer value: ");
    i = int.Parse(Console.ReadLine()!);
}
while (i <= 0);

while (n > 1)
{
    //System.Console.Write(n + " ");
    counterN++;
    if (n % 2 == 0)
    {
        n = n / 2;
    }
    else
    {
        n = n * 3 + 1;
    }
}
//System.Console.WriteLine(n);
counterN++;
//System.Console.WriteLine($"The sequence has {counterN} numbers.");


while (i > 1)
{
    //System.Console.Write(i + " ");
    counterI++;
    if (i % 2 == 0)
    {
        i = i / 2;
    }
    else
    {
        i = i * 3 + 1;
    }
}
//System.Console.WriteLine(i);
counterI++;
//System.Console.WriteLine($"The sequence has {counterI} numbers.");

if (counterN >= counterI)
{
    System.Console.WriteLine("The sequence of the first number is longer.");
}
else 
{
    System.Console.WriteLine("The sequence of the second number is longer.");
}
