using System;



const int students = 25;
const int predmety = 5;
string[] name_predmety = { "Математика", "Русский язык", "География", "Химия", "Физкультура" };
int[,] grades = new int[students, predmety];

Random random = new Random();

for (int i = 0; i < students; i++)
 {
    for (int j = 0; j < predmety; j++)
    {
grades[i, j] = random.Next(2, 6);
    } 
}
Console.WriteLine("|--------------------------------------------------------------------------------------|");
Console.WriteLine("Предметы: Математика, Русский язык, География, Химия, Физкультура");
Console.WriteLine("|--------------------------------------------------------------------------------------|");
Console.WriteLine("Таблица оценок студентов:");
for (int i = 0; i < students; i++)
{
    Console.Write($"Студент {i + 1}: ");
    for (int j = 0; j < predmety; j++)
    {
Console.Write(grades[i, j] + " ");
    }
    Console.WriteLine();
}
Console.WriteLine();

Console.WriteLine("|--------------------------------------------------------------------------------------|");

double[] avgpredmety = new double[predmety];
for (int j = 0; j < predmety; j++)
{
    double sum = 0;
    for (int i = 0; i < students; i++)
    {
sum += grades[i, j];
    }
    avgpredmety[j] = sum / students;
    Console.WriteLine($"Средний балл по предмету {name_predmety[j]}: {avgpredmety[j]:F2}");
}
Console.WriteLine();
Console.WriteLine("|--------------------------------------------------------------------------------------|");

double[] avgstudents = new double[students];
for (int i = 0; i < students; i++)
{
    double sum = 0;
    for (int j = 0; j < predmety; j++)
    {
        sum += grades[i, j];
    }
    avgstudents[i] = sum / predmety;
    Console.WriteLine($"Средний балл студента {i + 1}: {avgstudents[i]:F2}");
}
Console.WriteLine();

double maxavgpredmety = avgpredmety[0];
double minavgpredmety = avgpredmety[0];
int maxSubjectIndex = 0;
int minSubjectIndex = 0;

for (int j = 1; j < predmety; j++)
{
    if (avgpredmety[j] > maxavgpredmety)
    {
        maxavgpredmety = avgpredmety[j];
        maxSubjectIndex = j;
    }
    if (avgpredmety[j] < minavgpredmety)
    {
        minavgpredmety = avgpredmety[j];
        minSubjectIndex = j;
    }
}

Console.WriteLine("|--------------------------------------------------------------------------------------|");
Console.WriteLine($"Максимальный средний балл по предметам: {maxavgpredmety} (Предмет {name_predmety[maxSubjectIndex]})");
Console.WriteLine("|--------------------------------------------------------------------------------------|");
Console.WriteLine($"Минимальный средний балл по предметам: {minavgpredmety} (Предмет {name_predmety[minSubjectIndex]})");
Console.WriteLine();

double maxStudentAvg = avgstudents[0];
double minStudentAvg = avgstudents[0];
int maxStudentIndex = 0;
int minStudentIndex = 0;

for (int i = 1; i < students; i++)
{
    if (avgstudents[i] > maxStudentAvg)
    {
        maxStudentAvg = avgstudents[i];
        maxStudentIndex = i;
    }
    if (avgstudents[i] < minStudentAvg)
    {
        minStudentAvg = avgstudents[i];
        minStudentIndex = i;
    }
}
Console.WriteLine("|--------------------------------------------------------------------------------------|");
Console.WriteLine($"Максимальный средний балл среди студентов: {maxStudentAvg} (Студент {maxStudentIndex + 1})");
Console.WriteLine("|--------------------------------------------------------------------------------------|");
Console.WriteLine($"Минимальный средний балл среди студентов: {minStudentAvg} (Студент {minStudentIndex + 1})");
