// Напишите программу, которая на вход принимает число (N),  а на выходе показывает все четные числа от 1 до N
Console.WriteLine("Введите положительное число: ");
int n = int.Parse (Console.ReadLine());

for (int number = 2; number < n; number++) {
    if (number%2==0)
        Console.WriteLine (number);
}

