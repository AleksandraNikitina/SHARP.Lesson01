
Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());
int firstRank = 1;

for (int currentRank = 1; num/currentRank != 0; currentRank = currentRank * 10)
{
    firstRank = currentRank;
}
// Console.WriteLine(firstRank);

for (int i = firstRank; i > 0; i = i / 10)
{
    int digit = num / i;
    num = num - digit * i;
    Console.Write(digit);
    if (i != 1)
    {
        Console.Write(", ");
    }
}