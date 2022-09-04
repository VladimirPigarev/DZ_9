// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от M до N по убыванию.
// M = 1; N = 5. -> ""5,4,3,2,1""
// M = 4; N = 8. -> ""8,7,6,5,4""

using static System.Console;
Clear();

WriteLine("Введите значение N");
int n1 = int.Parse(ReadLine());
WriteLine("Введите значение M");
int m1 = int.Parse(ReadLine());
WriteLine($"{OutputNaturalNumbers(n1, m1)}");

string OutputNaturalNumbers(int n, int m)
{
    if (n == m || n < m) return $"{m}";
    else return $"{n} " + OutputNaturalNumbers(n-1,m);
}














// int m = Convert.ToInt32(ReadLine());
// WriteLine("Введите значение M");
// int n = Convert.ToInt32(ReadLine());
// WriteLine(OutputNaturalNumbers(m, n));

// string OutputNaturalNumbers(int m1, int n1)
// {
//     return (m1==n1 || n1 < m1)? "{m1}":OutputNaturalNumbers(m1-1, n1) + n1;
// }