// Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

Console.WriteLine("Введите число: ");
int number = int.Parse(Console.ReadLine());

int result = -1;

if(number>99) {
    while (number > 999) {
      number = number / 10;
    }
    result = number % 10; 
} else {
     Console.WriteLine("Третьего числа нет "); 
}
Console.WriteLine(result) ;