//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

//[3, 7, 23, 12] -> 19

//[-4, -6, 89, 6] -> 0

int[] GetArray(int size)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(0,10);
    }
    return res;
}
void PrintArray(int [] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    int sum = 0;
    for(int i = 1; i<arr.Length; i = i + 2)
    {
        sum = sum + arr[i];
    }
    Console.WriteLine();
Console.WriteLine($"Сумма чисел: {sum} ");
}
int[] array = GetArray(15);
PrintArray(array);