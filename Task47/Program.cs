// Задача 47. Задайте двумерный массив размером m×n, 
// заполненный случайными вещественными числами. Сделать отдельный метод который генерирует двумерный 
// массив и отдельный метод который выводит его на экран.
// m и n вводит пользователь в консоль
// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

Console.WriteLine("Введите число строк: ");
bool isParsedLines = int.TryParse(Console.ReadLine(), out int lines);
Console.WriteLine("Введите число столбцов: ");
bool isParsedColumns = int.TryParse(Console.ReadLine(), out int columns);

if (!isParsedLines || !isParsedColumns)
{
    Console.WriteLine("Ошибка!");
    return;
}

PrintMatrix(FillMatrix(lines, columns));



double[,] FillMatrix(int line, int column)
{
    double[,] matrix = new double[line, column];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(-100, 110) / 10.0;
        }
    }
    return matrix;
}

void PrintMatrix(double[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        Console.Write("[   ");
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]}   ");
        }
        Console.Write("]");
        Console.WriteLine();
    }
}

