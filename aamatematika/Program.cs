using System;
using System.Reflection;
x:
Console.WriteLine("Введите координату x");
int x0;
if (!int.TryParse(Console.ReadLine(), out x0))
{
    Console.WriteLine("Неверно введена координата x");
    goto x;
}
Console.WriteLine("Введите координату y");
y:
int y0;
if (!int.TryParse(Console.ReadLine(), out y0) | y0 < 0)
{
    Console.WriteLine("Неверно введена координата y");
    goto y;
}
Console.WriteLine("Введите начальную скорость");
v:
int v0; 
if (!int.TryParse(Console.ReadLine(), out v0) | v0 <= 0)
{
    Console.WriteLine("Неверно введена скорость");
    goto v;
}
a:
Console.WriteLine("Введите угол а (градусы)");
double a;
if (!double.TryParse(Console.ReadLine(), out a) | a <=0 | a > 360)
{
    Console.WriteLine("Неверно введен угол");
    goto a;
}

a = (Convert.ToInt32(a * Math.PI)) / 180;


double vx0 = v0 * Math.Cos(a);
double vy0 = v0 * Math.Sin(a);

const double g = 9.81;

double x = x0, y = y0;
double t = 0;
Console.WriteLine(new string('-', 50));
Console.WriteLine($"  x  |  y  |  t  ");
double t_t = Math.Round(2 * vy0 / g, 1);
while (t <= t_t)
{
    x = x0 + vx0 * t;
    y = y0 + vy0 * t - ((g * Math.Pow(t, 2)) / 2);


    Console.WriteLine($" {Math.Round(x, 2)}  |  {Math.Round(y, 2)}  |  {t} ");
    t = Math.Round(t + 0.1, 1);
}

Console.WriteLine(new string('-', 50));
Console.WriteLine($"Общее время полета: {t_t} секунд");