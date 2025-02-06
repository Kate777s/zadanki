using System;

Console.WriteLine("Введите имя");
string name = Console.ReadLine();
Console.WriteLine("Введите Фамилию");
string lastname = Console.ReadLine();
Console.WriteLine("Введите день");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите номер месяца(1,2 и тд)");
int month = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ваше имя " + name);
Console.WriteLine("Ваша фамилия " + lastname);

if (day <= 0 || day >= 32)
{
    Console.WriteLine("Неверно введен день");
}

else if (month <= 0 || month >= 13)
{
    Console.WriteLine("Неверно введен номер месяца");
}
else
{
    switch (month)
    {
        case 1 when day <= 19:
            Console.WriteLine("Ваш знак зодиака козерог");
            break;
        case 1 when day >= 20:
            Console.WriteLine("Ваш знак зодиака водолей");
            break;
        case 2 when day <= 18:
            Console.WriteLine("Ваш знак зодиака водолей");
            break;
        case 2 when day >= 30:
            Console.WriteLine("В феврале максимум 29 дней и то раз в 4 года, поэтому неверно введён день этого месяца");
            break;
        case 2 when day == 29:
            Console.WriteLine("Ваш знак зодиака рыбы. У вас редкая дата рождения! :3");
            break;
        case 2 when day >= 19:
            Console.WriteLine("Ваш знак зодиака рыбы");
            break;
        case 3 when day <= 20:
            Console.WriteLine("Ваш знак зодиака рыбы");
            break;
        case 3 when day >= 21:
            Console.WriteLine("Ваш знак зодиака овен");
            break;
        case 4 when day <= 19:
            Console.WriteLine("Ваш знак зодиака овен");
            break;
        case 4 when day >= 20:
            Console.WriteLine("Ваш знак зодиака телец");
            break;
        case 5 when day <= 20:
            Console.WriteLine("Ваш знак зодиака телец");
            break;
        case 5 when day >= 21:
            Console.WriteLine("Ваш знак зодиака близнецы");
            break;
        case 6 when day <= 20:
            Console.WriteLine("Ваш знак зодиака близнецы");
            break;
        case 6 when day >= 21:
            Console.WriteLine("Ваш знак зодиака рак");
            break;
        case 7 when day <= 22:
            Console.WriteLine("Ваш знак зодиака рак");
            break;
        case 7 when day >= 23:
            Console.WriteLine("Ваш знак зодиака лев");
            break;
        case 8 when day <= 22:
            Console.WriteLine("Ваш знак зодиака лев");
            break;
        case 8 when day >= 23:
            Console.WriteLine("Ваш знак зодиака дева");
            break;
        case 9 when day <= 22:
            Console.WriteLine("Ваш знак зодиака дева");
            break;
        case 9 when day >= 23:
            Console.WriteLine("Ваш знак зодиака весы");
            break;
        case 10 when day <= 22:
            Console.WriteLine("Ваш знак зодиака весы");
            break;
        case 10 when day >= 23:
            Console.WriteLine("Ваш знак зодиака скорпион");
            break;
        case 11 when day <= 21:
            Console.WriteLine("Ваш знак зодиака скорпион");
            break;
        case 11 when day >= 22:
            Console.WriteLine("Ваш знак зодиака стрелец");
            break;
        case 12 when day <= 21:
            Console.WriteLine("Ваш знак зодиака стрелец");
            break;
        case 12 when day >= 22:
            Console.WriteLine("Ваш знак зодиака козерог");
            break;
        default:
            Console.WriteLine("неверно введена дата");
            break;
    }
}
