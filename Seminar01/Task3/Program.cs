// Write a program that takes three-digit integer as input and 
// shows on screen sum of the first and the last digits.  
// 456 => 10
// 782 => 9
// 918 => 17

Console.WriteLine("Enter positive three-digit integer: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num >= 100 && num <= 999)
{
    int firstDigit = num / 100; // 456 / 100 = 4,56
    int lastDigit = num % 10; // 456 % 10 = 450 + 6
    int sum = firstDigit + lastDigit;
    Console.WriteLine($"Sum of the first and the last digits = {sum}");
}
else
{
    Console.WriteLine("Enter error! Number is not a three-digit.");
}