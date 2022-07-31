// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

int m = Convert.ToInt32(Console.ReadLine());
int n = Convert.ToInt32(Console.ReadLine());
int[,] arr = new int[m, n];
for (int i = 0; i < arr.GetLength(0); i++)
{
    for (int j = 0; j < arr.GetLength(1); j++)
    {
        arr[i, j] = new Random().Next(0, 10);
        Console.Write(arr[i, j] + " ");
    }
    Console.WriteLine();
}
for (int j = 0; j < arr.GetLength(1); j++)
{
    double numb = 0;
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        numb += arr[i, j];
    }
    Console.WriteLine("Сумма в столбце  = {0}", numb);
}