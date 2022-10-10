// Программа, которая принимает число N и выдает таблицу 
// квадратов чисел от 1 до N.
Console.Clear();
// ------------------------------------------------------------
Console.Write("Ведите число N: ");
int number = int.Parse(Console.ReadLine() ?? "");
// --------------------------------------------------------------
static void Pow(int number)
{
    int count = 1;
    Console.Write($"{number} ->");
    while (count < number + 1)
    {
        Console.Write($"{count * count}, ");
        count++;
    }
}
//------------------------------------------------------------------
Pow(number);
