// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов 
// в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

using static System.Console;
Clear();

WriteLine("Введите значение N");
int n1 = int.Parse(ReadLine());
WriteLine("Введите значение M");
int m1 = int.Parse(ReadLine());
WriteLine($"Сумма натуральных элементов в промежутке от {m1} до {n1} --> {SumNaturalElements(n1, m1)}");

int SumNaturalElements(int n, int m)
{
    if (n == m || n < m) return m;
    else return SumNaturalElements(n-1, m) + n;
}