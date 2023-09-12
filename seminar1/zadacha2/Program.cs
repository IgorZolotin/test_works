// Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
// a = 5; b = 7 -> max = 7
// a = 2 b = 10 -> max = 10
// a = -9 b = -3 -> max = -3

Console.Write("Enter Number: ");
string strNum = Console.ReadLine();
int num1 = int.Parse(strNum);

Console.Write("Enter Number: ");
strNum = Console.ReadLine();
int num2 = int.Parse(strNum);

if (num1 == num2)
  Console.WriteLine("num2 равно num1");
else if(num1 > num2)
  Console.WriteLine("num1 больше");
else
  Console.WriteLine("num2 больше");