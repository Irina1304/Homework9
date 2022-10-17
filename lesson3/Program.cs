/*
Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
m = 2, n = 3 -> A(m,n) = 9
m = 3, n = 2 -> A(m,n) = 29
*/

int EnterInt(string prompt)
{
    Console.Write(prompt);
    return int.Parse(Console.ReadLine()!);
}

int AckermannFunc(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (n == 0)
        return AckermannFunc(m - 1, 1);
    return AckermannFunc(m - 1, AckermannFunc(m, n - 1));
}

int numberM = EnterInt("Введите число m: ");
int numberN = EnterInt("Введите число n: ");

Console.WriteLine($"A ({numberM}, {numberN}) = {AckermannFunc(numberM, numberN)}");
