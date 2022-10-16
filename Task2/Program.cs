/*Напишите программу замены элементов массива: 
положительные элементы замените на соответствующие 
отрицательные, и наоборот.
[-4, -8, 8, 2] -> [4, 8, -8, -2]*/

int[] array = { 1, 6, -5, 5, -2, 9, -8, 5 };

int[] ReversArray(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = arr[i] * -1;
    }
    return arr;
}

void PrintArray(int[] array) // выводим массив на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
    System.Console.WriteLine();
}

PrintArray(array);
PrintArray(ReversArray(array));