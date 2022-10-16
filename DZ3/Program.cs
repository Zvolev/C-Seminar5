/*Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

int InputArraySize(string message) // запрос, ввод  и проверка размера массива 
{
    Start:
    Console.Write(message);
    int length = Convert.ToInt32(Console.ReadLine());
    if (length <= 0)
    {
        Console.Write("Недопустимый размер массива ");
        goto Start;
    }
    return length;
}

int Prompt(string message) // запрос и ввод значений
{
    Console.Write(message);
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] CreateRandomArray(int argLength = 2, int argMin = 0, int argMax = 1) // создаем массив и наполняем его случайными значениями по заданным параметрам и выводим на экран
{
    int[] array = new int[argLength];

    Random rand = new Random();
    for (int i = 0; i < argLength; i++)
    {
        array[i] = rand.Next(argMin, argMax);
        //System.Console.WriteLine(array[i]);
    }
    return array;
}

int DifferenceMinMaxArray(int[] array) //разницу между максимальным и минимальным элементов массива
{
    
    int min = array[0];
    int max = array[0];
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > max)
        {
            max = array[i];
        }
        if (array[i] < min)
        {
            min = array[i];
        }
    }
    return (max - min);
}

void PrintArray(int[] array) // выводим массив на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


int len = InputArraySize("Укажите размер массива >- ");
int min = Prompt("Укажите диапазон значений массива: от >- ");
int max = Prompt("до (включительно) >- ");
int[] array = CreateRandomArray(len, min, max - 1); // создаем массив по заданным параметрам
PrintArray(array); // выводим массив на печать
System.Console.WriteLine();
System.Console.WriteLine($"Разницфа между максимальным и минимальным элементами массива равна {DifferenceMinMaxArray(array)}");
