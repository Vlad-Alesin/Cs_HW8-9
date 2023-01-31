/* Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07 */

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

// инициализации массива и заполнение нулями
int[,] InitArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = 0;
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

int[,] Spiral(int [,] array)
{
    int a = 0;  // для строки
    int b = 0;  // для столбца
    int count = 1;

    while (count != array.GetLength(0)*array.GetLength(1)+1 )
    {
        for (int j = 0 + a; j < array.GetLength(1)-a; j++) // слева направо 
        {
            array[a,j]=count;
            count++;
        }
        for (int i = 0 + b+1; i < array.GetLength(0)-b; i++)  //сверху вниз 
        {
            array[i,array.GetLength(1)-b-1]=count;
            count++;
        }
        for (int j = array.GetLength(1)-a-1; j > 0 + a; j--)   //справа налево 
        {
            array[array.GetLength(0)-b-1,j-1]=count;
            count++;
        }
        a++;
        for (int i = array.GetLength(0)-b-1; i > 0 + b+1; i--)   //снизу вверх 
        {
            array[i-1,0 + b]=count;
            count++;
        }
        b++;
    }
    return array;
}

int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов");

int [,] array = InitArray(rows, columns);
PrintArray(array);
int[,] matrix = Spiral(array);
PrintArray(matrix);

