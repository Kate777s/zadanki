using System;
n:
Console.WriteLine("Введите размерность квадратной таблицы N: ");
int n;
if (!int.TryParse(Console.ReadLine(), out n) & n > 0)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введена размерность. Попробуйте еще раз");
    Console.ResetColor();
    goto n;
}
w:
Console.WriteLine("Введите верхний предел: ");
int up;
if (!int.TryParse(Console.ReadLine(), out up))
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введен предел. Попробуйте еще раз");
    Console.ResetColor();
    goto w;
}
ee:
Console.WriteLine("Введите нижний предел: ");
int down;
if (!int.TryParse(Console.ReadLine(), out down) & down < up)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введен предел. Попробуйте еще раз");
    Console.ResetColor();
    goto ee;
}
hh:
Console.WriteLine("введите действие (+,-)");
string? deistvie = Console.ReadLine();
if (deistvie != "+" && deistvie != "-")
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Неверно введены данные. Попробуйте еще раз");
    Console.ResetColor();
    goto hh;
}

int[,] m1 = new int[n, n];
int[,] m2 = new int[n, n];

Random aa = new Random();

for  (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        m1[i, j] = aa.Next(down, up);
    }
}
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        m2[i, j] = aa.Next(down, up);
    }
}

double[,] result = new double[n, n];

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        switch (deistvie)
        {
            case "+":
                result[i, j] = m1[i, j] + m2[i, j];
                break;

            case "-":
                result[i, j] = m1[i, j] - m2[i, j];
                break;
        }

    }
}

for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(m1[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(m2[i, j] + " ");
    }
    Console.WriteLine();
}

Console.WriteLine(new string('-', 10));
for (int i = 0; i < n; i++)
{
    for (int j = 0; j < n; j++)
    {
        Console.Write(result[i, j] + " ");
    }
    Console.WriteLine();
}