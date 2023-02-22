// Напишите программу,
// которая принимает на вход координаты двух точек и находит
// расстояние между ними в 2D пространстве.

// A (3,6); B(2, 1)-> 5,09
// A(7, -5); B(1, -1)-> 7,21
//sqrt((3 - 2)^2 + (6 - 1)^2) = 5.09

Console.Clear();
Console.Write("Введите X1: ");
int X1 = int.Parse(Console.ReadLine());
Console.Write("Введите Y1: ");
int Y1 = int.Parse(Console.ReadLine());

Console.Write("Введите X2: ");
int X2 = int.Parse(Console.ReadLine());

Console.Write("Введите Y2: ");
int Y2 = int.Parse(Console.ReadLine());

// double s = Math.Sqrt((X1 - X2)^2 + (Y1 - Y2)^2);нельзя знак ^,не распознает
double s = Math.Sqrt(Math.Pow(X1 - X2, 2) + Math.Pow(Y1 - Y2, 2));
Console.WriteLine($"A ({X1},{Y1}); B ({X2},{Y2}) -> {s:f2}"); // f2 означает сколько цифр после запятой оставить
