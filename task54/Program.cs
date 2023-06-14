// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2



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

for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n - 1; j++)
    {
        for (int k = j + 1; k < n; k++)
        {
            if (myArray[i, j] < myArray[i, k])
            {
                int temp = myArray[i, j];
                myArray[i, j] = myArray[i, k];
                myArray[i, k] = temp;
            }
        }
    }
}


Console.WriteLine("Ваш массив:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(myArray[i, j] + " ");
    }
    Console.WriteLine();
}








