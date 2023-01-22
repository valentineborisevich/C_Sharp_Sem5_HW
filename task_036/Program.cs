// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(-99, 99);
    }
    return array;
}

Console.WriteLine("Enter array's length");
int length = Convert.ToInt32(Console.ReadLine());
int[] Arr = new int[length];
FillArray(Arr);
Console.WriteLine("Your array is");
Console.WriteLine(string.Join(", ", Arr));
Console.WriteLine("Now I'll find sum of elements of even indexes");
int sum = 0;
for (int i = 1; i < Arr.Length; i++)
{
    if (i % 2 == 0)
    {
        sum+=Arr[i];
    }
}
Console.WriteLine(sum);