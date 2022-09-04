/*Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму
 натуральных элементов в промежутке от M до N.
M = 1; N = 15 -> 120
M = 4; N = 8. -> 30*/

int M = 1;
int N = 6;
int Numbers = M;
if (M>N)
{
    M = N; N = Numbers;
}
string PrintNumbers(int M, int N)
{
    if (M == N) return M.ToString();
    return (M + ", " + PrintNumbers(M + 1, N));
}
Console.Write(PrintNumbers(M, N));
Console.WriteLine();

void SumNumbers(int M, int N, int sum)
    {
    sum += N;
        if (N <= M)
        {
        Console.Write($"Сумма элементов = {sum}");
        return;
        }
        SumNumbers(M, N - 1, sum);
    }

SumNumbers(M,N,Numbers=0);

