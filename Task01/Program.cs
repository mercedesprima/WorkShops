// Задача 1. Напишите программу, 
// которая на вход принимает два числа и проверяет, 
// является ли первое число квадрата второго.
// а = 25, b = 5 -> да
// а = 2, b = 10 -> нет
// а = 9, b = -3 -> да
// а = -3, b = 9 -> нет

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int number2 = Convert.ToInt32(Console.ReadLine());

int square = number2 * number2;

if (square == number1)
Console.WriteLine ("yes");
else Console.WriteLine("no");