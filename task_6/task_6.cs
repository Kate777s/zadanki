using System;


Console.WriteLine("Введите число x:");
int x = Convert.ToInt32(Console.ReadLine());
string i = "";
nain:
Console.WriteLine("Введите основание системы счисления q1 (от 2 до 9):");
int q1 = Convert.ToInt32(Console.ReadLine());



if (q1 < 2 || q1 > 9)
{
    Console.WriteLine("._.  ну.. написано же от 2 до 9");
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