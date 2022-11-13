



// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

Console.WriteLine("Введите целое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());

void NaturalNumbers(int num1)
{
    if (num1 == 0) return;
    {
        Console.Write($"{num1} ");
        NaturalNumbers(num1 - 1);
    }
}
NaturalNumbers(num1);