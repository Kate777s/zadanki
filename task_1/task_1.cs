using System;

Console.WriteLine("Введите имя");
string name = Console.ReadLine();
Console.WriteLine("Введите Фамилию");
string lastname = Console.ReadLine();
Console.WriteLine("Введите день");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца(1,2 и тд)");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше имя" + name);
Console.WriteLine("Ваша фаамилия" + lastname);


if ((month == 3 && (day >= 21 && day <= 31)) || (month == 4 && day <= 19))
{
    Console.WriteLine("Ваш знак задиака Овен");
}
else if ((month == 4 && (day >= 20 && day <= 30)) || (month == 5 && day <= 20))
{
    Console.WriteLine("Ваш знак задиака Телец");
}
else if ((month == 5 && (day >= 21 && day <= 31)) || (month == 6 && day <= 20))
{
    Console.WriteLine("Ваш знак задиака Близнецы");
}
else if ((month == 6 && (day >= 21 && day <= 30)) || (month == 7 && day <= 22))
{
    Console.WriteLine("Ваш знак задиака Рак");
}
else if ((month == 7 && (day >= 23 && day <= 31)) || (month == 8 && day <= 22))
{
    Console.WriteLine("Ваш знак задиака Лев");
}
else if ((month == 8 && (day >= 23 && day <= 31)) || (month == 9 && day <= 22))
{
    Console.WriteLine("Ваш знак задиака Дева");
}
else if ((month == 9 && (day >= 23 && day <= 30)) || (month == 10 && day <= 22))
{
    Console.WriteLine("Ваш знак задиака Весы");
}
else if ((month == 10 && (day >= 23 && day <= 31)) || (month == 11 && day <= 21))
{
    Console.WriteLine("Ваш знак задиака Скорпион");
}
else if ((month == 11 && (day >= 22 && day <= 30)) || (month == 12 && day <= 21))
{
    Console.WriteLine("Ваш знак задиака Стрелец");
}
else if ((month == 12 && (day >= 22 && day <= 31)) || (month == 1 && day <= 19))
{
    Console.WriteLine("Ваш знак задиака Козерог");
}
else if ((month == 1 && (day >= 20 && day <= 31)) || (month == 2 && day <= 18))
{
    Console.WriteLine("Ваш знак задиака Водолей");
}
else if ((month == 2 && (day >= 19 && day <= 28)) || (month == 3 && day <= 20))
{
    Console.WriteLine("Ваш знак задиака Рыбы");
}
else if (day <= 0)
{
    Console.WriteLine("Неверено введен день");
}
else
{
    Console.WriteLine("неверно введена дата");
};