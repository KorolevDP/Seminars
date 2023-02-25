// Найдите произведение пар чисел в одномерном массиве. 
// Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.

// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21


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

int[] PairsArray (int[] array)
{
    int[] result = new int[array.Length/2 + array.Length % 2];
    result[result.Length - 1] = array[result.Length - 1];
    for (int i = 0; i < array.Length/2; i++)
    {
      int lastIndex = array.Length -1 - i;
      result[i] = array[i] * array[lastIndex]; 
    }
    return result;
}

int size = 5;
int minValue = 1;
int maxValue = 10;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
ShowArray(PairsArray(array));