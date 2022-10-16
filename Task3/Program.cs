/*Задайте массив. Напишите программу, которая 
определяет, присутствует ли заданное число в массиве.
4; массив [6, 7, 19, 345, 3] -> нет
3; массив [6, 7, 19, 345, 3] -> да*/

int[] array = { 1, 6, -5, 5, -2, 9, -8, 5 };
int num = -5;

string ChekNamArray(int[] arr, int num)
{
    string mass = "Нет, число отсутствует в массиве";
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] == num)
        {
            return mass = "Да, число присутствует в массиве";
        } 
    }
    return mass;
}

System.Console.WriteLine(ChekNamArray(array, num));