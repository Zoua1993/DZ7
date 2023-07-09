
// Задача 1. 
// Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными(тип double) числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

Console.Write("Введите размер m массива: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите размер n массива: ");
int n = Convert.ToInt32(Console.ReadLine()!);
double[,] randomArray = new double[m, n];
void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
            Console.Write($"{randomArray[i, j]:F2}");
        }
    }
}
mas(m, n);



//Задача 2. 
//Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// i = 1, j = 2 -> 2
// i = 4, j = 2 -> такого элемента не существует

Console.Write("Введите размер m массива: ");
int m =Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите размер n массива: ");
int n =Convert.ToInt32(Console.ReadLine()!);
double[,] randomArray = new double[m, n];
Console.Write("Введите позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите позицию строки: ");
int n2 = Convert.ToInt32(Console.ReadLine()!);
void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for (j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.NextDouble();
            Console.Write($"{randomArray[i, j]:F2}");
        }
    Console.WriteLine();    
    }
}
mas(m, n);
if (m2 < 1 || n2 < 1)
Console.Write("Позиции строк не отрицательны");
else if (m2 <= m + 1 && n2 <= n + 1)
Console.Write($" Значение элемента равно {randomArray[m2 - 1, n2 -1]: F2}");
else Console.Write("Такого элемента не существует");



// Задача 3.
// Задайте двумерный массив из целых чисел. 
// Найдите среднее арифметическое* элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.
// * Сумма всех цифр / их количество(это количество ваших строк)

Console.Write("Введите размер массива m: ");
int m = Convert.ToInt32(Console.ReadLine()!);
Console.Write("Введите размер массива n: ");
int n = Convert.ToInt32(Console.ReadLine()!);
int [,] randomArray = new int [m, n];
void mas(int m, int n)
{
    int i, j;
    Random rand = new Random();
    for (i = 0; i < m; i++)
    {
        Console.WriteLine();
        for(j = 0; j < n; j++)
        {
            randomArray[i, j] = rand.Next(1,9);
            Console.Write($"{randomArray [i, j]}");
        }
        Console.WriteLine();
    }
}
void arif(int m, int n)
{
    Console.Write("Среднее аривметическое каждого столбца: ");
    int i, j;
    Random rand = new Random();
    for (j = 0; j < n; j++)
    {
        double sum = 0;
        for (i = 0; i < m; i++)
        {
            sum = sum + randomArray[i, j];
        }
        Console.Write($"{sum/(i):F1}");
    }
}
mas(m, n);
arif(m, n);


