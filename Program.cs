// 
Console.WriteLine("Введите первое число: ");
int number1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите второе число: ");
int number2 = int.Parse(Console.ReadLine());
int result = 1;

for(int i = 0; i < number2; i++)
{
    result = result * number1; 
}
Console.WriteLine(result);

