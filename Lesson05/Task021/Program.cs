// Задайте одномерный массив из 10 случайных чисел в диапазоне от 1 до 200. Найдите количество  двузначных элементов массива. 
// Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10

// [5, 18, 123, 6, 2] -> 1
// [1, 2, 3, 6, 2] -> 0
// [10, 11, 12, 13, 14] -> 5


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

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int SearchTwoDigits(int[] array)
{
    int countDigits = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if(array[i] > 9 && array[i] < 100)
        {
            countDigits++;
        }
    }
    return countDigits;
}

int size = 10;
int minValue = 1;
int maxValue = 200;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine($"Number two-digits elements = {SearchTwoDigits(array)}");