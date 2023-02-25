// Напишите программу, которая выводит случайное число из отрезка [10, 9999] и показывает наибольшую цифру числа.
// 7812 -> 8 
// 1213-> 3 
// 845 -> 8

int num = new Random().Next(10, 10000);
System.Console.WriteLine(num);
int max = 0;

while (num > 0)
{
    if(max < num % 10)
    {
        max = num % 10;
    }
    num /= 10;
}

System.Console.WriteLine($"Masimum digit {max}");
