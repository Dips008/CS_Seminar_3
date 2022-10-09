//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 
//и выдаёт номер четверти плоскости, в которой находится эта точка.
// -------------------------- Начало программы ----------------------------------
Console.Clear();
int X = 0, Y = 0;
InitCoordinatesByUser(ref X, ref Y); // Вызов метода с передачей параметров по ссылке (ref)
PrintQuarterByCoords(X, Y); // Вызов метода с передачей параметров по значению
// -------------------------- Конец программы ----------------------------------
// -------------------------Определение методов ---------------------------------
// ------------------------------------------------------------------------------
// Определяем функцию, выполняющую ввод значений координат
static void InitCoordinatesByUser(ref int x, ref int y)
{
    try
    {
        Console.Write("Введите X: ");
        x = int.Parse(Console.ReadLine() ?? "");
        Console.Write("Введите Y: ");
        y = int.Parse(Console.ReadLine() ?? "");
    }
    catch (Exception exc)
    {
        Console.WriteLine($"Ошибка ввода данных! {exc.Message}");
        return;
    }
}
// -----------------------------------------------------------------------------
// Определяем функцию, принимающую два аргумента (координаты точки x и y)
// и выводящую в консоль номер четверти плоскости, в которой находится эта точка
static void PrintQuarterByCoords(int x, int y)
{
    if (x > 0 && y > 0)
        Console.WriteLine("1");
    else if (x < 0 && y > 0)
        Console.WriteLine("2");
    else if (x < 0 && y < 0)
        Console.WriteLine("3");
    else if (x > 0 && y < 0)
        Console.WriteLine("4");
    else
        Console.WriteLine("Ошибка! Точка попадает на оси координат!");
}
// ---------------------- Конец определения методов ----------------------------


// Программа, которая на вход принимает координаты точки (х; у)
// и выдает номер четверти плоскости.
Console.Clear();

// Console.Write("Введите х: ");
// int x = int.Parse(Console.Read());
// Console.Write("Введите y: ");
// int y = int.Parse(Console.Read());

// while (true)
//{
//    Console.Write("Введите координату Х: ");
//    int.TryParse(Console.ReadLine(), out x);
//    if (x != 0) break;
//    else Console.WriteLine("Ошибка ввода!");
//}
//while (true)
//{
//    Console.Write("Введите координату y: ");
//    int.TryParse(Console.ReadLine(), out y);
//    if (y != 0) break;
//    else Console.WriteLine("Ошибка ввода!");
//}

// int x, y;
// try
//{
//    Console.Write("Введите х: ");
//    x = int.Parse(Console.ReadLine() ?? "");
//    Console.Write("Введите y: ");
//    y = int.Parse(Console.ReadLine() ?? "");
//}

//catch (Exception exc)
//{
//    Console.WriteLine($"Ошибка ввода! {exc.Message}");
//    return;
//}

//if (x > 0 && y > 0)
//    Console.WriteLine($"Точка с координатами ({x}; {y}) находится в 1-й четверти плоскости.");
//else if (x < 0 && y > 0)
//    Console.WriteLine($"Точка с координатами ({x}; {y}) находится в 2-й четверти плоскости.");
//else if (x < 0 && y < 0)
//    Console.WriteLine($"Точка с координатами ({x}; {y}) находится в 3-й четверти плоскости.");
//else if (x > 0 && y < 0)
//    Console.WriteLine($"Точка с координатами ({x}; {y}) находится в 4-й четверти плоскости.");
//else Console.WriteLine($"Точка с координатами ({x}; {y}) находится на оси координат!");