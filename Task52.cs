// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое 
// элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

FillArray(array);
Print(array);
FindAverage(array);

void FillArray(int[,] arr)
{
    var random = new Random();
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
           arr[i,j] = random.Next(1, 100);
        }
    }
}

void Print(int[,] arr)
{
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        for(int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j]} ");
        }
        Console.WriteLine();
    }
}

void FindAverage(int[,] arr)
{
    for(int j = 0; j < arr.GetLength(1); j++)
    {
        double sum = 0;
    
    for(int i = 0; i < arr.GetLength(0); i++)
    {
        sum += arr[i, j];
    }
    double average = Math.Round(sum / arr.GetLength(0), 2);
    Console.Write($"Среднее арифметическое столбца {j} - {average} ");
    Console.WriteLine();
    }
}