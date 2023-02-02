// Задача 64: Выполнить с помощью рекурсии.Задайте значение N. Напишите программу, которая выведет 
// все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.Write("Введи число: ");
int N = int.Parse(Console.ReadLine()!);

Console.WriteLine(PrintNumbers(N, 1));

// ------------------Метод------------------
string PrintNumbers(int start, int end)
{
    if (start == end) return start.ToString();
    return (start + " " + PrintNumbers(start - 1, end));
}

// Задача 66: Выполнить с помощью рекурсии.Задайте значения M и N. Напишите программу, которая 
// найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введи число: ");
int K = int.Parse(Console.ReadLine()!);
Console.Write("Введи число: ");
int M = int.Parse(Console.ReadLine()!) + 1;


Console.WriteLine(SumNaturaiNumbers(K, M));

// ------------------Метод------------------
int SumNaturaiNumbers(int start, int end)
{
    if (start == end) return 0;
    return (start + SumNaturaiNumbers(start + 1, end));
}

// Задача 68: Выполнить с помощью рекурсии.Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введи число: ");
int X = int.Parse(Console.ReadLine()!);
Console.Write("Введи число: ");
int Z = int.Parse(Console.ReadLine()!);
Console.Write(AkkermanFunc(X, Z));


int AkkermanFunc(int m, int n)
{
    {
        if (m == 0)

            return n + 1;

        if (m > 0 && n == 0)

            return AkkermanFunc(m - 1, 1);

        return AkkermanFunc(m - 1, AkkermanFunc(m, n - 1));
    }

}