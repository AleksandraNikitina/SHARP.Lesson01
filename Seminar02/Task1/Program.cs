// Write a program that takes as input three-digit integer 
// and delets the second digit of this number.


Console.Write("Enter a positive three-digit integer: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstdigit = num / 100;
    int lastdigit = num % 10;

    int result = firstdigit*10 + lastdigit;
    Console.WriteLine(result);
}

else 
Console.WriteLine("Enter error");