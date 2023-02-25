
// Написать программу для подсчета произведения чисел от 1 до N (N - вводим с клавиатуры).

int InputInt(string promt)
{
    Console.Write($"{promt}> ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("Invalid number");
    Environment.Exit(1);
    return 0;
}

int GetFactorial(int num)
{
 int result = 1;
 for (int i = 1; i <= num; i++)
 {
    result *= i;
 }
 return result;
}

int value = InputInt("Enter number");
Console.WriteLine($"Factorial number {value} = {GetFactorial(value)}");