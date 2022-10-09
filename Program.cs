﻿
Console.WriteLine("Выберете задачу 41 / 43");
int task = int.Parse(Console.ReadLine());

switch (task)
{
    case 41:
        Task41();
        break;
    case 43:
        Task43();
        break;
    default:
        Console.WriteLine("Это нам не задавали! Это мы не проходили");
        break;
}

void Task41()
{
    Console.WriteLine("Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.");
    Console.WriteLine("Введите количество элементов, которое необходимо проверить: ");
    int size = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Сейчас будем вводить эелеенты: ");
    int[] array = new int[size];
    int numbers = 0;
    for (int i = 0; i < size; i++)
    {
        Console.WriteLine($"Введите эемент: {i + 1}: ");
        array[i] = Convert.ToInt32(Console.ReadLine());
        if (array[i] > 0) numbers += 1;
    }
    Console.WriteLine($"Количество чисел болеше 0 равно {numbers}");
}

void Task43()
{
    Console.WriteLine("Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; значения b1, k1, b2 и k2 задаются пользователем.");
    int inputCoefficients()
    {
        Console.WriteLine("Введите значения b1, k1, b2 и k2:");
        int Coefficients = Convert.ToDouble(Console.ReadLine());
        return Coefficients;
    }
    double b1 = inputCoefficients();
    double k1 = inputCoefficients();
    double b2 = inputCoefficients();
    double k2 = inputCoefficients();


       double x = (b2 - b1) / (k1 - k2);
       double y = k1 * x + b1;
        Console.WriteLine();
        Console.WriteLine(x); 
        Console.WriteLine(x);

        Console.WriteLine($"Прямые пересекутся в точке ({x};{y})");
    
        if (k1 == k2) 
    {
        Console.WriteLine("Точек пересечения нет, так как прямые паралельны");
    }
}
