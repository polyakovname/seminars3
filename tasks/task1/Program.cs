// Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать циклы.
// Пример
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

Console.Write("Введите первое число: ");
int number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите последнее число: ");
int number2 = Convert.ToInt32(Console.ReadLine());
void GetNumbers(int num1, int num2)
{
    if (num1 <= num2)
    {
        Console.Write(num1 + " ");
        GetNumbers(num1 + 1, num2);
    }
}
GetNumbers(number1, number2);