// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100, 1000);
    }
    return array;
}

Console.WriteLine("Enter array's length");
int length = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[length];
FillArray(Arr);
Console.WriteLine("Your array is");
Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine("Now I'll find quantity of even numbers");

int count = 0;
for (int i = 0; i < Arr.Length; i++)
{
    if (Arr[i] % 2 == 0)
    {
        count++;
    }
}
Console.WriteLine(count);