//Напишите программу, которая будет принимать на вход два числа и выводить, является ли второе число кратным первому. 
//Если число 2 не кратно числу 1, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4 
// 16, 4 -> кратно

int Promt(string msg)
{
    System.Console.WriteLine($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int del = Promt("Enter devider >");
int num = Promt("Enter number >");
int rem = num % del;

if(rem == 0)
{
    System.Console.WriteLine($"{num} is a multiple {del}");
}
else
{
    System.Console.WriteLine($"{num} not a multiple {del}, remainder equal {rem}");
}