﻿//Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int number = int.Parse(Console.ReadLine());
int cube = 0;

int CubeNumber (int number)
{
    int cube = 1;
    for (int i = 1; i <= number; i++)
        {
            cube = (i * i * i);
            Console.Write($"| {cube, 2}");
        }
    return cube;
}

int result = CubeNumber (number);
Console.Write($"   -> Произведение кубов чисел от 1 до {number}");
