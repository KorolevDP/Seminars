// Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.
// 14 -> нет 
// 46 -> нет 
// 161 -> да

int Promt(string msg)
{
    System.Console.WriteLine($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int num = Promt("Enter number");
int divider1 = Promt("Enter first devider");
int divider2 = Promt("Enter second devider");

if(num % divider1 == 0  && num % divider2 == 0)
{
    System.Console.WriteLine($"Number {num} simultaneously multiple numbers {divider1} и {divider2}");
}
else
{
     System.Console.WriteLine($"Number {num} is not simultaneously a multiple of numbers {divider1} и {divider2}");
}