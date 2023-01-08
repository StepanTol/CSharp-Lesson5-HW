//Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.

//[3 7 22 2 78] -> 76

double[] GetArray(int size)
{
    double[] res = new double[size];
    Random rand = new Random();
    for(int i = 0; i<size; i++)
    {
        res[i] = rand.Next(1,10) + rand.NextDouble();
        res[i] = Math.Round(res[i],2);
    }
    return res;
}
void PrintArray(double [] arr)
{
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    double max = arr[0];
    double min = arr[0];
        for(int i = 0; i<arr.Length; i++)
        {
            if(arr[i]>max)
            {
                max = arr[i];
            }
            if(arr[i]<min)
            {
                min = arr[i];
            }
        }
Console.WriteLine();
Console.WriteLine($"Максимальный элемент массива: {max} , минимальный элемент массива: {min} ");
Console.WriteLine($"Разница между max и min: {max - min} ");
}
double[] array = GetArray(10);
PrintArray(array);