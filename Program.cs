// Задача 38 // Задайте массив вещественных чисел. 
//нАйдите разницу между максимальным и минимальным элементом массива.

// int[] myArray = generateRandomIntArray(5, -100, 100);
// Console.WriteLine("Сгенерированный массив: ");
// printArray(myArray);
// Console.WriteLine();

// int minValue = myArray[0];
// int maxValue = myArray[0];

// for (int index = 0; index < myArray.Length; index++) 
// {
//     if(myArray[index] < minValue)
//     {
//         minValue = myArray[index];
//     } else if (myArray[index] > maxValue)
//     {
//         maxValue = myArray[index];
//     }
//  }

//  Console.WriteLine("Разница между минимальным(" + minValue + ") и максимальным(" + maxValue + ") значениями: " + (maxValue - minValue));

// int[] generateRandomIntArray(int capacity, int minValue, int maxValue)
// {
//     int[] myArray = new int[capacity];
//     for(int i = 0; i < myArray.Length; i++) {
//          myArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return myArray;
// }


// void printArray(int[] array) {
//     for(int i = 0; i < array.Length; i++) {
//         Console.Write(array[i] + " ");
//     }
// } 


// Задача 34 //
//Задайте массиB заполненный случайными трехзначными случайными числами( дли на массива 5 эл-тов), Напишите программу, колтора покажет колисество чет ных числел в массиве//

// int[] myArray = generateRandomIntArray(5, 100, 199);
// Console.WriteLine("Сгенерированный массив: ");
// printArray(myArray);
// Console.WriteLine();
// int minValue = myArray[0];
// int maxValue = myArray[0];
// printArray(myArray);

// int sunEven = myArray[0];


// int[] generateRandomIntArray(int capacity, int minValue, int maxValue)
// {
//     int[] myArray = new int[capacity];
//     for(int index = 0; index < myArray.Length; index++)
//     {
//         myArray[index] = new Random().Next(minValue, maxValue);
//     }
//     return myArray;
// }

// void printArray(int[] myArray)
// {
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         Console.Write(myArray[i] + " ");
//     }
// }

// int[] getEvenNumbers(int capacity, int sumEven)
// {
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         if(myArray/2 == 0)
//             {
//                 sumEven = sumEven + 1;
//             }
//         else {
//         i++;
//         }
//     }
// }
// void printArray(int[] myArray)
// {
//     for(int i = 0; i < myArray.Length; i++)
//     {
//         Console.Write("Количнсктво четных чисел: " + getEvenNumbers);
//     }
// }

//========================================================================================================================

// домашнее задание семинар 4//
//зАДАЧА 25//Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
//3, 5 -> 243 (3⁵)

// Console.WriteLine("Введите первое число: ");
// string text1 = Console.ReadLine();
// int a = Convert.ToInt32(text1);

// Console.WriteLine("Введите второе  число: ");
// string text2 = Console.ReadLine();
// int b = Convert.ToInt32(text2);

// double result = Math.Pow(a, b);
// Console.WriteLine(result);

//Задача 27// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11

// Console.WriteLine("Введите число: ");
// string text = Console.ReadLine();
// int number = Convert.ToInt32(text);
// int tmp = number;
// int sum = 0;
// int index = 0;

// while(tmp > 0)
// {
//    int ost = tmp % 10;
//    sum = sum + ost;
//    tmp = (int) (number / Math.Pow(10, ++index));
// }
// Console.WriteLine(sum);

// Задача 29: Напишите программу, которая задаёт массив из 8 элементов (от -10 до 10) и выводит их на экран.
// 1, 2, 5, 7, 9 -> [1, 2, 5, 7, 9]


// int[] myArray = new int[8];

// for(int i = 0; i < myArray.Length; i++)
// {
//     myArray[i] = new Random().Next(-10, 10);
//     Console.Write("[ "+ myArray[i] + " ]");
// }
// Console.WriteLine();
//==================================================================================================================

//сЕМИНАР 5// ДОмашнее задание//

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

// int[] myArray = new int[5];
// myArray = generateRandomIntArray(myArray, 100, 999);
// Console.WriteLine("Случайное трехзначное число: ");
// printMyArray(myArray);
// Console.WriteLine();
// int count = 0;

// int minValue = myArray[0];
// int maxValue = myArray[0];


// int[] generateRandomIntArray (int[] myArray, int minValue, int maxValue)
// {
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(minValue, maxValue);
//     }
//     return myArray;
// }
// Console.WriteLine();

// for (int i = 0; i < myArray.Length; i++)
//     {
//     if (myArray[i] % 2 == 0)
//         {
//             count++;
//         }
//     }
// Console.WriteLine("Количество четных чисел: => " + count);

// void printMyArray(int[] myArray)
// {
//     for (int i = 0; i <  myArray.Length; i++)
//             {
//                 Console.Write(myArray[i] + " ");
//             } 
// }


// //====================================================

//Задача 36: Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).
//[3, 7, 23, 12] -> 19

// int[] myArray = new int[5];
// myArray = generateRandomIntArray(myArray);
// Console.WriteLine("Случайные числа: ");
// printMyArray(myArray);
// int sum = 0;

// int[] generateRandomIntArray (int[] myArray)
// {
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(1, 100);
//     }
//     return myArray;
// }
// Console.WriteLine();

// void printMyArray(int[] myArray)
// {
//     for (int i = 0; i <  myArray.Length; i++)
//         {
//             Console.Write(myArray[i] + " ");
//         } 
// }

// for (int i = 1; i < myArray.Length; i = i + 2)
//     {
            
//         sum+= myArray[i];
//     }

// Console.WriteLine("Сумма чисел нечетного массива: => " + sum);

//====================================================================//

//Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

// double[] myArray = new double[5];

// for (int i = 0; i < myArray.Length; i++)
// {
//     double number = new Random().Next(-100, 100) + new Random().NextDouble();
//     myArray[i] = Math.Round(number, 2);
// }

// for (int i = 0; i <  myArray.Length; i++)
// {
//     Console.Write(myArray[i] + " | ");
// }   
// Console.WriteLine();

// double minElements = myArray[0];
// double maxElements = myArray[0];

// for (int i = 0; i <  myArray.Length; i++)
// {


//     if (minElements > myArray[i]) 
//         {  
//             minElements = myArray[i]; 

//         } else {
        
//     if (maxElements < myArray[i]) 
//     {
//          maxElements = myArray[i]; }
 
//     }
// }
// Console.WriteLine();

// Console.WriteLine("Разница между минимальным: " + minElements + "  и максимальным: " + maxElements+ " значениями: " + (maxElements - minElements));

//Доп. задачи//
//Задача 3: Задайте массив из 8 случайных чисел из промежутка [-9, 9]. 
// Напишите программу получает на вход число и определяет, присутствует ли заданное число в массиве.
//4; массив [6, 7, 19, 345, 3] -> нет

// int[] myArray = new int[8];
// myArray = generateRandomIntArray(myArray);
// Console.WriteLine("Случайные числа: ");
// printMyArray(myArray);
// Console.WriteLine();

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());
// int count = 0;



// int[] generateRandomIntArray (int[] myArray)
// {
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(-9, 9);
//     }
//     return myArray;
// }

// void printMyArray(int[] myArray)
// {
//     for (int i = 0; i <  myArray.Length; i++)
//         {
//             Console.Write(" |" + myArray[i] + "| ");
//         } 
// }

// for (int i = 0; i < myArray.Length; i++)
// {
//     if(number == myArray[i]) { count++; }
// }

// if(count > 0) { Console.WriteLine("Число присутствует в массиве"); }
// else { Console.WriteLine("Нет таких чисел"); }



//Задача 4: Задайте массив из 10 случайных чисел из промежутка [-100, 100]. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
//Пример для массива из 5, а не 10 элементов. В своём решении сделайте для 10
//[5, 18, 123, 6, 2] -> 1

// int[] myArray = new int[10];
// myArray = generateRandomIntArray(myArray);
// Console.WriteLine("Случайные числа: ");
// printMyArray(myArray);
// Console.WriteLine();

// int countMass = 0;
// int[] generateRandomIntArray (int[] myArray)
// {
//     for (int i = 0; i < myArray.Length; i++)
//     {
//         myArray[i] = new Random().Next(-100, 100);
//     }
//     return myArray;
// }

// void printMyArray(int[] myArray)
// {
//     for (int i = 0; i <  myArray.Length; i++)
//         {
//             Console.Write(" |" + myArray[i] + "| ");
//         } 
// }
// Console.WriteLine();

// for (int i = 0; i <  myArray.Length; i++)
// {
//     if (myArray[i] > 10 && myArray[i] < 100)
//     {
//         countMass++;
//     }
// }
// Console.WriteLine("Элементов в отрезке: " + countMass);

// Домашняя работа к семинару 6//
// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2

// Console.WriteLine("Введите количество чисел: ");
// int arraySize = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите числа: ");

// int[] myArray = new int[arraySize];
// int result = 0;

// for (int i = 0; i <  myArray.Length; i++)
// {
//     myArray[i]= int.Parse(Console.ReadLine());
// }

// for (int i = 0; i < myArray.Length; i++)
// {
//      if(myArray[i] > 0) 
//      { 
//         result++;
//      }
// }
//  Console.WriteLine("Количество положительных чисел:  "+ result);




// Задача 43: Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями  
// значения b1, k1, b2 и k2 задаются пользователем.

// Console.WriteLine("Введите k1: ");
// int k1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите b1: ");
// int b1 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите k2: ");
// int k2 = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите b2: ");
// int b2 = int.Parse(Console.ReadLine());
// Console.WriteLine();

// double kx = k1 - k2;
// double bx = b2 - b1;
// double x = bx / kx;

// double y = k1 * x + b1;

// Console.WriteLine("точка пересечения: " + (x, y));


//семинар от 16 мая//

// int[,] arr = new int[2,3];

// for(int i = 0; i < arr.GetLength(0); i++)
//     {
//     for(int j = 0; j < arr.GetLength(1); j++)
//     {
//         arr[i,j] = new Random().Next(0,10);
//         Console.Write(arr[i,j]);
//     }
//     Console.WriteLine();

// }
