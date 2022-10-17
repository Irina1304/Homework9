/*
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

M = 1; N = 15 -> 120
M = 4; N = 8 -> 30
*/


int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int SumAllNumbs(int m, int n)
{
 int sum = 0;
    if (m == n)
    {
        return m;
    }
    sum += n;
    return SumAllNumbs(m, n - 1) + sum;
}

int numberM = EnterInt("Введите число M: ");
int numberN = EnterInt("Введите число N: ");

Console.WriteLine($"Cуммa натуральных элементов в промежутке от M до N: {SumAllNumbs(numberM, numberN)}");