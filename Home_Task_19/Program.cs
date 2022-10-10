using System;
class Program
{
    static void Main()
    {
        // Программа, которая которая принимает на вход пятизначное число и 
        //проверяет, является ли оно палиндромом.
        Console.Clear();
        int number = 0;
        InitQuarterByUser(ref number);
        Palindrom(number);
        // ----------------------------------------------------------
        static void InitQuarterByUser(ref int number)
        {
            try
            {
                Console.Write("Ведите пятизначное число: ");
                number = int.Parse(Console.ReadLine() ?? "");
            }
            catch (Exception exc)
            {
                Console.WriteLine($"Ошибка ввода! {exc.Message}");
                return;
            }
        }
        //-----------------------------------------------------------
        static void Palindrom(int number)
        {
            if (number / 10000 == number % 10 && number % 10000 / 1000 == number % 100 / 10)
            {
                Console.WriteLine($" {number} -> палиндром");
            }
            else Console.WriteLine($" {number} -> не палиндром");
        }
    }
}