// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

// [3.7; 7.2; 2.1; 7.8] -> 5.7

double[] FillArray(double[] array)
{
    Random rand = new Random();
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 1);

    }
    return array;
}

Console.WriteLine("Enter array's length");
int length = Convert.ToInt32(Console.ReadLine());
double[] Arr = new double[length];
FillArray(Arr);
Console.WriteLine("Your array is");
Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine("Now I'll find differential between max and min elements of array");

double max = Arr[0];
double min = Arr[0];
double differential = 0;
for (int i = 0; i < Arr.Length; i++)
{
    if (min > Arr[i])
    {
        min = Arr[i];
    }
}
Console.WriteLine($"min = {min}");
for (int i = 0; i < Arr.Length; i++)
{
    if (max < Arr[i])
    {
        max = Arr[i];
    }
}
Console.WriteLine($"max = {max}");
differential = Math.Round(max - min, 1);
Console.WriteLine($"differential = {differential}");