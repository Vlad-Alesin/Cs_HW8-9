/* Задача 58: Задайте две матрицы. Напишите программу, которая будет 
находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18

*/

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
int[,] InitArray(int rows, int columns)
{
    int[,] result = new int[rows, columns];
    Random rnd = new Random();

    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            result[i, j] = rnd.Next(-10, 10);
        }
    }
    return result;
}

/*  мы задаем 2 матрицы разных размерностей ([i, j] и [l, m]) и проверяем условие проверка что j == l
если равны работаем дальше, если нет, то умножить нельзя */

//произведение матриц   
void MultiplyMatrix(int [,] array1, int [,] array2)
{
    if (array1.GetLength(0) == array2.GetLength(1))
    {
        
        for (int i = 0; i < array1.GetLength(0); i++)
        {
            for (int j = 0; j < array2.GetLength(1); j++)
            {
                int c = 0;
                for (int k = 0; k < array1.GetLength(1); k++)
                {
                    c += array1[i,k]*array2[k,j];
                }
                Console.Write($"{c} ");
            }
            Console.WriteLine();
        }   

    }
    else Console.WriteLine("такие матрицы нельзя перемножить");
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


int rows1 = GetNumber("Введите количество строк 1 матрицы");
int columns1 = GetNumber("Введите количество столбцов 1 матрицы");
int rows2 = GetNumber("Введите количество строк 2 матрицы");
int columns2 = GetNumber("Введите количество столбцов 2 матрицы");

int[,] array1 = InitArray(rows1, columns1);
int[,] array2 = InitArray(rows2, columns2);

Console.WriteLine("первая матрица");
PrintArray(array1);
Console.WriteLine("вторая матрица");
PrintArray(array2);

Console.WriteLine("перемноженная матрица");
MultiplyMatrix(array1, array2);



