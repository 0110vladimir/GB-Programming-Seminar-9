/*Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8. -> 30
*/

Console.Write("Введите число M: ");
int M = int.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

if(M>N)Console.WriteLine($"Сумма чисел между M и N равна {SumRec(N,M)}");
if(M<N)Console.WriteLine($"Сумма чисел между M и N равна {SumRec(M,N)}");
if(M==N) Console.WriteLine("Сумма чисел между M и N равна 0");


int SumRec(int a, int b)
{
 if (b-1 == a) return 0;
 else return b-1 + SumRec(a,b - 1);
}
