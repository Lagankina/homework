// ... котора принимает на вход координаты двух точек и находит расстояние между ними в 3д пространстве
Console.WriteLine("Введите координаты точки А: ");
int x = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки А: ");
int y = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки А: ");
int z = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координаты точки В: ");
int z1 = int.Parse(Console.ReadLine());

int A = x - x1;
int B = y - y1;
int C = z - z1;

double result = Math.Sqrt(Math.Pow(A,2) + Math.Pow(B,2) + Math.Pow(C,2));

Console.WriteLine(result);