﻿// Задача 10: Напишите программу, которая принимает на
//вход трёхзначное число и на выходе показывает вторую
//цифру этого числа.

Console.Write("Введите трехзначное число:  ");
int number = Convert.ToInt32(Console.ReadLine());
int number1 = (number / 10) % 10;
Console.WriteLine(number1);

