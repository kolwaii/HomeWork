// Напишите программу, которая принимает на вход 
// пятизначное число и проверяет, 
// является ли оно палиндромом.
// Выполнить с помощью числовых операций 
// (целочисленное деление, остаток от деления).

// 14212 -> нет

// 12821 -> да

// 23432 -> да

int Input(string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

bool ValidateNumber (int num)
{
    if (num > 100000)
    {
        Console.WriteLine("Вы ввели неверное число");
        return false;
    }
    return true;
}

bool Palindrome (int num)
{
    int firstNumber,secondNumber,thirdNumber,fourthNumber;
    firstNumber = num / 10000;
    secondNumber = num / 1000 % 10;
    thirdNumber = num / 10 % 10;
    fourthNumber = num % 10;
    if (firstNumber == fourthNumber && secondNumber == thirdNumber) 
    {
        return true;
    }
    return false;
    
      
    
}
int number = Input ("Введите пятизначное число:");
if (ValidateNumber(number))
{
    if (Palindrome(number))
    {
        Console.Write($"{number}-> да");
    }
    else
    {
        Console.Write($"{number}-> нет");
    }
}