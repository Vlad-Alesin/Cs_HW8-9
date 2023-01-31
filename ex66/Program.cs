/* Задача 66: Задайте значения M и N. Напишите программу, 
которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30    */


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

int m = GetNumber("Введите число M");
int n = GetNumber("Введите число N");

int count = 0;

void SumFromTo(int start, int end)
{
    count += start;
    if (start < end) 
    {
        SumFromTo(start+1, end);
    }  
    else 
    { 
        Console.Write(count);
    }  
}

SumFromTo(m, n);

