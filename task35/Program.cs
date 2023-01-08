/*Задайте одномерный массив из 123 случайных чисел. 
Найдите количество элементов массива, значения которых лежат в 
отрезке [10,99]. 
Пример для массива из 5, а не 123 элементов. В своём решении сделайте для 
123
[5, 18, 123, 6, 2] -> 1
[1, 2, 3, 6, 2] -> 0
[10, 11, 12, 13, 14] -> 5*/

int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minvalue,maxvalue+1);
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
            if (arr[i]>9 & arr[i]<100)
            {
            count++;
            }      
        }
Console.WriteLine();
Console.Write($"Количество нужных чисел: {count}");
}
int[] array = GetArray(123,-9,120);
PrintArray(array);
