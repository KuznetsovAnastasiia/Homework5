﻿/*Задача 34: Задайте массив заполненный случайными положительными
трёхзначными числами. Напишите программу, которая покажет
количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2*/

void FillArray(int[] arr) // метод заполнения массива
{
    Random random = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = random.Next(100, 1000); // заполняем массив случайными числами от 100 до 999
    }
}

void PrintArray(int[] arr) // метод вывода массива
{
    Console.Write("Массив: " + "["); // специально на печать "[" перед массивом, чтобы массив вывелся на консоль, как в примере
    for (int i = 0; i < arr.Length - 1; i++) // специально без последного элемента массива
    {
        Console.Write(arr[i] + ", ");
        if (i == arr.Length - 2) // специально для вывода последного элемента массива
        {
            Console.Write(arr[arr.Length - 1] + "]"); // специально на печать "]" после массива
        }
    }
    Console.WriteLine();
}

int GetQuantityEvenNumbers(int[] arr) // метод для подсчёта количества чётных чисел в массиве
{
    int count = 0; // переменная для подсчёта количества чётных чисел в массиве
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] % 2 == 0) // цикл проходится по каждому элементу массива и, если число чётное, увеличивает количество чётных чисел в массиве на единицу
        {
            count++;
        }
    }

    return count;
}

int[] array = new int[10];
FillArray(array);
PrintArray(array);
Console.WriteLine("Количество чётных чисел в массиве: " + GetQuantityEvenNumbers(array) + ".");