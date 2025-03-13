using System;
using System.Reflection.PortableExecutable;
using static System.Runtime.InteropServices.JavaScript.JSType;

dom:
int x;
Console.WriteLine("Введите число x:");
if (!int.TryParse(Console.ReadLine(), out x))
{
    Console.WriteLine("буковки нельзя и слишком длинное число тоже нельзя");
    goto dom;
}
int g = Math.Abs(x);
string i = "";
string e = g.ToString();
int[] cc = new int[e.Length];
sos:
Console.WriteLine($"Введите основание системы счисления для числа {g} (от 2 до 10):");
int y;
if (!int.TryParse(Console.ReadLine(), out y))
{
    Console.WriteLine("буковки нельзя и слишком длинное число тоже нельзя");
    goto sos;
}

if (y <= 1 || y >= 11)
{
    Console.WriteLine("._.");
    Console.WriteLine("Неверно введена система счисления");
    goto sos;
}

for (int s = e.Length - 1; s >= 0; s--)

{
    int dd = e[s] - '0';
    if (dd >= y)
    {
        Console.WriteLine("Неверно введены данные");
        Console.WriteLine($"числа из цифры {g} не должны быть больше или равны {y} основанию системы счисления");
        Console.WriteLine("Если хотите ввести число заново нажмите 0, если хотите продолжить нажмите любую клавишу, кроме 0");
        int q = Convert.ToInt32(Console.ReadLine());
        if (q == 0)
        {
            goto dom;
        }
        else
        {
            Console.WriteLine("повторите ввод");
            goto sos;
        }
    }
}


nain:
Console.WriteLine("Введите основание системы счисления q1 (от 2 до 9):");
int q1;
if (!int.TryParse(Console.ReadLine(), out q1))
{
    Console.WriteLine("буковки нельзя и слишком длинное число тоже нельзя");
    goto nain;
}



if (q1 < 2 || q1 > 10)
{
    Console.WriteLine("._.");
    Console.WriteLine("Неверно введены данные");
    goto nain;
}


string numStr = g.ToString();
int Result = 0;
int length = numStr.Length;

for (int j = 0; j < length; j++)
{
    int digit = int.Parse(numStr[length - j- 1].ToString());
    Result += digit * (int)Math.Pow(y, j);
}

g = Result;

while (g > 0)
{
    int remainder = g % q1;
    i = remainder + i;
    g /= q1;
}

if (x < 0)
{
    i = "-" + i;
}
Console.WriteLine("Результат: ");
Console.WriteLine(i);
