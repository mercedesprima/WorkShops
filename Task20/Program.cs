// Задача 20: Напишите программу, которая
// 1)принимает на вход координаты двух точек и
// 2) находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
 
Console.WriteLine ("Введите координаты точки A: ");
Console.Write("X: ");
int xa = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int ya = Convert.ToInt32(Console.ReadLine());

Console.WriteLine ("Введите координаты точки B: ");
Console.Write("X: ");
int xb = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yb = Convert.ToInt32(Console.ReadLine());

double ourDistance = Math.Round(Distance(xa, ya, xb, yb), 2, MidpointRounding.ToZero);
Console.WriteLine($"Расстояние между точкой А с координатами {xa}, {ya}; и точкой B с координатами {xb}, {yb} равно {ourDistance}");

double Distance (int x1, int y1, int x2, int y2)
 {
    double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2));
    return distance;
 }

// Решение 2
// Console.WriteLine("Please, enter coordinates of two segments : ");
// Console.WriteLine("XA : ");
// int xa = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("XB : ");
// int xb = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YA : ");
// int ya = Convert.ToInt32(Console.ReadLine());
// Console.WriteLine("YB : ");
// int yb = Convert.ToInt32(Console.ReadLine());

// double ourDistance = Math.Round(Distance(xa, xb, ya, yb), 2, MidpointRounding.ToZero);
// Console.WriteLine($"Distance between segments with coordinates {xa} , {xb} and {ya}, {yb} is {ourDistance}.");

// double Distance (int x1, int x2, int y1, int y2)
// {
//     double distance = Math.Sqrt(Math.Pow((x2-x1), 2) + Math.Pow((y2-y1),2));
//     return distance;
// }