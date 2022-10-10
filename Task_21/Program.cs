// Программа, которая принимает координаты двух точек 
// и находит расстояние между ними в 2-х мерном пространстве
Console.Clear();
int x1, y1, x2, y2;
x1 = InitCoordinatesByUser("Введите координату х первого числа: ");
y1 = InitCoordinatesByUser("Введите координату y первого числа: ");
x2 = InitCoordinatesByUser("Введите координату х второго числа: ");
y2 = InitCoordinatesByUser("Введите координату y второго числа: ");
double dist = distanse(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками А ({x1}. {y1}) и В ({x2}, {y2}) -> {dist}");
/*double dist = 0;
InitCoordinatesByUser(ref x1, ref y1, ref x2, ref y2);
double dist = distanse(x1, y1, x2, y2);
Console.WriteLine($"Расстояние между точками А ({x1}. {y1}) и В ({x2}, {y2}) -> {dist}");
// ---------------------------------------------------------------------------
static void InitCoordinatesByUser(ref int x1, ref int y1, ref int x2, ref int y2)
{
    try
    {
        Console.Write("Введите X1 первой точки: ");
        x1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y1 первой точки: ");
        y1 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите X2 второй точки: ");
        x2 = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y2 второй точки: ");
        y2 = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
*/
//------------------------------------------------------------
static int InitCoordinatesByUser(string message)
{
    Console.Write(message);
    int result = int.Parse(Console.ReadLine() ?? "");
    return result;
}
// --------------------------------------------------------
static double distanse(int x1, int y1, int x2, int y2)
{
    double result = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
    return result;
}
// ------------------------------------------------------------------
