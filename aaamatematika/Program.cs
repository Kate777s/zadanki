using System;

Console.WriteLine("Введите a: ");
double a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите b: ");
double b = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите h: ");
double h = Convert.ToInt32(Console.ReadLine());
double minV = double.MaxValue;
double maxV = double.MinValue;
int smenaznaka = 0;
double prevY = 0;
int tocki = 0;

Console.WriteLine($"|   x   |    y(x)    |");

for (double x = a; x <= b; x += h){
    double y = Math.Cos(x * x) + Math.Pow(Math.Sin(x), 2);
    Console.WriteLine($"| {x:F4} | {y:F4} |");
    minV = Math.Min(minV, y);
    maxV = Math.Max(maxV, y);
    if (x > a)
    {
        if ((prevY > 0 && y < 0) || (prevY < 0 && y > 0)) ;
    
        {
        smenaznaka++;
        }
    }
    prevY = y;
    tocki++;
};

Console.WriteLine($"Количество точек: {tocki}");
Console.WriteLine($"Минимальное значение: {minV:F4}");
Console.WriteLine($"Максимальное значение: {maxV:F4}");
Console.WriteLine($"Количество смен знака: {smenaznaka}");
