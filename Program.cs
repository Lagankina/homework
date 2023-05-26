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
//ДОМАШНЕ ЗАДАНИЕ СЕМИНАР 7//
// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами от -10,0 до 10,0.

// Console.WriteLine("Введите ширину таблицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длину таблицы: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();

// double[,] myArrayTab = new double[m, n];
// for(int i = 0; i < myArrayTab.GetLength(0); i++)
// {
//     for(int j = 0; j < myArrayTab.GetLength(1); j++)
//     {
//         myArrayTab[i,j] = new Random().Next(-10, 11) + new Random().NextDouble();
//         myArrayTab[i,j] = Math.Round(myArrayTab[i,j], 2);
//         Console.Write(" |" + myArrayTab[i, j] + "|"); 
//     }
//     Console.WriteLine();
// }

//Задача 50. Напишите программу, которая на вход принимает число, и возвращает индексы числа в двумерном массиве или же указание, что такого элемента нет.

// Console.WriteLine("Введите ширину таблицы: ");
// int m = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите длину таблицы: ");
// int n = int.Parse(Console.ReadLine());
// Console.WriteLine();
// int count = 0;

// int[,] myArrayTab = new int[m, n];
// for(int i = 0; i < myArrayTab.GetLength(0); i++)
// {
//     for(int j = 0; j < myArrayTab.GetLength(1); j++)
//     {
//         myArrayTab[i,j] = new Random().Next(0, 100);
//         Console.Write(" |" + myArrayTab[i, j] + "|"); 

//     }
//     Console.WriteLine();
// }
// Console.WriteLine();

// Console.WriteLine("Введите число: ");
// int number = int.Parse(Console.ReadLine());

// for(int i = 0; i < myArrayTab.GetLength(0); i++)
// {
//     for(int j = 0; j < myArrayTab.GetLength(1); j++)
//     {
//         if(number == myArrayTab[i,j])
//         {
//             count++;
//         } 
//     }    
// }
// if(count > 0) { Console.WriteLine("Число присутствует в массиве"); }
// else { Console.WriteLine("Нет таких чисел"); }

// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Console.WriteLine("Введите количество столбцов: ");
// int columns = int.Parse(Console.ReadLine());
// Console.WriteLine("Введите количество строк: ");
// int lines = int.Parse(Console.ReadLine());
// Console.WriteLine();

// float[] sums = new float[columns];
// int[,] myArrayTab = new int[lines, columns];

// for(int rowIndex = 0; rowIndex < myArrayTab.GetLength(0); rowIndex++)
// {
//     Console.Write("| "); 
//     for(int columnIndex = 0; columnIndex < myArrayTab.GetLength(1); columnIndex++)
//     {
//         myArrayTab[rowIndex, columnIndex] = new Random().Next(0, 10);
//         sums[columnIndex] += myArrayTab[rowIndex, columnIndex];
//         Console.Write(myArrayTab[rowIndex, columnIndex] + " "); 
//     }
//     Console.WriteLine("|");
// }
// Console.WriteLine();

// for(int index = 0; index < sums.Length; index++)
// {
//     Console.Write(" | " + sums[index] / lines + " | ");
// }

//Домашнее задание семинар 8//
// Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2
Console.WriteLine("Введите ширину таблицы: ");
int rows = int.Parse(Console.ReadLine());
Console.WriteLine("Введите длину таблицы: ");
int columns = int.Parse(Console.ReadLine());
Console.WriteLine();

int[,] array = GetArray(rows, columns, 0, 4);
printArray(array);
NumberIncrease(array);
Console.WriteLine();
printArray(array);

void printArray(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j]);
        }    
    }
}
Console.WriteLine();

int[,] GetArray(int m, int n, int min, int max)
{
    int[,] result = new int [m, n];
    for(int i = 0; i < m; i++)
    {
        for(int j = 0; j < n; j++)
        {
            result[i,j] = new Random().Next(min, max + 1);
        }    
        return result;
    }

}
void NumberIncrease(int[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        Console.WriteLine();
        for(int j = 0; j < array.GetLength(1); j++)
        {
            for(int k = 0; k < array.GetLength(1) - 1; k++)
            {
                if(array[i, k] < array[i, k + 1])
                {
                    int memory = array[i, k + 1];
                    array[i, k + 1] = array[i, k];
                    array[i, k] = memory;
                }
            }
        }    
    }
}


// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка

// Задача 58: Задайте два двумерных массива (от 0 до 10). Напишите программу, которая будет находить произведение двух массивов (поэлементное).
// Например, даны 2 массива:
// 2 4
// 3 2

// 3 4
// 3 3
// Результирующая матрица будет:
// 6 16
// 9 6

// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)

// Доп.Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

// Домашнее задание семинар 9//

// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.

// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

