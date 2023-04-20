// Напишите программу, которая принимает на вход число (N)
//  и выдаёт таблицу кубов чисел от 1 до N.

// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

int Input(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void CubeTable(int num)
{
    int count;
    count = 1;
    while (count <= num)
    {
        Console.WriteLine($"{count, 3} | {count * count * count, -4}");
        count++;
    }
}


int number = Input ("Введите число: ");
CubeTable(number);