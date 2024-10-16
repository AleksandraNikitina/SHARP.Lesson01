// Write a program that takes natural number N  as input 
// and shows all integer numbers between -N and N.

// 4 =>> -4, -3, -2, -1, 0, 1, 2, 3, 4
// 2 =>> -2, -1, 0, 1, 2

Console.WriteLine("Input positive integer: ");
int num = Convert.ToInt32(Console.ReadLine());

int count = -num;
while (count <= num)
{
  Console.Write(count + ", "); 
  count++; //count = count+1;
}

