//Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 или Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.

int InputInt(string message)
{
    Console.Write($"{message}> ");
    int value;
    if(int.TryParse(Console.ReadLine(), out value))
    {
        return value;
    }
    Console.WriteLine("You enter not number");
    Environment.Exit(1);
    return 0;
}

bool ValidateCoords (int x, int y)
{
    if(x == 0 || y == 0)
    {
        Console.WriteLine("One coordinat nah na osi");
        return false;
    }
}

int GetQuorter(int x, int y)
{
    if(x > 0 && y > 0)
    {
        return 1;
    }
    if(x < 0 && y > 0)
    {
        return 2;
    }
    if(x < 0 && y < 0)
    {
        return 3;
    }
    return 4;    
}

int x = InputInt("Enter X");
int y = InputInt("Enter Y");
if(ValidateCoords(x,y))
{
    Console.WriteLine($"Координаты {x}, {y} находятся в четверти {GetQuorter(x, y)}");
}