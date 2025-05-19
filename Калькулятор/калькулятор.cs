namespace Calculator
{
    using System;

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Калькулятор");
            Console.WriteLine("Доступные операции: +, -, *, /, %, ++, --");

            // Ввод первого числа с проверкой корректности
            double num1;
            Console.Write("Введите первое число: ");
            while (!double.TryParse(Console.ReadLine(), out num1))
            {
                Console.WriteLine("Ошибка: введите корректное число!");
                Console.Write("Введите первое число: ");
            }

            // Ввод второго числа с проверкой корректности
            double num2;
            Console.Write("Введите второе число: ");
            while (!double.TryParse(Console.ReadLine(), out num2))
            {
                Console.WriteLine("Ошибка: введите корректное число!");
                Console.Write("Введите второе число: ");
            }

            Console.Write("Выберите операцию: ");
            string operation = Console.ReadLine();

            double result = 0;
            bool error = false;

            switch (operation)
            {
                case "+": // Сложение
                    result = num1 + num2;
                    Console.WriteLine($"{num1} + {num2} = {result}");
                    break;

                case "-": // Вычитание
                    result = num1 - num2;
                    Console.WriteLine($"{num1} - {num2} = {result}");
                    break;

                case "*": // Умножение
                    result = num1 * num2;
                    Console.WriteLine($"{num1} * {num2} = {result}");
                    break;

                case "/": // Деление
                    if (num2 != 0)
                    {
                        result = num1 / num2;
                        Console.WriteLine($"{num1} / {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        error = true;
                    }
                    break;

                case "%": // Остаток от деления
                    if (num2 != 0)
                    {
                        result = num1 % num2;
                        Console.WriteLine($"{num1} % {num2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine("Ошибка: деление на ноль!");
                        error = true;
                    }
                    break;

                case "++": // Инкремент (увеличение на 1)
                    result = num1 + 1;
                    double result2 = num2 + 1;
                    Console.WriteLine($"Инкремент {num1}++ = {result}");
                    Console.WriteLine($"Инкремент {num2}++ = {result2}");
                    break;

                case "--": // Декремент (уменьшение на 1)
                    result = num1 - 1;
                    double result3 = num2 - 1;
                    Console.WriteLine($"Декремент {num1}-- = {result}");
                    Console.WriteLine($"Декремент {num2}-- = {result3}");
                    break;

                default: // Неизвестная операция
                    Console.WriteLine("Неизвестная операция!");
                    error = true;
                    break;
            }

            // Вывод итогового результата (если не было ошибок и операция не инкремент/декремент)
            if (!error && operation != "++" && operation != "--")
            {
                Console.WriteLine($"Результат: {result}");
            }

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}