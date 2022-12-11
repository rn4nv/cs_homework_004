Console.Clear();

int Squaring (int A, int B)
{
    int n = 1;
    int result = 1;
    if (B > 0)
    {
        while (n <= B)
        {
            result = result * A;
            n++;
        }
        Console.Write("Результат возведения числа 'A', в степень равную числу 'B' равняется: ");
        Console.Write(result);
    }
    else
    {
        Console.WriteLine("Введенное число 'B' не является натуральным. Запустите программу заново, введя новые значения.");
    }
    return result;
}

Console.Write("Введите число 'A':");
int a = int.Parse(Console.ReadLine());
Console.Write("Введите натуральное число 'B':");
int b = int.Parse(Console.ReadLine());

Squaring(a, b);

// Вариант решения без использования функций.

// Console.Write("Введите число 'A':");
// int a = int.Parse(Console.ReadLine());
// Console.Write("Введите натуральное число 'B':");
// int b = int.Parse(Console.ReadLine());
// int i = 1;
// int result = 1;

// if (b > 0)
// {
//     while (i <= b)
//     {
//         result = result * a;
//         i++;
//     }
//     Console.Write("Результат возведения числа 'A', в степень равную числу 'B' равняется: ");
//     Console.Write(result);
// }
// else
// {
//     Console.WriteLine("Введенное число 'B' не является натуральным. Запустите программу заново, введя новые значения.");
// }
