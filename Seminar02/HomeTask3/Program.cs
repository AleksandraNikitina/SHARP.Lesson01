
Console.WriteLine("Enter integer number of range [10..99]: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 10 && num <= 99)
{
    int firstDigit = num / 10;
    int secondDigit = num % 10;
    if (firstDigit > secondDigit)
    {
        Console.WriteLine($"Maximal digit: {firstDigit}");
    }
    else
    {
        Console.WriteLine($"Maximal digit: {secondDigit}");
    }
}
else
{
    Console.WriteLine("Enter error");
}