using System;
// Задача 3: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
Console.Clear();
System.Console.WriteLine();

int size = 4;

int[] FillArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(10, 100);
    }
    return array;
}

System.Console.WriteLine($"Количетсов элементов массива: {size}");


void PrintDiffMinMax(int[] Array)
{
    for (int i = 0; i < Array.Length; i++)
    {
        System.Console.WriteLine(Array[i]);
    }
    double difference = Array.Max() - Array.Min();
    System.Console.WriteLine($"Минимальное значение массива {Array.Min()}, максимальное значение массива {Array.Max()}");
    System.Console.WriteLine($"Разница между минимальным и максимальным значениями массива составляет {difference}");
    System.Console.WriteLine();
}

PrintDiffMinMax(FillArray(size));
System.Console.WriteLine();