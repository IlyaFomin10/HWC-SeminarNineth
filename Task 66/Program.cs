// Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

int GetsumNumbers (int m, int n)
{
    if (n == m)
    {
        return m;
    }
    int sum = n + GetsumNumbers(m, n-1);
    return sum;
}

Console.WriteLine("Введите число M: ");
int m = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число N: ");
int n = int.Parse(Console.ReadLine());
int sum = GetsumNumbers (m, n);
Console.WriteLine($"Сумма натуральных элементов в промежутке от M до N равна: {sum}");