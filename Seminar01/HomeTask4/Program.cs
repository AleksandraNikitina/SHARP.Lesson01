// Write a program that takes a number as input 
// and shows all odd numbers  starting from 1 to this number (including).


Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
int current = 1;

if (num < 1)
{
    Console.WriteLine("Number is lowest then one.");
}
while (num >= current)
{
    Console.Write($"{current} ");
    current = current +2;
}