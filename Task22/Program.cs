// Задача 22: Напишите программу, которая
// принимает на вход число (N) и 
// выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите натуральное число N:   ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    TableSquare(number);
}
else Console.WriteLine("Не натуральное число");
void TableSquare(int num)
{
    int index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 4} {index * index, 15}");
        index++;
    }
}