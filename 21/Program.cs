/*Напишите программу, которая принимает на вход координаты 
двух точек и находит расстояние между ними в 3D пространстве.*/

void Dots (int[] X) // Ввод координат
{
    Console.WriteLine("Поочередно введите x, y, z: ");
    Console.Write("x =" + " ");
    X[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("y =" + " ");
    X[1] = Convert.ToInt32(Console.ReadLine());
    Console.Write("z =" + " ");
    X[2] = Convert.ToInt32(Console.ReadLine());
}

double Lon(int[] A, int[] B) // Рассчет расстояния между точками в 3Д
{
double lon = Math.Sqrt(Math.Pow((B[0] - A[0]), 2) + Math.Pow((B[1] - A[1]), 2) + Math.Pow((B[2] - A[2]), 2));
return lon;
}

int[] A = new int[3];
int[] B = new int[3];

Console.WriteLine("Введите координаты первой точки.");
Dots(A);
Console.WriteLine("Введите координаты второй точки.");
Dots(B);

Console.WriteLine($"Расстояние между точками: {Lon(A, B)}");

