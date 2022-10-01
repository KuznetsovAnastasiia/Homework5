/*Задача 38: Задайте массив вещественных чисел. Найдите
разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76*/

void FillArray(double[] array) // метод заполнения массива, double - так как надо заполнить вещественными числами
{
    Random random = new Random();
    for(int i = 0; i < array.Length; i++)
        {
            array[i] = Convert.ToDouble(random.Next(-10000, 10000)) / 100; // заполняем массив случайными вещественными числами в диапазоне от -100,00 до 100,00
        } 
}

void PrintArray(double[] array) // метод вывода массива
{
    Console.Write("Массив: " + "["); // специально на печать "[" перед массивом, чтобы массив вывелся на консоль, как в примере
    for (int i = 0; i < array.Length - 1; i++) // специально без последного элемента массива
    {
        Console.Write(array[i] + " ");
        if (i == array.Length - 2) // специально для вывода последного элемента массива
        {
            Console.Write(array[array.Length - 1] + "]"); // специально на печать "]" после массива
        }
    }
    Console.WriteLine();
}

double MaxElement (double[] array) // метод для нахождения максимального элемента массива
{
    double maxElement = array[0]; // приравниваем переменной значение первого элемента массива (индекс [0])
    for (int i = 1; i < array.Length; i++) 
    {
        if (array[i] > maxElement) // цикл проходится по каждому элементу массива, начиная со второго (индекс [1])
        {
            maxElement = array[i]; // если текущий элемент больше значения переменной, приравниваем его значение переменной
        }
    }
    return maxElement;
}

double MinElement (double[] array) // метод для нахождения минимального элемента массива
{
    double minElement = array[0]; // приравниваем переменной значение первого элемента массива (индекс [0])
    for (int i = 1; i < array.Length; i++) 
    {
        if (array[i] < minElement) // цикл проходится по каждому элементу массива, начиная со второго (индекс [1])
        {
            minElement = array[i]; // если текущий элемент меньше значения переменной, приравниваем его значение переменной
        }
    }
    return minElement;
}

double GetDiffMaxMin (double[] array, double maxElement, double minElement) // метод для нахождения разницы между максимальным и минимальным элементами массива; нужны входные параметры: сам массив, максимальный и минимальный элементы (результаты работы предыдущих методов)
{
    double diff = Math.Round((maxElement - minElement), 2); // с помощью функции округляем разницу до двух знаков полсе запятой (в некоторых тестах без округления получалось куча знаков после запятой)
    return diff;
}

double[] arr = new double[10];
FillArray(arr);
PrintArray(arr);
double maxElement = MaxElement(arr);
Console.WriteLine("Максимальный элемент массива: " + maxElement + ".");
double minElement = MinElement(arr);
Console.WriteLine("Минимальный элемент массива: " + minElement + ".");
Console.WriteLine("Разница между максимальным и минимальным элементами массива: " + GetDiffMaxMin(arr, maxElement, minElement) + ".");