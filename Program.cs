// Задача1. Задайте значения M и N.
// Напишите программу, которая выведет все натуральные числа в промежутке от M до N.
// Использовать рекурсию, не использовать цикл.
// using System;
// public class Program
// {
// public static void PrintRange(int m, int n)
// {
// if (m > n)
// return;
// Console.WriteLine(m);
// PrintRange(m + 1, n);
// }
// public static void Main()
// {
// int m = 5;
// int n = 10;
// PrintRange(m, n);
// }
// }
// }// // Задача 2: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// // Даны два неотрицательных числа m и n.
// void Main()
// {
// int m = ReadInt("Введите первое число: ");
// int n = ReadInt("Введите второе число: ");
// Console.Write($"A({m}, {n}) = {AkkermanFunction(m, n)}");
// }
// Main();
// int ReadInt(string message)
// {
// Console.Write(message);
// return Math.Abs(Convert.ToInt32(Console.ReadLine()));
// }
// int AkkermanFunction(int m, int n)
// {
// if (m == 0) { return n + 1; }
// else if (n == 0) { return AkkermanFunction(m - 1, 1); }
// else { return AkkermanFunction(m - 1, AkkermanFunction(m, n - 1)); }

// }
// }// Задача 3: Задайте произвольный массив.
// Выведете его элементы, начиная с конца.
// Использовать рекурсию, не использовать циклы.
// using System;
// public class Program
// {
// public static void PrintArrayReverse(int[] arr, int index)
// {
// if (index >= 0)
// {
// Console.Write(arr[index] + " ");
// PrintArrayReverse(arr, index - 1);
// }
// }
// public static void Main(string[] args)
// {
// int[] myArray = { 5, -2, 3, 4, 5, 6, 9, 8, 9, 10 };
// Console.WriteLine("Элементы массива в обратном порядке:");
// PrintArrayReverse(myArray, myArray.Length - 1);
// }
// }