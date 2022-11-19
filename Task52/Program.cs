// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее 
// арифметическое элементов в каждом столбце. Поиск среднего арифметического в отдельном методе. 
// Для создания массива и вывода можно воспользоваться методами из 47 задачи.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

Console.WriteLine("Введите количество строк: ");
bool isParsedLines = int.TryParse(Console.ReadLine(), out int lines);
Console.WriteLine("Введите количество столбцов: ");
bool isParsedColumns = int.TryParse(Console.ReadLine(), out int columns);

if (!isParsedLines || !isParsedColumns)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] filledMatrix = FillMatrix(lines, columns);
PrintMatrix(filledMatrix);
ArithmeticAverage(filledMatrix, lines);




int[,] FillMatrix(int line, int column)
{
    int[,] matrix = new int[line, column];
    Random random = new Random();

    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = random.Next(0, 11);
        }
    }
    return matrix;
}

void PrintMatrix(int[,] matrix)
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

void ArithmeticAverage(int[,] matrix, int line)
{
    double arithmeticAverage = default;

    for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            arithmeticAverage += matrix[i, j];
        }

        Console.WriteLine($"Среднее арифметическое столбца {j} = {Math.Round(arithmeticAverage / line, 2)}");
        arithmeticAverage = default;
    }
}