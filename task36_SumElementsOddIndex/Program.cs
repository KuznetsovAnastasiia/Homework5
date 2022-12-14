/*Задача 36: Задайте одномерный массив, заполненный случайными числами.
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0*/

void FillArray(int[] array) // метод заполнения массива
{
    Random random = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = random.Next(-100, 101); // заполняем массив случайными числами от -100 до 100
    }
}

void PrintArray(int[] array) // метод вывода массива
{
    Console.Write("Массив: " + "["); // специально на печать "[" перед массивом, чтобы массив вывелся на консоль, как в примере
    for (int i = 0; i < array.Length - 1; i++) // специально без последного элемента массива
    {
        Console.Write(array[i] + ", ");
        if (i == array.Length - 2) // специально для вывода последного элемента массива
        {
            Console.Write(array[array.Length - 1] + "]"); // специально на печать "]" после массива
        }
    }
    Console.WriteLine();
}

int GetSumOddIndex (int[] array) // метод для подчёта суммы элементов массива, стоящих на нечётных позициях
{
    int summ = 0; // переменная для подчёта суммы элементов массива, стоящих на нечётных позициях
    for (int i = 0; i < array.Length; i++)
    {
        if (i % 2 != 0) // цикл проходится по каждому элементу массива и, если позиция (индекс) элемента нечётный, прибавляет такой элемент к сумме
        {
            summ += array[i];
        }
    }
    return summ;
}

int[] arr = new int[10];
FillArray(arr);
PrintArray(arr);
Console.WriteLine("Сумма элементов массива, стоящих на нечётных позициях: " + GetSumOddIndex(arr) + ".");