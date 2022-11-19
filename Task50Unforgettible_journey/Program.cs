// Задача 50(читай задачу внимательнее, ёпрст). Напишите программу, которая на вход принимает значение, ищет его в матрице и выдает его координаты.



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
    Console.Write("Координаты числа в матрице ");
    int countOfNumbers = default;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (num == matrix[i, j])
            {
                Console.Write($"{i},{j} ");
                countOfNumbers++;
            }
        }

    }
    if (countOfNumbers == default) Console.Write("отсутствуют.");
}