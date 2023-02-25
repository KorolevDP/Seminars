
//Напишите программу, которая на вход принимает два числа и проверяет, является ли второе число квадратом первого.

int Promt(string msg)
{
    System.Console.Write($"{msg} >");
    return Convert.ToInt32(Console.ReadLine());
}

int value1 = Promt("Enter first number ");
int value2 = Promt("Enter second number");

if(value2 == value1 * value1)
{
 Console.WriteLine($"Number {value2} is  square {value1}");
}
else
{
  Console.WriteLine($"Number {value2} is not a square {value1}");
}
