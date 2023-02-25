// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.

// 4; массив [6, 7, 19, 345, 3] -> нет
// 3; массив [6, 7, 19, 345, 3] -> да

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
}

bool isNumberArray(int number, int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        if(number == array[i]) return true;
    }
    return false;
}

int size = 12;
int minValue = -9;
int maxValue = 9;
int[] array = GenerateArray(size, minValue, maxValue);
ShowArray(array);
Console.WriteLine("Enter number for search");
int number = Convert.ToInt32(Console.ReadLine());
if(isNumberArray(number, array)) Console.WriteLine("Number here");
else Console.WriteLine("No number");
