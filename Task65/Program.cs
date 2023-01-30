// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.WriteLine("Введите натуральное число M :");
int numberM = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите натуральное число N :");
int numberN = Convert.ToInt32(Console.ReadLine());

if (numberM > 0 && numberN > 0) NaturalNumbersRange(numberM, numberN);
else  Console.WriteLine("Одно из чисел или оба числа ненатуральные.");


void NaturalNumbersRange(int numM, int numN)
{
    if (numM == numN) Console.Write($"{numM} ");
    else if (numM < numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersRange(numM + 1, numN);
    }
    else if (numM > numN)
    {
        Console.Write($"{numM} ");
        NaturalNumbersRange(numM - 1, numN);
    }
}