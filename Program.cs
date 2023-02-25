// Напишите программу,которая принимает на вход три числа и выдает максимальное из этих чисел
Console.WriteLine("Введите число a: ");
int a = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число b: ");
int b = int.Parse(Console.ReadLine());
Console.WriteLine("Введите число c: ");
int c = int.Parse(Console.ReadLine());

int max = a;
if (max < b) {
    max = b;
}
if (max < c) {
    max = c;
}

Console.WriteLine("Max = " + max);
