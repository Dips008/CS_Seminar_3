// Программа, которая по введенному номеру четверти
// выводит диапазон возможных координат (х и у).
Console.Clear();
int number = 0;
InitQuarterByUser(ref number);
PrintSizeByCoords(number);
// ----------------------------------------------------------
static void InitQuarterByUser(ref int number)
{
    try
    {
        Console.Write("Ведите номер четверти: ");
        number = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода! {exc.Message}");
        return;
    }
}
//-----------------------------------------------------------
static void PrintSizeByCoords(int number)
{
    if (number == 1) Console.WriteLine($" X (0, ∞) и Y (0, ∞)");
    else if (number == 2) Console.WriteLine($" X (0, -∞) и Y (0, ∞)");
    else if (number == 3) Console.WriteLine($" X (0, -∞) и Y (0, - ∞)");
    else if (number == 4) Console.WriteLine($" X (0, ∞) и Y (0, - ∞)");
    else Console.WriteLine($"Нет такой четверти плоскости");
}
