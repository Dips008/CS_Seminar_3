using System;

class Program
{
    static void Main()
    {
        // Программа, которая принимает координаты  точек 
        // и находит расстояние между ними в 3-х мерном пространстве
        Console.Clear();
        int x1, y1, z1, x2, y2, z2;
        x1 = InitCoordinatesByUser("Введите координату х первого числа: ");
        y1 = InitCoordinatesByUser("Введите координату y первого числа: ");
        z1 = InitCoordinatesByUser("Введите координату z первого числа: ");
        x2 = InitCoordinatesByUser("Введите координату х второго числа: ");
        y2 = InitCoordinatesByUser("Введите координату y второго числа: ");
        z2 = InitCoordinatesByUser("Введите координату z второго числа: ");
        double dist = distanse(x1, y1, z1, x2, y2, z2);
        Console.WriteLine($"Расстояние между точками А ({x1}. {y1}, {z1}) и В ({x2}, {y2}, {z2}) -> {dist}");
        //------------------------------------------------------------
        static int InitCoordinatesByUser(string message)
        {
            Console.Write(message);
            int result = int.Parse(Console.ReadLine() ?? "");
            return result;
        }
        // --------------------------------------------------------
        static double distanse(int x1, int y1, int z1, int x2, int y2, int z2)
        {
            double result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));
            return Math.Round(result, 2);
        }
        // ------------------------------------------------------------------

    }
}
