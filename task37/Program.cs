// Найдите произведение пар чисел в одномерном массиве. 
//Парой считаем первый и последний элемент, второй и предпоследний 
//и т.д. Результат запишите в новом массиве.
//[1 2 3 4 5] -> 5 8 3
//[6 7 3 6] -> 36 21

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
}
int[] array = GetArray(5,-7,7);
PrintArray(array);
Console.WriteLine();

if(array.Length % 2 == 0)
{
    int [] comp = new int [array.Length/2];
        for(int i = 0; i<array.Length/2; i++)
        {
            comp[i] = array[i]*array[array.Length-1-i];
            Console.Write($"{comp[i]} "); 
        }
}

else
{
    int [] comp = new int [(array.Length/2) + 1];
        for(int i = 0; i<(array.Length/2) + 1; i++)
        {
            if (i == (array.Length / 2) + 1)  
            {
                comp[i] = array[i];
            }
            else
            {
                comp[i] = array[i]*array[array.Length-1-i];
            }     
            Console.Write($"{comp[i]} "); 
        }  
}    
