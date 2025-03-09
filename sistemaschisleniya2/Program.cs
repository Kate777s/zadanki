using System;

dom:
Console.WriteLine("Введите число x:");
int x = Convert.ToInt32(Console.ReadLine());
string i = "";
string e = x.ToString();
int[] cc = new int[e.Length];
sos:
Console.WriteLine($"Введите основание системы счисления для числа {x} (от 2 до 10):");
int y = Convert.ToInt32(Console.ReadLine());

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
        Console.WriteLine($"числа из цифры {x} не должны быть больше или равны {y} основанию системы счисления");
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
Console.WriteLine("Введите основание системы счисления q1 (от 2 до 10):");
int q1 = Convert.ToInt32(Console.ReadLine());



if (q1 < 2 || q1 > 10)
{
    Console.WriteLine("._.");
    Console.WriteLine("Неверно введены данные");
    goto nain;
}

while (x > 0)
{
    int remainder = x % q1;
    i = remainder + i;
    x /= q1;
}

Console.WriteLine("Результат: ");
Console.WriteLine(i);
