// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
// Заменить отрицательные элементы массива, положительными и наоборот.

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

int[] InvertArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
    }
    return array;
}

// Функция возвращает сумму положительных элементов.

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();
}

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
InvertArray(array);
ShowArray(array);