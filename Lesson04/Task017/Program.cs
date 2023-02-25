//  Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

int[] fillArray (int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(0,2);
    }
    return array;
}

void printArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Threading.Thread.Sleep(120);    // задержка вывода на экран элементов массива
        Console.Write($"{array[i]}, ");
    }
    Console.WriteLine();
}

int InputSizeArray(string msg)
{
    Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int sizeArray = InputSizeArray("Enter size array");
int [] array =  fillArray(sizeArray);
printArray(array);