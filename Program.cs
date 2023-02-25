// Напишите программу , которая на вход принимает число, и выдает, является  ли число четным
Console.WriteLine("Введите число number: ");
int number = int.Parse (Console.ReadLine());

 if ( number%2==0 ) {
    Console.WriteLine("Число " + number + " четное" );
 }  
 else {
    Console.WriteLine("Число " + number + " нечетное");
 }
