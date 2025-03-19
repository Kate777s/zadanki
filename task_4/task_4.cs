using System;

Console.WriteLine("Угадайте число от 1 до 100");
int popitka = 0;
nachalo:
Console.WriteLine("Введите число:");
int otvet = Convert.ToInt32(Console.ReadLine());
Random rand = new Random();
int chislo = rand.Next(1, 101);


if (otvet > 100 || otvet < 1)
{
    Console.WriteLine("Неверно введено число");
    goto nachalo;
}

popitka++;
if (otvet != chislo & popitka < 5)
{
    Console.WriteLine("Неверно");
    goto nachalo;
}
else if (otvet == chislo & popitka < 5)
{
    Console.WriteLine("Поздравляю, вы угадали!");
}
else if (otvet != chislo & popitka > 4)
{
    Console.WriteLine("Попытки закончились, вы не угадали. Попробуйте еще раз");
    Console.WriteLine("Ответ: " + chislo);
}