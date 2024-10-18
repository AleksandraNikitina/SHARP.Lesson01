// Write a program that takes number as input and 
// checks is this number positive, negative or zero.  


Console.Write("Enmter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0) 
{
    Console.WriteLine("Number is positive.");
}
else if (num < 0)
{
    Console.WriteLine("Number is negative.");
}
else 
{
    Console.WriteLine("Number is zero.");
}