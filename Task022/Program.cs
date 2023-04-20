// Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
int Input(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

void Table(int num)
{
    int index;
    index = 1;
    while (index <= num)
    {
        Console.WriteLine($"{index, 3}  {index * index, 4}");
        index++;
    }
}


int number = Input ("Введите число: ");
Table(number);