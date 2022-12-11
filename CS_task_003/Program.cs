Console.Clear();

void FillArray(int[] collection)

{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next (0, 14);
        index++;
    }
}
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

double NumSys (int[] collection, int degree)
{
    int count = collection.Length;
    int index = 0;
    double result = 0;
    int NumberSystem = 15;
   

    while (index < count)
    {
        result = result + collection[index] * Math.Pow(NumberSystem, degree -1 );
        index++;
        degree--;
    }
    return result;
}

Console.Write("Введите количество элементов в массиве 'N': ");
int N = int.Parse(Console.ReadLine());
int[] array = new int [N];

FillArray(array);
PrintArray(array);
Console.WriteLine();

double res = NumSys(array, N);
Console.Write("Десятичное представление числа, состоящего из введенного количества элементов массива равно: ");
Console.Write(res);