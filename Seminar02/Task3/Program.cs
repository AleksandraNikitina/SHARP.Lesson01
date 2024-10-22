Console.WriteLine("Enter two integers.");
Console.Write("First number: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

if (num2 == 0)
{
    Console.WriteLine("You can't divide by zero.");
}
else if (num1 % num2 == 0)
{
    Console.WriteLine("Divisible");
}
else
{
    int remainder = num1 % num2;
    Console.WriteLine($"Remainder from division = {remainder}");
}