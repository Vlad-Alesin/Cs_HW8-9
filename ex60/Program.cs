/* Задача 60. ...Сформируйте трёхмерный массив из 
неповторяющихся двузначных чисел. Напишите программу, 
которая будет построчно выводить массив, добавляя индексы каждого элемента.

Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1) */

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
int[,,] InitArray(int rows, int columns, int deep)
{
    int[,,] result = new int[rows, columns, deep];      
    
    int controle = 10;
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j < columns; j++)
        {
            for (int k = 0; k < deep; k++)
            {

                result[i, j, k] = controle;
                controle++;
                if (controle > 99) controle = controle / 10;
            }
        }
    }
    return result;

}

// метод печати массива
void PrintArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}");
                Console.Write($"({i}, {j}, {k})    ");
            }
            Console.WriteLine();
        } 
    }
    Console.WriteLine();
}


int rows = GetNumber("Введите количество строк");
int columns = GetNumber("Введите количество столбцов в ширину");
int deep = GetNumber("Введите количество столбцов в глубину");

if (rows*columns*deep > 90) Console.WriteLine("невозможно обеспечить уникальность каждого элемента");
int [,,] array = InitArray(rows, columns, deep);
PrintArray(array);
