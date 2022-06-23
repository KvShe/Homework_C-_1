/*
Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3 
*/

Console.Write("Введите первое число: ");
int numberOne = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите второе число: ");
int numberTwo = Convert.ToInt32(Console.ReadLine());

if (numberOne > numberTwo)
{
    Console.WriteLine("max = " + numberOne);
    Console.WriteLine("min = " + numberTwo);
}
else
{
    Console.WriteLine("max = " + numberTwo);
    Console.WriteLine("min = " + numberOne);
}
