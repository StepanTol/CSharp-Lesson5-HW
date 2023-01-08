//Задайте массив. Напишите программу, которая 
//определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет
//-3; массив [6, 7, 19, 345, 3] -> да

Console.WriteLine($"Введите число: ");
int a = int.Parse(Console.ReadLine()!);
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
    for(int i = 0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
int count = 0;         
    for(int i = 0; i<arr.Length; i++)
    {
        if (a == arr[i])
        {
            count ++;
        }
    } 
    if (count > 0)
        {
            Console.WriteLine($"Ответ да");
        }
        else
        {
            Console.WriteLine($"Ответ нет");
        }
}
int [] array = GetArray(10, -1, 5);
PrintArray(array);