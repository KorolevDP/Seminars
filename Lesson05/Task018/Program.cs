// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Найдите сумму отрицательных и положительных элементов массива.

// Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

// Функция генерирует массив с заданными параметрами

int[] GenerateArray(int length, int minValue, int maxValue)
{
    int[] result = new int[length];
    Random rnd = new Random();

    for(int i = 0; i < result.Length; i++)
    {
        result[i] = rnd.Next(minValue, maxValue+1);
    }
    return result;  
}

// Функция возвращает сумму положительных и отрицательных элементов.
int[] SumSign(int[] array, bool isPositive = true)
{
    int sign = 1;
    if(!isPositive)
    {
        sign = -1;
    }

    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        bool condition = array * sign > 0;
        if(condition)
        {
            sum += array[i];
        }
    }
    return sum;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);

Console.WriteLine($"Summ of positive or negative array elements =  {SumSign(array)}");
