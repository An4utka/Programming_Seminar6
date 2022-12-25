﻿// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями 
// y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.
// Формулы нахождения координат x и y точки пересечения:
// x = (b2-b1)/(k1-k2);
// y = k1*x+b1;

Console.WriteLine("Enter b1:");
double b1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k1:");
double k1 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter b2:");
double b2 = double.Parse(Console.ReadLine());
Console.WriteLine("Enter k2:");
double k2 = double.Parse(Console.ReadLine());
double x = (b2 - b1) / (k1 - k2);
double y = k1 * x + b1;
Console.Write($"The point of intersection will be here: ({x};{y})");