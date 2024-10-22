// Write a program that outputs the third (from left) digit of the input number
// or reports that there is no 3rd digit.

Console.WriteLine("Enter number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 || num <= -100)
{
    while (num > 999 || num < -999)
    {
        num = num / 10;
    }
    int thirdDigit = num % 10;
    Console.WriteLine(thirdDigit);
}
else
{
    Console.WriteLine("There is no the third digit.");
}