﻿/*Задача 69: Напишите программу, которая на вход принимает два числа A и B, и
возводит число А в целую степень B с помощью рекурсии.
A = 3; B = 5 -> 243 (3⁵)
A = 2; B = 3 -> 8
 */

Console.Write("Введите целое число A: ");
int inputNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите натуральное число B: ");
int inputDegree = Convert.ToInt32(Console.ReadLine());

if (inputDegree >= 0)
    Console.WriteLine(MathPow(inputNumber, inputDegree));
else Console.WriteLine($"Ошибка ввода степени.");

int MathPow(int num, int degree)
{
    if (degree == 0) return 1;
    else return num * MathPow(num, degree - 1);
}
