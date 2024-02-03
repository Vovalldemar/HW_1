using System;

class Program
{
    static void Main()
    {
        // Задача 1: Задайте значения M и N. 
        // Напишите программу, которая выведет все натуральные числа в промежутке от M до N. Использовать рекурсию, не использовать циклы.


        
        Console.Write("a = 1 \n");
        int a = 1;

        Console.Write("b = 9 \n ");
        int b = 9;
        

        PrintNaturalNumbers(a, b);
    }

    static void PrintNaturalNumbers(int start, int end)
    {
        if (start <= end)
        {
            Console.WriteLine(start);
            PrintNaturalNumbers(start + 1, end);
        }
    }
}
