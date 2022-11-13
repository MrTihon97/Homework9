//  Задайте значения M и N. Напишите программу,
//  которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

Console.Write("Введите целое число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите целое число n: ");
int n = Convert.ToInt32(Console.ReadLine());

int SumNumbers(int m, int n)
{
    if (m == 0) return (n * (n + 1)) / 2;            // Если M равно нулю
    else if (n == 0) return (m * (m + 1)) / 2;       // Если N равно нулю
    else if (m == n) return m;                       // Если M=N
    else if (m < n) return n + SumNumbers(m, n - 1); // Если M<N
    else return n + SumNumbers(m, n + 1);            // Если M>N
}

int sum = SumNumbers(m, n);
Console.WriteLine($"{sum}");