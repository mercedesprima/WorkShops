// Задача 42: Напишите программу, которая будет преобразовывать
// десятичное число в двоичное.
// 45 -> 101101
// 3 -> 11
// 2 -> 10

                                        // Вариант 1
string res = ConvertDecToBin(2);
Console.WriteLine(res);

string ConvertDecToBin(int num)
{
    string result = string.Empty;
    while (num > 0)
    {
        result = num % 2 + result;
        num = num / 2;
    }
    return result;
}
                                             // Вариант 2
Console.Write("Введите число для преобразования в двоичную систему счисления: ");
int number = Convert.ToInt32(Console.ReadLine());

int convertDecimalToBinary = ConvertDecimalToBinary(number);
Console.WriteLine(convertDecimalToBinary);

int ConvertDecimalToBinary(int num)
{
    int result = 0;
    int multiplyer = 1;

    while (num != 0)
    {
        result = result + num % 2 * multiplyer;
        num = num / 2;
        multiplyer *= 10;

    }

    return result;
}