using System;
using System.IO;


decimal[] mS = new decimal[12];
Random r = new Random();
Console.WriteLine("------------------------------------");
for (int i = 0; i < 12; i++)
{
    mS[i] = (decimal)r.Next(1000, 5001); 
    Console.WriteLine($"Зарплата за {i + 1} месяц: {Math.Round((double)mS[i], 2)}");

}

decimal tS = 0;

foreach (decimal s in mS)
{
    tS += s;
}
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.Yellow;
Console.WriteLine($"Общая сумма выплат за год: {Math.Round((double)tS, 2)}");
Console.ResetColor();

decimal aS = tS / 12;
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine($"Средняя зарплата за год: {Math.Round((double)aS,2)}");
Console.ResetColor();
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Отчисления в пенсионный фонд:");
Console.ResetColor();

decimal vesnalog = 0;

for (int i = 0; i < 12; i++)
{
    decimal nalog = mS[i] * 0.02m;
    Console.WriteLine($"За {i + 1} месяц: {Math.Round((double)nalog, 2)}");
    vesnalog += nalog;
}
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.Blue;
Console.WriteLine($"Общие отчисления за год: {Math.Round((double)vesnalog, 2)}");
Console.ResetColor();
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkYellow;
Console.WriteLine("Отклонения от средней зарплаты:");
Console.ResetColor();

for (int i = 0; i < 12; i++)
{
    decimal deviation = mS[i] - aS;
    Console.WriteLine($"За {i + 1} месяц: {Math.Round((double)deviation,2)}");
}
decimal maxSalary = mS[0];
decimal minSalary = mS[0];
int maxMonth = 1;
int minMonth = 1;

for (int i = 1; i < 12; i++)
{
    if (mS[i] > maxSalary)
    {
        maxSalary = mS[i];
        maxMonth = i + 1;
    }

    if (mS[i] < minSalary)
    {
        minSalary = mS[i];
        minMonth = i + 1;
    }
}
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine($"Максимальная зарплата: {Math.Round((double)maxSalary, 2)} в {Math.Round((double)maxMonth, 2)} месяце");
Console.ResetColor();
Console.WriteLine("------------------------------------");
Console.ForegroundColor = ConsoleColor.DarkMagenta;
Console.WriteLine($"Минимальная зарплата: {Math.Round((double)minSalary, 2)} в {Math.Round((double)minMonth, 2)} месяце");
Console.ResetColor();
