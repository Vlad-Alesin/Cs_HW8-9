/* Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29    */


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

int Akkerman(int M, int N)
{
    
    if (M == 0) return N+1;
    else if (M > 0 && N == 0) return Akkerman(M-1, 1);
    else if (M > 0 && N > 0) return Akkerman(M-1, Akkerman(M, N-1));        
    else return 0;
    
}

int M = GetNumber("Введите число M");
int N = GetNumber("Введите число N");

int b = Akkerman(M , N);
Console.WriteLine(b);

