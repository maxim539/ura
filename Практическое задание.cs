
namespace Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = {
                { { 1, 2 }, { 3, 4 } },
                { { 4, 5 }, { 6, 7 } },
                { { 7, 8 }, { 9, 10 } },
                { { 10, 11 }, { 12, 13 } }
            };

            Console.Write("{");
            for (int p = 0; p < mas.GetLength(0); p++) // Перебор первого измерения
            {
                Console.Write("{");
                for (int o = 0; o < mas.GetLength(1); o++) // Перебор второго измерения
                {
                    Console.Write("{");
                    for (int n = 0; n < mas.GetLength(2); n++) // Перебор третьего измерения
                    {
                        Console.Write(mas[p, o, n]); // Вывод текущего элемента массива
                        if (n < mas.GetLength(2) - 1) 
                            Console.Write(", "); // Если это не последний элемент в третьем измерении, выводим запятую и пробел
                    }
                    Console.Write("}"); // Закрываем скобку третьего измерения
                    if (o < mas.GetLength(1) - 1)
                        Console.Write(", "); // Если это не последний элемент во втором измерении, выводим запятую и пробел
                }
                Console.Write("}"); // Закрываем скобку второго измерения
                if (p < mas.GetLength(0) - 1)
                    Console.Write(", "); // Если это не последний элемент в первом измерении, выводим запятую и пробел
            }
            Console.WriteLine("}"); // Закрываем скобку первого измерения и переходим на новую строку

            Console.ReadKey(); // Ожидаем нажатия клавиши, чтобы окно консоли не закрылось сразу
        }
    }
}