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

double[] CreateRandomArray(int argLength = 2, int argMin =0, int argMax = 1) // создаем массив и наполняем его случайными значениями по заданным параметрам и выводим на экран
{
    double[] array = new double[argLength];

    Random rand = new Random();
    int r = 0;
    for (int i = 0; i < argLength; i++)
    {
        r = rand.Next(argMin, argMax);
        array[i] = rand.NextDouble() + Convert.ToDouble(r);
        //System.Console.WriteLine(array[i]);
    }
    return array;
}

double DifferenceMinMaxArray(double[] array) //разницу между максимальным и минимальным элементов массива
{
    
    double min = array[0];
    double max = array[0];
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

void PrintArray(double[] array) // выводим массив на печать
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]}, ");
    }
}


int len = InputArraySize("Укажите размер массива >- ");
int min = Prompt("Укажите диапазон значений массива: от >- ");
int max = Prompt("до (включительно) >- ");
double[] array = CreateRandomArray(len, min, max - 1); // создаем массив по заданным параметрам
PrintArray(array); // выводим массив на печать
System.Console.WriteLine();
System.Console.WriteLine($"Разницфа между максимальным и минимальным элементами массива равна {DifferenceMinMaxArray(array)}");
