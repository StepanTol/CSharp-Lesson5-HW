//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(100,1000);
    }
    return res;
}
void PrintArray(int [] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    int count = 0;
    for(int i = 0; i<arr.Length; i++)
    {
        if (arr[i] % 2 == 0)
        {
            count++;
        }
    }
    Console.WriteLine();
Console.WriteLine($"Чиcло четных чисел: {count} ");
}
int[] array = GetArray(10);
PrintArray(array);
