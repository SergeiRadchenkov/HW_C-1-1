﻿/* Задача 4: Напишите программу, 
которая принимает на вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22 */

Console.Write("Введите число 1: ");
int number1 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 2: ");
int number2 = int.Parse(Console.ReadLine()!);
Console.Write("Введите число 3: ");
int number3 = int.Parse(Console.ReadLine()!);

int max = number1;

if(max < number2)
{
    max = number2;
}
if(max < number3)
{
    max = number3;
}
Console.WriteLine($"Максимальное число: {max}");