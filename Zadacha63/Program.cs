
/*Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
M = 1; N = 5. -> ""1, 2, 3, 4, 5""
M = 4; N = 8. -> ""4, 6, 7, 8""*/

int M = 1;
int N = 10;

string PrintNumbers(int M, int N)
{
    if (M == N) return M.ToString();
    return (M + ", " + PrintNumbers(M + 1, N));
}
Console.Write($"Целые числа от {M} до {N} : {PrintNumbers(M, N)}");
