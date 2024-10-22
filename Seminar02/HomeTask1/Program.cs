
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num%7 == 0 && num%23 ==0)
{
    Console.WriteLine("Divisible");
}
else
{
    Console.WriteLine("Not divisible");
}