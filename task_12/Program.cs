using System;



string[] h = new string[21];
for (int i = 0; i < h.Length; i++)
{
    h[i] = $"b{i + 1}";
}

string[,] b = new string[6, 6];
for (int i = 0; i < b.GetLength(0); i++)
{
    for (int j = 0; j < b.GetLength(1); j++)
    {
        b[i, j] = "0";
    }
}

int lastelement = 0;

for (int i = 0; i < b.GetLength(1); i++)
{
    int aр = i + 1;

    for (int j = 0; j < aр; j++)
    {
        b[i, j] = h[lastelement + j];
    }
    lastelement += aр;
}



Console.WriteLine("Массив B:");
masiv(b);

Console.WriteLine("Инвертированный массив B:");
masivinvert(b);





void masiv(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(" {0, 3} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

void masivinvert(string[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = array.GetLength(1) - 1; j >= 0; j--)
        {
            Console.Write(" {0,3} ", array[i, j]);
        }
        Console.WriteLine();
    }
}

