// Write a program that takes three integers as input and 
// shows max of them.  
// 2, 3, 7 => 7
// 44, 5, 78 => 78
// 22, 3, 9 => 22

// Console.WriteLine("Enter three integers: ");
// int num1 = Convert.ToInt32(Console.ReadLine());
// int num2 = Convert.ToInt32(Console.ReadLine());
// int num3 = Convert.ToInt32(Console.ReadLine());
// int max = num1;

// if (num2 > max)
// {
//     max = num2;
// }
// if (num3 > max)
// {
//     max = num3;
// }

// Console.WriteLine(max);



// Write a program that takes three integers as input and 
// shows middle of them.  
// 2, 3, 7 => 3
// 44, 5, 78 => 44
// 22, 3, 9 => 9


Console.WriteLine("Enter three integers. ");
Console.Write("a: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.Write("b: ");
int num2 = Convert.ToInt32(Console.ReadLine());
Console.Write("c: ");
int num3 = Convert.ToInt32(Console.ReadLine());

// int mid = num1;

// if (num1 >= num2 && num1 >= num3)
// {
//     if (num3 >= num2)
//     {
//         mid = num3;
//     }
//     else
//     {
//         mid = num2;
//     }
// }
// else if (num1 <= num2 && num1 <= num3)
// {
//     if (num2 <= num3)
//     {
//         mid = num2;
//     }
//     else 
//     {
//         mid = num3;
//     }
// }
// Console.WriteLine(mid);

// Other variaty:

if ((num1 >= num2 && num1 <= num3) || (num1 >= num3 && num1 <= num2))
{
    Console.WriteLine(num1); 
}
else if ((num2 >= num1 && num2 <= num3) || (num2 >= num3 && num2 <= num1))
{
    Console.WriteLine(num2);
}
else 
{
    Console.WriteLine(num3);
}
