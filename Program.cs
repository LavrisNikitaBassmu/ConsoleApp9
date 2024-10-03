using System;

class CalculateExpression
{
    static void Main(string[] args)
    {
        // Запрашиваем у пользователя действительное число x
        Console.Write("Введите действительное число x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Вычисляем выражение
        double x2 = x * x;
        double x4 = x2 * x2;
        double result = 7 + x * (2 * x2 - 5 * x + x4 * 3);

        // Выводим результат на консоль
        Console.WriteLine($"Результат: {result}");
    }
}