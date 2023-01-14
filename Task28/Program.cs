// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number <=0)
Console.WriteLine($"Введено не натуральное число");
else 
{
int factorialNumber = FactorialNumber(number);
Console.WriteLine($"Произведение чисел от 1 до {number} = {factorialNumber}");


int FactorialNumber(int num)
{
    int result = 1;
    for (int i = 1; i <= num; i++)
    {
        checked
        {
            result *= i;
        }
    }
    return result;
}
}