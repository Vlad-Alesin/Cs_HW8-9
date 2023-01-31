/* Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, 
которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки 
с наименьшей суммой элементов: 1 строка  */

int GetNumber(string message)
{
    int result = 0;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число");
        }
    }
    return result;
}

//метод для инициализации массива рандомными числами
int[,] InitArray(int rows, int columns, int leftBound, int rightBound)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(leftBound, rightBound);
        }
    }
    return result;
}

// метод печати массива
void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            {
                Console.Write($"{array[i, j]} ");
            }
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

void MinString(int[,] array, int rightBound)
{
    int minCount = rightBound*array.GetLength(0);
    int minStr = 0;

    for (int i = 0; i < array.GetLength(0); i++)
    {
        int count =0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            count += array[i, j];
        }
        if (minCount > count)
        {
            minCount = count;
            minStr = i;
        }
    }
    Console.WriteLine($" номер строки с наименьшей суммой элементов: {minStr+1}");
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[,] array = InitArray(rows, columns, leftBound, rightBound);

PrintArray(array);
MinString(array, rightBound);