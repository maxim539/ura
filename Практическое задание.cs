
namespace Task1
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
            for (int p = 0; p < mas.GetLength(0); p++)
            {
                Console.Write("{");
                for (int o = 0; o < mas.GetLength(1); o++)
                {
                    Console.Write("{");
                    for (int n = 0; n < mas.GetLength(2); n++)
                    {
                        Console.Write(mas[p, o, n]);
                        if (n < mas.GetLength(2) - 1)
                            Console.Write(", ");
                    }
                    Console.Write("}");
                    if (o < mas.GetLength(1) - 1)
                        Console.Write(", ");
                }
                Console.Write("}");
                if (p < mas.GetLength(0) - 1)
                    Console.Write(", ");
            }
            Console.WriteLine("}");

            Console.ReadKey();
        }
    }
}