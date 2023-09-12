// Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter Number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int Del = num % 2;

if(Del == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}