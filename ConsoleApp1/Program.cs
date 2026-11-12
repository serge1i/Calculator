using System.Globalization;

while (true)
{
    Console.Write("Введите первое число (или q для выхода): ");
    var firstInput = Console.ReadLine();
    if (string.Equals(firstInput, "q", StringComparison.OrdinalIgnoreCase))
    {
        break;
    }

    if (!double.TryParse(firstInput, CultureInfo.CurrentCulture, out var firstNumber))
    {
        Console.WriteLine("Некорректное число.");
        continue;
    }

    Console.Write("Введите операцию (+, -, *, /): ");
    var operation = Console.ReadLine();

    Console.Write("Введите второе число: ");
    if (!double.TryParse(Console.ReadLine(), CultureInfo.CurrentCulture, out var secondNumber))
    {
        Console.WriteLine("Некорректное число.");
        continue;
    }

    switch (operation)
    {
        case "+":
            Console.WriteLine($"Результат: {firstNumber + secondNumber}");
            break;
        case "-":
            Console.WriteLine($"Результат: {firstNumber - secondNumber}");
            break;
        case "*":
            Console.WriteLine($"Результат: {firstNumber * secondNumber}");
            break;
        case "/" when secondNumber != 0:
            Console.WriteLine($"Результат: {firstNumber / secondNumber}");
            break;
        case "/":
            Console.WriteLine("На ноль делить нельзя.");
            break;
        default:
            Console.WriteLine("Неизвестная операция.");
            break;
    }
}
