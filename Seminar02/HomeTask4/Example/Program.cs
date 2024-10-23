
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num < 10)
{
    Console.WriteLine(num);
}
else
{
    while (num > 0)
    {
        int currentDigit = num % 10;
        num /= 10;
        if (num > 0)
        {
        Console.Write(currentDigit + ",");
        }
        else
        {
            Console.WriteLine(currentDigit);
        }
    }
}