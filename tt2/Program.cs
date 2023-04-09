int f(int a, int b)
{
  if (a == b)
    return b;
  return f(a + 1, b) + a; 
}

Console.Clear();
Console.Write("Введите первое число: ");
int a = int.Parse(Console.ReadLine()!);
Console.Write("Введите второе число: ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine(f(a, b));