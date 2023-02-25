// Напишите программу, которая по заданному номеру четверти, показывает
// диапазон возможных координат точек в этой четверти (x и y)
// X > 0, y < 0

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

bool validateQuorter(int quorter)
{
    if( 1 > quorter || quorter > 4)
    {
        Console.WriteLine("Invalid quorter");
        return false;
    }
    return true;
}

(int , int) GetCoords(int quorter)
{
    switch (quorter)
    {
        case 1: return (1, 1); 
        break;
        case 2: return (-1, 1); 
        break;
        case 3: return (-1,-1); 
        break;
        default: return (1, -1);
        break;
    }
}

int quorter = InputInt("Enter number quorter ");
if (validateQuorter(quorter))
{
    (int x, int y) = GetCoords(quorter);
    Console.WriteLine($"Coords in quorter {quorter} : {x}, {y}");
}
