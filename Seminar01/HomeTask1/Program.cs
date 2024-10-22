// Write a program that takes two integers as input and 
// shows what is the biggest and what is the smallest.  
// a=5, b=7 => max=7, min=5
// a=-9, b=-3 => max=-3, min=-9


// Console.WriteLine("Enter two integers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());

// if (num1 > num2)
// {
//     Console.WriteLine($"max = {num1}, min = {num2}");
// }
// else 
// {
//     if (num1 == num2)
//     {
//         Console.WriteLine($"Numbers are equal. max = min = {num1}");    
//     }
//     else
//     {
//         Console.WriteLine($"max = {num2}, min = {num1}");
//     }
// }

// Write a program that takes two integers as input and 
// checks is the first number divisible by the second number.  

using System.Diagnostics.Tracing;

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
    Console.WriteLine("Not divisible");
}