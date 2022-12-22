// 17. Напишите программу, которая 
// принимает на вход координаты точки (X и Y), 
// причём X ≠ 0 и Y ≠ 0 и 
// выдаётномер четверти плоскости, в которой находится эта
// точка.
// Console.WriteLine ("Введите координаты точки ");
// Console.Write("X: ");
// int x = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y: ");
// int y = Convert.ToInt32(Console.ReadLine());

// int quarter = Quarter (x, y);
// string result =  quarter > 0 
//                  ? $"указанные координаты соответствуют четверти -> {quarter}"
//                  : "Введены некорректные координаты";
// Console.WriteLine(result);
// int Quarter(int xc, int yc)
// {
//     if (xc > 0 && yc > 0) return 1;
//     if (xc < 0 && yc > 0) return 2;
//     if (xc < 0 && yc < 0) return 3;
//     if (xc > 0 && yc < 0) return 4;
//     return 0;
// 
// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).
Console.WriteLine("Введите номер четверти: ");

string quarter = Console.ReadLine();
string result = QuarterCoordinates(quarter);
Console.WriteLine(result);

string QuarterCoordinates(string number)
{
    if (number == "1") return "x > 0; y > 0";
    if (number == "2") return "x < 0; y > 0";
    if (number == "3") return "x < 0; y < 0";
    if (number == "4") return "x > 0; y < 0";
    return "Некорректные данные";
}


//     if (xc < 0 && yc < 0) return 3;
//     if (xc > 0 && yc < 0) return 4;
//     return 0;