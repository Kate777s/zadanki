using System;
using System.IO;


string inputPath = "C:\\Users\\gera2\\source\\repos\\task_14\\task_14\\INPUT.txt"; //у меня только с абсолютным и полностью указанным путем к файлу работает :(
string outputPath = "C:\\Users\\gera2\\source\\repos\\task_14\\task_14\\OUTPUT.txt";
int.TryParse(File.ReadAllText(inputPath).Trim(), out int N);
int[,] magkv = BuildOddMagicSquare(N);
using (StreamWriter writer = new StreamWriter(outputPath))


if (N % 2 == 1)
{
    for (int i = 0; i < N; i++)
    {
        for (int j = 0; j < N; j++)
        {
        writer.Write(magkv[i, j]);
        if (j < N - 1)
        writer.Write(" ");
        }
    writer.WriteLine();
    }
}

else if (N == 2)
{
    File.WriteAllText(outputPath, "Impossible");
}
else
{
    File.WriteAllText(outputPath, "Impossible");
}

Console.WriteLine("исходное число:" + N);
Console.WriteLine("результат:");
Console.Write(File.ReadAllText(outputPath).Trim());
       

static int[,] BuildOddMagicSquare(int N)
{
    int[,] magkv = new int[N, N];
    int num = 1;
    int row = 0;
    int col = N / 2;

    while (num <= N * N)
    {
        magkv[row, col] = num++;
        int nextRow = (row - 1 + N) % N;
        int nextCol = (col + 1) % N;

        if (magkv[nextRow, nextCol] != 0)
        {
            row = (row + 1) % N;
        }
        else
        {
            row = nextRow;
            col = nextCol;
        }
    }

    return magkv;
}