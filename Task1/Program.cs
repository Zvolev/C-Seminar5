using System;
/*Задайте массив из 12 элементов, заполненный
случайными числами из промежутка [-9, 9]. Найдите сумму
отрицательных и положительных элементов массива.
Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма
положительных чисел равна 29, сумма отрицательных равна
-20.*/

int InputArraySize(string message) // запрос, ввод  и проверка размера массива 
{
    Console.Write(message);
    int length = Convert.ToInt32(Console.ReadLine());
    if (length <= 0)
        Console.Write("Недопустимый размер массива");
    else
        Console.WriteLine();
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

int SumArrayElements(int[] array, char sign = '0')
{
    int sum = 0;
    if (sign == '+')
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] > 0)
            {
                sum = sum + array[i];
            }

        }
    }

    if (sign == '-')
    {
        for (int i = 0; i < array.Length; i++)
        {
            if (array[i] < 0)
            {
                sum = sum + array[i];
            }

        }
    }

    if (sign == '0')
    {
        for (int i = 0; i < array.Length; i++)
        {
            sum = sum + array[i];
        }
    }
    return sum;
}

void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


int len = InputArraySize("Укажите размер массива >- ");
int min = Prompt("Укажите диапазон значений массива: от >- ");
int max = Prompt("до (включительно) >- ");
int[] array = CreateRandomArray(len, min, max - 1);
int sumPlus = SumArrayElements(array, '+');
int sumMinus = SumArrayElements(array, '-');
int sum = SumArrayElements(array);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Сума положительных элементов: {sumPlus}\nСумма отрицательных элементов: {sumMinus}\nСумма всех элементов: {sum}");
