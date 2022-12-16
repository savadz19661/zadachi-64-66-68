// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа
//            в промежутке от N до 1. 
//            Выполнить с помощью рекурсии.

using System;
using static System.Console;

Clear();
Write("Введите N: ");
int n=int.Parse(ReadLine());

WriteLine(PrintNumbers(n));

string PrintNumbers(int end)
{
    if (end == 1)
    {
        Console.WriteLine(1);
        return "1";
    }
    string s = end.ToString() + ' ' + PrintNumbers(end - 1);
    Console.WriteLine(s);
    return (s);
}