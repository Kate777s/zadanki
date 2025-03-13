using System;

a:
Console.WriteLine("Введите нижний предел (a): ");
double a;
if (!double.TryParse(Console.ReadLine(), out a))
{
    Console.WriteLine("Неверно введен предел");
    goto a;
}
b:
Console.WriteLine("Введите верхний предел (b): ");
double b;
if (!double.TryParse(Console.ReadLine(), out b))
{
Console.WriteLine("Неверно введен предел");
goto b;
}
n:
Console.WriteLine("Введите кол-во разбиений (n): ");
int n;
if (!int.TryParse(Console.ReadLine(), out n))
{
    Console.WriteLine("Неверно введено разбиение");
    goto n;
}
double sum = 0;
double h = (b - a) / n;

double F(double x)
{
    return 2 * x * x + 3 * x;
}

for (int i = 1; i < n; i++)
{
    double x = a + i * h;
    sum += F(x);
}
double result = h * sum;

Console.WriteLine($"Определенный интеграл от {a} до {b} примерно равен: {Math.Round(result, 2)}");