using System;
using System.Reflection;
x:
Console.WriteLine("Введите координату x");
int x0;
if (!int.TryParse(Console.ReadLine(), out x0))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введена координата x");
    Console.ResetColor();
    goto x;
}
Console.WriteLine("Введите координату y");
y:
int y0;
if (!int.TryParse(Console.ReadLine(), out y0) | y0 < 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введена координата y");
    Console.ResetColor();
    goto y;
}
Console.WriteLine("Введите начальную скорость");
v:
int v0; 
if (!int.TryParse(Console.ReadLine(), out v0) | v0 <= 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введена скорость");
    Console.ResetColor();
    goto v;
}
a:
Console.WriteLine("Введите угол а (градусы)");
double a;
if (!double.TryParse(Console.ReadLine(), out a) && a <=360)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введен угол");
    Console.ResetColor();
    goto a;
}
if (y0 == 0)
{
    if (a > 180) 
    {
        Console.ForegroundColor = ConsoleColor.Yellow;
        Console.WriteLine("При таких координатах максимальное значение угла будет равно '180'");
        Console.ResetColor();
        goto a;
    }
}

    a = (Convert.ToInt32(a * Math.PI)) / 180;


double vx0 = v0 * Math.Cos(a);
double vy0 = v0 * Math.Sin(a);

const double g = 9.81;

double x = x0, y = y0;
double t = 0;
Console.WriteLine(new string('-', 50));
Console.WriteLine($"|    x    |    y    |");
double ym = 0;
double a_radian = 0;
while (y >= 0)
{
    x = x0 + (v0 * Math.Cos(a_radian)) * t;
    y = y0 + (v0 * Math.Sin(a_radian)) * t - ((g * t * t) / 2);
    if (y < 0)
    {
        break;
    }
    if (ym < y)
    {
        ym = y;
    }
    Console.WriteLine($"|    {Math.Round(x, 2)}   |   {Math.Round(y, 2)}   ");
    t = Math.Round(t + 0.1, 1);

}
