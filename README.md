# Домашние задание про Методы
Китаев Максим Ипо-23-23

Вопрос 1|Ответ:B

Вопрос 2|Ответ:A

Вопрос 3|Ответ:B

Вопрос 4|Ответ:B

Вопрос 5|Ответ:A C

Вопрос 6|Ответ:A

Вопрос 7|Ответ:A D


Практическая часть 

Задача 1: 

using System;
using System.Collections.Generic;

public class Program
{
    public static int SumNumbers(List<int> numbers)
    {
        int sum = 0;
        foreach (int num in numbers)
        {
            sum += num;
        }
        return sum;
    }
    
    public static void Main()
    {
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int result = SumNumbers(numbers);
        Console.WriteLine("Сумма чисел: " + result); // Выведет: 15
    }
}

Задача 2:

using System;

public class Program
{
    public static bool IsPalindrome(string str)
    {
        // Удаляем пробелы и приводим к нижнему регистру для регистронезависимой проверки
        string cleanedStr = str.Replace(" ", "").ToLower();
        
        int left = 0;
        int right = cleanedStr.Length - 1;

        while (left < right)
        {
            if (cleanedStr[left] != cleanedStr[right])
            {
                return false;
            }
            left++;
            right--;
        }
        return true;
    }

    public static void Main()
    {
        string testStr1 = "А роза упала на лапу Азора";
        string testStr2 = "hello";
        
        Console.WriteLine($"\"{testStr1}\" — палиндром? {IsPalindrome(testStr1)}"); // true
        Console.WriteLine($"\"{testStr2}\" — палиндром? {IsPalindrome(testStr2)}"); // false
    }
}

Задача 3:

using System.Numerics;

public static BigInteger Factorial(int n)
{
    if (n < 0)
        throw new ArgumentException("Факториал определен только для неотрицательных чисел");
    
    BigInteger result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}

Задача 4:

using System.Linq;

public static int FindMax(List<int> numbers)
{
    return numbers.Max();
}

Задача 5:

using System.Linq;

public static List<T> RemoveDuplicates<T>(List<T> list)
{
    return list.Distinct().ToList();
}

