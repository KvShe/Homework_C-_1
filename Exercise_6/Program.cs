/*

Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

4 -> да
-3 -> нет
7 -> нет

*/

Console.Write("Введите число: ");
double number = Convert.ToInt32(Console.ReadLine());

double remainder = number % 2;

if (remainder == 0)
{
    Console.Write("yes");
}
else
{
    Console.Write("no");
}