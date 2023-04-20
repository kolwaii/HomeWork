﻿// Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.
int Quarter(int x, int y)
{
    if (x > 0 && y > 0) return 1;
    if (x < 0 && y > 0) return 2;
    if (x < 0 && y < 0) return 3;
    if (x > 0 && y < 0) return 4;
    return 0;
}
Console.WriteLine("Введите координаты точки");
Console.Write("x: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());

int quarter = Quarter(xCoordinate,yCoordinate);
string result = quarter > 0 
                ? $"Указанные координаты соотвествуют четверти -> {quarter}"
                : "Введены некорректные координаты ";
Console.WriteLine(result);
