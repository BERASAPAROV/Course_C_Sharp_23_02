﻿// 2. Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 2D пространстве.
// AB = √(xb - xa)2 + (yb - ya)2

double distance(double x1, double y1, double x2, double y2)
{
    return Math.Sqrt(Math.Pow(x2 - x1,2) + Math.Pow(y2 - y1,2));
}

Console.WriteLine(distance(3, 6, 2, 1));