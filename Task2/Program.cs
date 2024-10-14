// Write a program that takes natural number N  as input 
// and shows whether the first number is the square of the second.

// a = 25, b = 5 =>> yes
// a = 2, b = 18 =>> no
// a = 9, b = -3 =>> yes
// a = -3, b = 9 =>> no

Console.WriteLine("Input first number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");
int num2 = Convert.ToInt32(Console.ReadLine());

// or 
// string num1str = Console.ReadLine();
// int num1 = Convert.ToInt32(num1str); 
           
if (num1 == num2 * num2)
{
    Console.WriteLine("First number is square of second number.");
}
else
{
    Console.WriteLine("First number is not square of second number.");
}