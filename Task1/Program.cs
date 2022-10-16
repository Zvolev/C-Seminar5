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

int SumArrayElements(int[] array, int sign = 1) // считаем сумму положительных/отрицательных (sign = -1) элементов массива
{
    int sum = 0;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] * sign > 0)
        {
            sum += array[i];
        }   
    }
    return sum;

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
int sumPlus = SumArrayElements(array); // сумма положительных элементов массива
int sumMinus = SumArrayElements(array, -1); // сумма отрицательных элементов массива
PrintArray(array); // выводим массив на печать
System.Console.WriteLine();
System.Console.WriteLine($"Сума положительных элементов: {sumPlus}\nСумма отрицательных элементов: {sumMinus}");
