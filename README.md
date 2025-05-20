
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










Домашняя работа по ОП.0.9 Основы алгоритмизации и программирования
Работу выполнил: Китаев Максим Ипо-23-23

Информация об версии движка
Проект разработан на версии net. 8 под windows на фреммворке net.fremvork

Ссылки на задания:
Ваша задача — создать простой калькулятор, который сможет выполнять базовые арифметические операции: сложение, вычитание, умножение и деление, остаток от деления, инкремент, декремент. Калькулятор должен предоставлять пользователю возможность вводить числа и выбирать:
папка: (https://github.com/maxim539/ura/blob/main/%D0%9A%D0%B0%D0%BB%D1%8C%D0%BA%D1%83%D0%BB%D1%8F%D1%82%D0%BE%D1%80/%D0%BA%D0%B0%D0%BB%D1%8C%D0%BA%D1%83%D0%BB%D1%8F%D1%82%D0%BE%D1%80.cs)

Создание интерактивной новеллы с использованием бесконечного цикла:
папка: (https://github.com/maxim539/ura/blob/main/%D0%9D%D0%BE%D0%B2%D0%B5%D0%BB%D0%BB%D0%B0/%D0%BD%D0%BE%D0%B2%D0%B5%D0%BB%D0%BB%D0%B0.cs)

# Домашние задание про Методы

Вопрос 1|Ответ:B

Вопрос 2|Ответ:A

Вопрос 3|Ответ:B

Вопрос 4|Ответ:B

Вопрос 5|Ответ:A C

Вопрос 6|Ответ:A

Вопрос 7|Ответ:A D

Задача 1: Сумма чисел в списке. Напишите метод, который принимает список чисел и возвращает их сумму.
папка: (https://github.com/nnnsssttt/zadania/blob/main/1.cs)

Задача 2: Проверка на палиндром. Напишите метод, который принимает строку и проверяет, является ли она палиндромом (читается одинаково слева направо и справа налево).
папка: (https://github.com/nnnsssttt/zadania/blob/main/2.cs)

Задача 3: Факториал числа. Напишите метод, который вычисляет факториал заданного числа.
папка: (https://github.com/nnnsssttt/zadania/blob/main/3.cs)

Задача 4: Поиск максимального элемента в списке. Напишите метод, который находит максимальный элемент в списке.
папка: (https://github.com/nnnsssttt/zadania/blob/main/4.cs)

Задача 5: Удаление дубликатов из списка. Напишите метод, который принимает список и возвращает новый список без дубликатов.
папка: (https://github.com/nnnsssttt/zadania/blob/main/5.cs)

Задание 1 CodeRun: Юля, Никита и задачи
папка: (https://github.com/nnnsssttt/zadania/blob/main/Code/CodePen/1.cs)

Задание 2 CodeRun: Треугольник
папка: (https://github.com/nnnsssttt/zadania/blob/main/Code/CodePen/2.cs)

Задание 3 CodeRun: Больше своих соседей
папка: (https://github.com/nnnsssttt/zadania/blob/main/Code/CodePen/3.cs)

Задание 4 CodeRun: Выставление тегов
папка: (https://github.com/nnnsssttt/zadania/blob/main/Code/CodePen/4.cs)

Задание 5 CodeRun: 29 задача аналитики
папка: (https://github.com/nnnsssttt/zadania/blob/main/Code/CodePen/5.cs)
