// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
Console.WriteLine("Введите число: ");

int number = int.Parse(Console.ReadLine());
int tmp = number;
int sum = 0;
int index = 0;

while(tmp > 0)
{
    sum += tmp % 10;
    tmp = (int) (number / Math.Pow(10, ++index));
}
Console.WriteLine(sum);
