// Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string Ranch (int num)
{
    if (num == 1) return "x > 0, y > 0";
    if (num == 2) return "x < 0, y > 0";
    if (num == 3) return "x < 0, y < 0";
    if (num == 4) return "x > 0, y < 0";
    return null;
}

Console.WriteLine("Введите номер четверти: ");
int numberQuarter = Convert.ToInt32(Console.ReadLine());

string ranch = Ranch(numberQuarter);
Console.WriteLine(ranch == null 
                ? "Неправильный номер четверти"
                : ranch);//Тернарный оператор 
