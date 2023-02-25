

int Promt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

bool Validate(int num)
{
    if(num >= 100 && num < 1000)
    {
        return true;
    }
    System.Console.WriteLine("This number is not three digits.");
    return false;
}

int number = Promt("Enter three-digit number");
if(Validate(number))
{
    int lastDigit = number % 10;
    System.Console.WriteLine($"Last digit of number {number} is {lastDigit}");
}
