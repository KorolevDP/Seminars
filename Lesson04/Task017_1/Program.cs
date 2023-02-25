//  Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.

// [1,0,1,1,0,1,0,0]

void FillArray (int[] array)
{
    Random  rnd = new Random();
    for (int i = 0; i < array.Length/2; i++)
    {
        array[rnd.Next(0, array.Length)] = 1;
    }
}

void PrintArray (int[] array)
{
   Console.Write(array[0]);               //чтобы после последнего элемента массива не ставилась запятая.

   for (int i = 1; i < array.Length; i++)
   {
    Console.Write($", {array[i]}");
   }
}

int[] Array = new int[8];
FillArray(Array);
PrintArray(Array);
