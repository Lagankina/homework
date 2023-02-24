// Задача 1 - Напишите программу, котрая на вход принимает два числа и выдает,какое число большее, а какое меньшее
int a;
int b;
Console.WriteLine ("Введите число a: ");
a = int.Parse(Console.ReadLine());
Console.WriteLine ("Введите число b: ");
b = int.Parse(Console.ReadLine());

if(a>b) {
    Console.WriteLine("число " + a + "  большее, число " + b + " меньшее");
}
else {
    Console.WriteLine("число " + a + " меньше, числа " + b + " больше");
}