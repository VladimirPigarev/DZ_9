// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 29

using static System.Console;
Clear();

WriteLine("Введите значение N");
int n1 = int.Parse(ReadLine());
WriteLine("Введите значение M");
int m1 = int.Parse(ReadLine());
WriteLine($" M={m1}, N={n1} --> A({m1},{n1}) = {FunctionAkkerman(n1, m1)}");

int FunctionAkkerman(int n, int m)
{
    if(n == 0) return m + 1;
    else
    {
        if((n != 0) && (m == 0)) return FunctionAkkerman(n - 1, 1);
        else return FunctionAkkerman(n-1, FunctionAkkerman(n, m - 1));
    }
}