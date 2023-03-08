// Напишите программу, которая принимает на вход число и выдает сумму цифр в числе
Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());
// int count = getNumCount(number);

// int[] array = new int[count];
int tmp = number;
int sum = 0;
// for (int index = 0; index < count; index++)
// {
//     sum += tmp % 10;
//     tmp = tmp / Math.Pow(10, index);
// }

int index = 0;
while(tmp > 0)
{
    sum += tmp % 10;
    tmp = (int) (number / Math.Pow(10, ++index));
}
Console.WriteLine(sum);

// static int getNumCount(int a) {
//     int count = 0;
//     while((a / Math.Pow(10, count)) > 0)
//     {
//         count++;
//     }

//     return count;
// }