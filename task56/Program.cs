// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 5 2 6 7

// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка



Console.Write("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] myArray = new int[m, n];
Random rnd = new Random();
for (int i = 0; i < m; i++) {
      for (int j = 0; j < n; j++) {
        myArray[i, j] = (rnd.Next(1,100));
      }
    }
Console.WriteLine("Исходный массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(myArray[i, j] + " ");
    }
    Console.WriteLine();
}

int minSum = int.MaxValue;
int minIndex = 0;

for (int i = 0; i < m; i++) {
    int sum = 0;
    for (int j = 0; j < n; j++) {
        sum += myArray[i, j];
    }
    if (sum < minSum) {
        minSum = sum;
        minIndex = i;
    }
}

Console.WriteLine($"Строка с наименьшей суммой элементов: {minIndex + 1}");