int A(int m, int n)
{
  if (m == 0)
    return n + 1;
  else
    if ((m > 0) && (n == 0))
      return A(m-1, 1);
    else
      return A(m - 1, A(m, n - 1));
}

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(A(a, b));