// Write a program that takes as input a three-digit number
// and raises the second digit of this number to the power of the three digit. 


Console.Write("Enter 3-digit number: ");
int num = Convert.ToInt32(Console.ReadLine());
int seconddigit = num / 10 % 10;
int lastdigit = num % 10;

if (num >= 100 && num <= 999)
{
    int result = 1;
    int i = 1;
    while (i <= lastdigit)
    {
        result = result * seconddigit; //result *=secontdigit
        i++;
    }
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("Enter error");
}