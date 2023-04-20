// Напишите программу, которая принимает
// на вход координаты двух точек
// и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

int Input (string message)
{
    Console.Write(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

double DistanceAB(int xA,int yA,int xB,int yB,int zA,int zB)
{
    int deltaX = xA - xB;
    int deltaY = yA - yB;
    int deltaZ = zA - zB;
    double distAB = Math.Sqrt(deltaX * deltaX + deltaY * deltaY + deltaZ * deltaZ);
    return distAB;
}

Console.WriteLine("Введите координаты точки - A");
int xCoordinate = Input ("xA: ");
int yCoordinate = Input ("yA: ");
Console.WriteLine("Введите координаты точки - B");
int xBCoordinate = Input ("xB: ");
int yBCoordinate = Input ("yB: ");
Console.WriteLine("Введите координаты точки - Z");
int zACoordinate = Input ("zA: ");
int zBCoordinate = Input ("yB: ");

double distanceAB = DistanceAB(xCoordinate,yCoordinate,xBCoordinate,yBCoordinate,zACoordinate,zBCoordinate);
double distRound = Math.Round(distanceAB, 2, MidpointRounding.ToZero );
Console.WriteLine(distRound);
