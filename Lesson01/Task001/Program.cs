// Напишите программу, которая на вход принимает число и выдаёт его квадрат (число умноженное на само себя).

Console.Write("Enter number > ");               //Вывод в консоль приглашение для ввода
string inputValue;                              // Объявление переменной, в которую будем сохранять значение
inputValue = Console.ReadLine();                // Присваивание переменной из консоли (ввод пользователя)
int value = Convert.ToInt32(inputValue);

int square = value * value;                     // Вычисление квадрата

Console.WriteLine($"Number square {value} equal {square}");      // Вывод на экран