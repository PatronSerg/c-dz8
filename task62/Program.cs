// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07





int[,] spiralArray = new int[4, 4];
int row = 0, col = 0;
int direction = 0;
int counter = 1;
while (counter <= 16)
{
    spiralArray[row, col] = counter;
    counter++;

    if ((direction == 0 && (col == 3 || spiralArray[row, col + 1] != 0))
        || (direction == 1 && (row == 3 || spiralArray[row + 1, col] != 0))
        || (direction == 2 && (col == 0 || spiralArray[row, col - 1] != 0))
        || (direction == 3 && (row == 0 || spiralArray[row - 1, col] != 0)))
    {
        direction = (direction + 1) % 4;
    }

    if (direction == 0) col++;
    else if (direction == 1) row++;
    else if (direction == 2) col--;
    else if (direction == 3) row--;
}
for (int i = 0; i < spiralArray.GetLength(0); i++)
{
    for (int j = 0; j < spiralArray.GetLength(1); j++)
    {
        Console.Write($"{spiralArray[i, j]:D2} ");
    }
    Console.WriteLine();
}
