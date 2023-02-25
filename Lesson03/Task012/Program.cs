// Задача 3: Напишите программу, которая принимает на вход координаты двух 
// точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09 
// A (7,-5); B (1,-1) -> 7,21

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

double Distance (int x1, int y1, int x2, int y2)
{
    int deltaX = x2 - x1;
    int deltaY = y2 - y1;
    return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
}

int x1 = InputInt("Enter X1 of first dot ");
int y1 = InputInt("Enter Y1 of first dot ");
int x2 = InputInt("Enter X2 of second dot ");
int y2 = InputInt("Enter Y2 of second dot ");

Console.WriteLine($"Distance between dot A({x1},{y1}) and dot B({x2}, {y2}) equal {Distance (x1, y1, x2, y2)}");

