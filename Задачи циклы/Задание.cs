using System; 

namespace Task_1 
{
    class Program 
    {
        static void Main() 
        {
            Console.Write("Введите сумму вклада: "); // ввести сумму вклада
            decimal sum = Convert.ToDecimal(Console.ReadLine()); // Считывание строки с консоли и преобразование в decimal (денежный тип)

            Console.Write("Введите количество месяцев: "); // ввести количество месяцев вклада
            int months = Convert.ToInt32(Console.ReadLine()); // Считывание строки и преобразование в целое число (кол-во месяцев)

            for (int i = 0; i < months; i++) // Цикл от 0 до months-1, выполняется для каждого месяца
            {
                sum += sum * 0.07m; // Увеличение суммы вклада на 7% (0.07m - литерал decimal)
            }

            Console.WriteLine($"Конечная сумма вклада: {sum}"); // Вывод итоговой суммы вклада после начисления процентов
            Console.ReadKey(); 
        }
    }
}