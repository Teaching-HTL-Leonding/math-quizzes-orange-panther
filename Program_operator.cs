Console.Write("First value: ");
double val1 = double.Parse(Console.ReadLine()!);

Console.Write("Second value: ");
double val2 = double.Parse(Console.ReadLine()!);

Console.Write("Result (rounded to two fractional digits): ");
double result = double.Parse(Console.ReadLine()!);

if (val1 + val2 == result)
{
    System.Console.WriteLine("Operator is plus.");
}
else if (val1 - val2 == result || val2 - val1 == result)
{
    System.Console.WriteLine("Operator is minus.");
}
else if (val1 * val2 == result)
{
    System.Console.WriteLine("Operator is multiply.");
}
else if (Math.Round((val1 / val2), 2) == result || Math.Round((val2 / val1), 2) == result)
{
    System.Console.WriteLine("Operator is divide.");
}
else if (val1 % val2 == result || val2 % val1 == result)
{
    System.Console.WriteLine("Operator is modulo.");
}
else if (Math.Pow(val1, val2) == result || Math.Pow(val2, val1) == result)
{
    System.Console.WriteLine("Operator is exponentiation");
}