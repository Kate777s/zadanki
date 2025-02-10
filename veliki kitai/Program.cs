using System;
Console.WriteLine("Введите имя");
Console.ForegroundColor = ConsoleColor.Cyan;
string name = Console.ReadLine();
Console.ResetColor();
Console.WriteLine("Введите Фамилию");
Console.ForegroundColor = ConsoleColor.Cyan;
string lastname = Console.ReadLine();
Console.ResetColor();
Console.WriteLine("Введите год рождения");
Console.ForegroundColor = ConsoleColor.Cyan;
int yearbirth = Convert.ToInt32(Console.ReadLine());
Console.ResetColor();
Console.WriteLine("Ваше имя: " + name);
Console.WriteLine("Ваша фамилия: " + lastname);

if (yearbirth >= 2026)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Вы не человек из будущего >:("); //все считается от и до 2025 года
    Console.ResetColor();
    return;
}
Console.ResetColor();
if (yearbirth <= 1952 & yearbirth >= 1904) //2025-73. Человек в среднем живет 73 года
{
    Console.ForegroundColor = ConsoleColor.DarkGreen;
    Console.WriteLine("А вы живучий");
    Console.ResetColor();
}

if (yearbirth <= 1903) //дольше всех жила француженка Жанна Кальман, 122 года, поэтому такое ограничение :)
{
    Console.ForegroundColor = ConsoleColor.DarkRed;
    Console.WriteLine("Люди столько не живут (Вы вампир?)");
    Console.ResetColor();
    return;
}


int a = yearbirth % 10;
int b = (yearbirth % 12) % 10;
string r = "";

if (b == 0)
{
    r = "обезьяна";
}
else if (b == 1)
{
    r = "петух";
}
else if (b == 2)
{
    r = "собака";
}
else if (b == 3)
{
    r = "свинья";
}
else if (b == 4)
{
    r = "крыса";
}
else if (b == 5)
{
    r = "бык";
}
else if (b == 6)
{
    r = "тигр";
}
else if (b == 7)
{
    r = "кролик";
}
else if (b == 8)
{
    r = "дракон";
}
else if (b == 9)
{
    r = "змея";
}
else if (b == 10)
{
    r = "лошадь";
}
else if (b == 11)
{
    r = "овца";
}

if (a == 0 || a == 1)
{
    Console.WriteLine("Белый(ая) " + r);
}
else if (a == 2 || a == 3)
{
    Console.ForegroundColor = ConsoleColor.Blue;
    Console.WriteLine("Синий(яя) " + r);
    Console.ResetColor();
}
else if (a == 4 || a == 5)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine("Зеленый(ая) " + r);
    Console.ResetColor();
}
else if (a == 6 || a == 7)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine("Красный(ая) " + r);
    Console.ResetColor();
}
else if (a == 8 || a == 9)
{
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Желтый(ая) " + r);
    Console.ResetColor();
}