/*Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/


Console.Write("Введите число M: ");
uint M = uint.Parse(Console.ReadLine()!);

Console.Write("Введите число N: ");
uint N = uint.Parse(Console.ReadLine()!);

Console.WriteLine($"Значение функции Аккермана для M и N равно {Akkerman(M,N)}");

uint Akkerman(uint n, uint m)
{
  if (n == 0)
    return m + 1;
  else
    if ((n != 0) && (m == 0))
      return Akkerman(n - 1, 1);
    else
      return Akkerman(n - 1, Akkerman(n, m - 1));
}