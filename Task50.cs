// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, 
//и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

Console.WriteLine("Введите количество строк");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();

int[,] array = new int[m, n];

FillArray(array);
Print(array);
FindElement(array);

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


void FindElement(int[,] arr)
{
    Console.WriteLine("Введите номер строки");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Введите номер столбца");
    int n = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine();
    int i = m;
    int j = n;

    if (i < arr.GetLength(0) && j < arr.GetLength(1))
    {
        Console.WriteLine($"Значение элемента - {arr[m,n]}");
    } 
    else
    {
        Console.WriteLine("Такого элемента не существует"); 
    }
}

