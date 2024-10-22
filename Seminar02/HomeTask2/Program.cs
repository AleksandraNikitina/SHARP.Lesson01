Console.Write("Enter X: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter Y: ");
int y = Convert.ToInt32(Console.ReadLine());

if (x > 0)
{
    if (y>0)
    {
        Console.WriteLine("First coordinate quadrant");
    }
    else
    {
        Console.WriteLine("Fourth coordinate quadrant");
    }
}
else if (y > 0)
{
    Console.WriteLine("Second coordinate quadrant");
}
else
{
    Console.WriteLine("Third coordinate quadrant");
}