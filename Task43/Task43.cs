// Write a programm which will find coordinates of their intersection point
// The lines are given by the equations:
// y = k1 * x + b1
// y = k2 * x + b2
// k1, k2, b1 and b2 defines by user

Console.Write("Enter the k1 coefficient: ");
float k1 = float.Parse(Console.ReadLine());
Console.Write("Enter the b1 coefficient: ");
float b1 = float.Parse(Console.ReadLine());
Console.Write("Enter the k2 coefficient: ");
float k2 = float.Parse(Console.ReadLine());
Console.Write("Enter the b2 coefficient: ");
float b2 = float.Parse(Console.ReadLine());

void DefineIntersectionPoint(float k1, float b1, float k2, float b2)
{
    double XCoord = (b2 - b1) / (k1 - k2);
    double YCoord = k1 * XCoord + b1;
    Console.WriteLine("Intersection point coordinates are: ({0:f2}, {1:f2})", XCoord, YCoord);
}

DefineIntersectionPoint(k1, b1, k2, b2);