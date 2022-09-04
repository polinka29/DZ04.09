/*Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9*/

int M = 2;
int N = 3;

int function = Numbers(M, N);
int Numbers(int M, int N)
{
  if (M == 0)
    {
        return N + 1;
    } 
  else if (N == 0)
    {
        return Numbers(M - 1, 1);
    }
  else
    {
        return Numbers(M - 1, Numbers(M, N - 1));
    }
}
Console.Write($"Numbers(M, N) = {function} ");

