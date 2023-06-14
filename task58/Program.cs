// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18


Console.Write("Введите количество строк и столбцов матриц: ");
int m = Convert.ToInt32(Console.ReadLine());
int[,] myArray1 = new int[m, m];

Random rnd = new Random();
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        myArray1[i, j] = (rnd.Next(1, 100));
    }
}

int[,] myArray2 = new int[m, m];
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        myArray2[i, j] = (rnd.Next(1, 100));
    }
}

int[,] resultArray = new int[m,m];
for (int i = 0; i <m; i++)
{
    for (int j = 0; j < m; j++)
    {
        int sum = 0;
        for (int k = 0; k < m; k++)
        {
            sum += myArray1[i, k] * myArray2[k, j];
        }
        
        resultArray[i,j] = sum ;
    }
}

Console.WriteLine("Результат умножения матриц:");
for (int i = 0; i < m; i++)
{
    for (int j = 0; j < m; j++)
    {
        Console.Write(resultArray[i, j] + " ");
    }
    Console.WriteLine();
}