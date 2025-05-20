using System;   // ЗАДАНИЕ 1
using System.Numerics;

public class Task1
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(' ');

        BigInteger a = BigInteger.Parse(input[0]);
        BigInteger b = BigInteger.Parse(input[1]);

        Console.WriteLine(a + b);
    }
}


﻿using System;  // ЗАДАНИЕ 2

public class TriangleCheck
{
    public static void Main(string[] args)
    {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        int c = int.Parse(Console.ReadLine());

        if (a + b > c && a + c > b && b + c > a)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}


﻿using System;  // ЗАДАНИЕ 3
using System.Linq;

public class CountElements
{
    public static void Main(string[] args)
    {
        int[] numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
        int count = 0;

        for (int i = 1; i < numbers.Length - 1; i++)
        {
            if (numbers[i] > numbers[i - 1] && numbers[i] > numbers[i + 1])
            {
                count++;
            }
        }

        Console.WriteLine(count);
    }
}



using System;   // ЗАДАНИЕ 4

public class TagTime
{
    public static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        long[] t = new long[n];
        long totalTime = 0;

        if (n >= 1)
        {
            t[0] = 1;
            totalTime += t[0];
        }
        if (n >= 2)
        {
            t[1] = 1;
            totalTime += t[1];
        }

        for (int i = 2; i < n; i++)
        {
            t[i] = t[i - 1] + t[i - 2];
            totalTime += t[i];
        }

        Console.WriteLine(totalTime);
    }
}

﻿using System;  // ЗАДАНИЕ 5



public class QuadraticEquation
{
    public static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split();
        double a = double.Parse(input[0]);
        double b = double.Parse(input[1]);
        double c = double.Parse(input[2]);

        double discriminant = b * b - 4 * a * c;

        if (discriminant < 0)
        {
            Console.WriteLine(0);
        }
        else if (discriminant == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine(1);
            Console.WriteLine($"{x:F6}");
        }
        else
        {
            double x1 = (-b - Math.Sqrt(discriminant)) / (2 * a);
            double x2 = (-b + Math.Sqrt(discriminant)) / (2 * a);

            Console.WriteLine(2);
            Console.WriteLine($"{Math.Min(x1, x2):F6} {Math.Max(x1, x2):F6}");
        }
    }
}