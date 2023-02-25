//Напишите программу, которая будет выдавать название дня недели по заданному номеру.

string[] week = new string[7] {"'Monday'", "'Tuesday'", "'Wednesday'", "'Thursday'", "'Friday'", "'Saturday'", "'Sunday'"};
while(true)
{
    Console.WriteLine("Enter number from 1 to 7");
    int userNumber = Convert.ToInt32(Console.ReadLine());
    if(userNumber < 1 || userNumber > 7)
    {
        Console.WriteLine("You entered the wrong number");
    }
    else
    {
        int weekIndex = userNumber -1;
        Console.WriteLine($"You entered number {userNumber} this is the day of the week {week[weekIndex]}");
        break;
    }
}