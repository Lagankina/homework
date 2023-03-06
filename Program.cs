// ... которая прнимает на вход число (N), и выдает таблицу кубов чисел от 1 до N.
Console.WriteLine("Введите число N: ");
int N = int.Parse(Console.ReadLine());


for(int i = 1; i <= N; i++ ) {
   
  Console.WriteLine((Math.Pow(i,3)));
 }


