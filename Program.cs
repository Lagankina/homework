// Напишите программу, которая принимает на вход трехзначное число и на выходе показывает вторую цифру этого числа.
Console.Write("Введите трехзначное число number: ");
int number = int.Parse(Console.ReadLine());

int result = (number%100/10);

Console.WriteLine(result);
