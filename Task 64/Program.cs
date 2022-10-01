// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.


void ShowNumbers(int n)
{
    if (n > 0)
    {
        Console.Write("{0} ", n);
        ShowNumbers(n - 1);
    }
}

Console.WriteLine("Введите число: ");
int n = int.Parse(Console.ReadLine());

ShowNumbers(n);