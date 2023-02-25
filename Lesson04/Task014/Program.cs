// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

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

bool ValidatePositive(int value)  // Check  positive number
{
    if (value <= 0)
    {
        System.Console.WriteLine("Enter positive number");
        return false;
    }
    return true;
}

int SumNumbers(int value)       // Calculated Summ
{
    int sum = 0;

    for(int i = 1; i <= value; i++)
    {
        sum +=i;
    }
    return sum;
}

int value = InputInt("Enter number");

if (ValidatePositive(value))
{
int sum = SumNumbers(value);
System.Console.WriteLine($"Summ numbers on 1 for {value} equal {sum}");
System.Console.WriteLine($"Summ numbers of Gauss on 1 for {value} equal {SumGaussNumbers(value)}");
}

// Calculated Gauss Sum

int SumGaussNumbers(int value)
{
    return (1+value)*value/2;
}
