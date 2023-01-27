using System;
using static System.Console;

Clear();
Write("Введите b1: ");
float B1 = float.Parse(ReadLine());
Write("Введите k1: ");
float K1 = float.Parse(ReadLine());
Write("Введите b2: ");
float B2 = float.Parse(ReadLine());
Write("Введите k2: ");
float K2 = float.Parse(ReadLine());

float x = (B2-B1)/(K1-K2);

WriteLine($"Точка пересечения двух прямых ({x}, {K1*x+B1})");