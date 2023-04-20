// Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// Пример:
// double d = Math.Sqrt(5);

// double d1 = 5.09987654;
// double d1Round = Math.Round(d1, 2, MidpointRounding.ToZero);(Округление)
// Console.WriteLine(d1Round);
// double d = Math.Round(Math.Sqrt(5), 2) (Метод)

int Input (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double DistanceAB(int xA,int yA,int xB,int yB)
{
    int deltaX = xA - xB;
    int deltaY = yA - yB;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
    return distAB;
}

Console.WriteLine("Введите координаты точки - A");
int xCoordinate = Input ("xA: ");
int yCoordinate = Input ("yA: ");
Console.WriteLine("Введите координаты точки - B");
int xBCoordinate = Input ("xB: ");
int yBCoordinate = Input ("yB: ");

double distanceAB = DistanceAB(xCoordinate,yCoordinate,xBCoordinate,yBCoordinate);
double distRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero );
Console.WriteLine(distRound);

