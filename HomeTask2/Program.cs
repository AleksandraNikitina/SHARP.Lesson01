// Write a program that takes three integers as input and 
// shows max of them.  
// 2, 3, 7 => 7
// 44, 5, 78 => 78
// 22, 3, 9 => 22

Console.WriteLine("Enter three integers: ");
int num1 = Convert.ToInt32(Console.ReadLine());
int num2 = Convert.ToInt32(Console.ReadLine());
int num3 = Convert.ToInt32(Console.ReadLine());
int max = num1;

if (num2 > max)
{
    max = num2;
}
if (num3 > max)
{
    max = num3;
}

Console.WriteLine(max);