// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 1 , 7 -> такого числа в массиве нет
// 1 , 1 -> 1

Console.WriteLine("Введите количество строк: ");
bool isParsedLines = int.TryParse(Console.ReadLine(), out int lines);
Console.WriteLine("Введите количество столбцов: ");
bool isParsedColumns = int.TryParse(Console.ReadLine(), out int columns);
Console.WriteLine("Введите число для поиска в матрице: ");
bool isParsedNumber = int.TryParse(Console.ReadLine(), out int number);


if (!isParsedLines || !isParsedColumns || !isParsedNumber)
{
    Console.WriteLine("Ошибка!");
    return;
}

int[,] filledMatrix = FillMatrix(lines, columns);
PrintMatrix(filledMatrix);
NumberPositioningInMatrix(filledMatrix, number);

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
void NumberPositioningInMatrix(int[,] matrix, int num)
{
    int countOfNumbers = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num == matrix[i, j]) Console.WriteLine($"Позиция числа в матрице ={i},{j}");
            countOfNumbers++;
        }

    }
    if (countOfNumbers == 0) Console.WriteLine("Введенного числа нет в матрице.");
}