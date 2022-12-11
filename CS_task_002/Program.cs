Console.Clear();

int SumNum(int A)
{
    int result = 0;
    int n = 0;

    if (A > 0)
    {
        if (A >= 1000 && A < 10000)
        {
            result = (A / 1000) + ((A % 1000) / 100) + (((A % 1000) % 100) / 10) + (((A % 1000) % 100) % 10);
            Console.Write("Сумма цифр в числе равна: ");
            Console.Write(result);
        }
        else
        {
            if (A >= 100 && A < 1000)
            {
                result = (A / 100) + ((A % 100) / 10) + ((A % 100) % 10);
                Console.Write("Сумма цифр в числе равна: ");
                Console.Write(result);
            }
            else
            {
                if (A >= 10 && A < 100)
                {
                    result = (A / 10) + (A % 10);
                    Console.Write("Сумма цифр в числе равна: ");
                    Console.Write(result);
                }
                else
                {
                    if (A > 0 && A < 10)
                    {
                        result = A;
                        Console.Write("Сумма цифр в числе равна: ");
                        Console.Write(result);
                    }
                    else
                    {
                        Console.WriteLine("Введенное число превышает четырехзначное число. Запустите программу заново, введя число превышающее предельно допустимое.");
                    }
                }
            }
        }
    }
    else
    {
       Console.WriteLine("Введенное число является отрицательным. Запустите программу заново и введите положительное число."); 
    }
    return result;
}

Console.Write("Введите число 'A': ");
int a = int.Parse(Console.ReadLine());

SumNum(a);

// Вариант решения без использования функций.

// Console.Write("Введите число 'A': ");
// int a = int.Parse(Console.ReadLine());
// int result = 0;
// int n = 0;

// if (a > 0)
// {
//      if (a >= 1000 && a < 10000)
//     {
//         result = (a / 1000) + ((a % 1000) / 100) + (((a % 1000) % 100) / 10) + (((a % 1000) % 100) % 10);
//         Console.Write("Сумма цифр в числе равна: ");
//         Console.Write(result);
//     }
//     else
//     {
//         if (a >= 100 && a < 1000)
//         {
//             result = (a / 100) + ((a % 100) / 10) + ((a % 100) % 10);
//             Console.Write("Сумма цифр в числе равна: ");
//             Console.Write(result);
//         }
//         else
//         {
//             if (a >= 10 && a < 100)
//             {
//                 result = (a / 10) + (a % 10);
//                 Console.Write("Сумма цифр в числе равна: ");
//                 Console.Write(result);
//             }
//             else
//             {
//                 if (a > 0 && a <10)
//                 {
//                     result = a;
//                     Console.Write("Сумма цифр в числе равна: ");
//                     Console.Write(result);
//                 }
//                 else
//                 {
//                     Console.WriteLine("Введенное число превышает четырехзначное число. Запустите программу заново, введя число превышающее предельно допустимое.");
//                 }
//             }
//         }
//     }
// }
// else
// {
//     Console.WriteLine("Введенное число является отрицательным. Запустите программу заново и введите положительное число.");
// }
