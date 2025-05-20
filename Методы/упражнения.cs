using System;
using System.Collections.Generic;
using System.Linq;

public class Task1
{
    public static void Main()
    {
        // Пример использования метода
        List<int> numbers = new List<int> { 1, 2, 3, 4, 5 };
        int sum = SumNumbers(numbers);
        Console.WriteLine($"Сумма чисел: {sum}");
    }

    public static int SumNumbers(List<int> numbers)
    {
        return numbers.Sum();
    }
}



using System.Linq;          //Task2

public static bool IsPalindrome(string text)
{
    if (string.IsNullOrEmpty(text))
        return false;

    string cleaned = new string(text.ToLower().Where(char.IsLetterOrDigit).ToArray());
    return cleaned.SequenceEqual(cleaned.Reverse());
}



using System;

public static long Factorial(int n)         //Task3
{
    if (n < 0)
        throw new ArgumentException("Факториал определен только для неотрицательных чисел.");

    long result = 1;
    for (int i = 2; i <= n; i++)
    {
        result *= i;
    }
    return result;
}



using System;

public static T FindMax<T>(List<T> list) where T : IComparable<T>       //Task4
{
    if (list == null || list.Count == 0)
        throw new ArgumentException("Список пуст или равен null");

    T max = list[0];
    for (int i = 1; i < list.Count; i++)
    {
        if (list[i].CompareTo(max) > 0)
            max = list[i];
    }
    return max;
}



using System;
using System.Collections.Generic;

public static List<T> RemoveDuplicates<T>(List<T> list)         //Task5
{
    List<T> result = new List<T>();
    
    foreach (T item in list)
    {
        if (!result.Contains(item))
        {
            result.Add(item);
        }
    }
    
    return result;
}