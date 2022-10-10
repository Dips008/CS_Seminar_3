using System;

class Program
{// Программа, которая принимает число N и выдает таблицу 
 // кубов чисел от 1 до N.
    static void Main()
    {
        Console.Clear();
        int number = NumberByUser();
        Pow3(number);
        // ------------------------------------------------------------
        static int NumberByUser()
        {
            Console.Write("Ведите число N: ");
            int number = int.Parse(Console.ReadLine() ?? "");
            return number;
        }
        // ------------------------------------------------------------------     
        static void Pow3(int number)
        {
            Console.Write($"{number} -> ");
            for (int i = 1; i < number; i++)
            {
                Console.Write($"{Math.Pow(i, 3)}, ");
            }
            Console.Write($"{Math.Pow(number, 3)}");
        }
        //-------------------------------------------------------------------------
    }
}
