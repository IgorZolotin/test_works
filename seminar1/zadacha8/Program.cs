// Задача 8: Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

// 5 -> 2, 4
// 8 -> 2, 4, 6, 8
// */

Console.Write("Enter Number: ");
string strNum = Console.ReadLine();
int num = int.Parse(strNum);

int EvNum = 2;

if(num > 1)
{
    while(EvNum <= num)
    {
        Console.Write(EvNum + " ");
        EvNum = EvNum + 2;
    }
}