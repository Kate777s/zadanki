using System;
using System.IO;


int n = int.Parse(File.ReadAllText("C:\\Users\\gera2\\source\\repos\\task_15\\task_15\\INPUT.txt")); //та же ситуация, что и в 14 задании
int[,] matrix = new int[n, n];
int num = 1;

for (int d = 0; d < 2 * n - 1; d++)
{
    if (d < n)
    {
        if (d % 2 == 0)
        {
            int i = d;
            int j = 0;
            while (i >= 0 && j < n)
            {
                matrix[j, i] = num++;
                i--;
                j++;
            }
        }
        else
        {
            int i = 0;
            int j = d;
            while (j >= 0 && i < n)
            {
                matrix[j, i] = num++;
                i++;
                j--;
            }
        }
    }
    else
    {
        if (d % 2 == 0)
        {
            int i = n - 1;
            int j = d - n + 1;
            while (j < n && i >= 0)
            {
                matrix[j, i] = num++;
                i--;
                j++;
            }
        }
        else
        {
            int i = d - n + 1;
            int j = n - 1;
            while (i < n && j >= 0)
            {
                matrix[j, i] = num++;
                i++;
                j--;
            }
        }
    }
}

using (StreamWriter writer = new StreamWriter("C:\\Users\\gera2\\source\\repos\\task_15\\task_15\\OUTPUT.txt"))
{
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < n; j++)
        {
            writer.Write(matrix[i, j]);
            if (j < n - 1)
                writer.Write(" ");
        }
        writer.WriteLine();
    }
}