// Написать программу для подсчета количества цифр в числе.

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

int GetNumber(int num)
{
    int count = 0;
    while (num > 0)
    {
        num /= 10;
        count++;
    }
    return count;
}

int value = InputInt("Enter number");
Console.WriteLine($" Quanity digits in number {value} = {GetNumber(value)}");