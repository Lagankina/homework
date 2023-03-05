// ... которая прнимает на вход пятизначное число и проверяет, является ли оно палиндроном
Console.WriteLine("Введите пятизначное число: ");
int a = int.Parse(Console.ReadLine());

bool result = false;

if (a < 100000 && a > 9999) {
    if(a / 10000 == a % 10) {
       if (a / 1000 % 10 == a % 100 / 10) {
        result =true;
       }
    } 
}
 
if (result)
    Console.WriteLine("палиндром");
else
    Console.WriteLine("не является палиндроном!");


