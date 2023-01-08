//Напишите программу замена элементов 
//массива: положительные элементы замените на 
//соответствующие отрицательные, и наоборот.
//[-4, -8, 8, 2] -> [4, 8, -8, -2] 

Console.WriteLine($"Введите размер массива: ");
int size = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите начало массива: ");
int minvalue = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Введите конец массива: ");
int maxvalue = int.Parse(Console.ReadLine()!);
int[] GetArray(int size, int minvalue, int maxvalue)
{
    int[] res = new int[size];
    for(int i = 0; i<size; i++)
    {
        res[i] = new Random().Next(minvalue,maxvalue);
    }
    return res;
}
void PrintArray(int [] arr)
{
Console.WriteLine($"Исходный массив: ");
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
Console.WriteLine(); 
Console.WriteLine($"Измененный массив: ");   
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]*(-1)} ");
    }   
}
int [] array = GetArray(size, minvalue, maxvalue);
PrintArray(array);

