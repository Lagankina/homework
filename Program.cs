// Задание 36: Задайте одномерный массив, заполненный случайнми числами. Найдите сумму эл-тов, стоящих на нечетных позициях.

int capacity = 7;
int minValue = 1;
int maxValue = 18;

int[] myArray = generateRandomIntArray(capacity, minValue, maxValue);
int sum = 0;
for (int index = 0; index < capacity; index++) {
    Console.WriteLine("Сгенерированный массив: " + myArray[index]);                       
    if (!checkEvenNumber(index)) {
        sum += myArray[index];
    }
}
Console.WriteLine("Сумма элементов нечетных позиций: " +  sum);

// #################################################################

bool checkEvenNumber(int number) {
    bool result = false;
    if (number % 2 == 0) {
         result = true;
    }
    return result;
}

int[] generateRandomIntArray(int capacity, int minValue, int maxValue)
{
    int[] myArray = new int[capacity];
    for (int i = 0; i < capacity; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue);
    }
    return myArray;
}

//Задайте массив вещественныйх чисел. Найдите разницу между  максимальным и минимальным элементом массива

// int[] myArray = new int[5] {3, 9, 2, 8, 14};

// int MinMaxSort(int Length, int minValue, int maxValue) {
//     for (int index = 0; index < maxValue; index++) {
//         for(int j = i + 1; j < minValue; j++) {
//             if(i > j) {
//                 i = maxValue;
//                 Console.WriteLine(maxValue);
//                 i++;
//             }
//             else
//              {
//                 j = minValue;
//                 Console.WriteLine(minValue);
//                 j++;
//             }
//             Console.WriteLine(MinMaxSort);
//         }
//     Console.WriteLine();
//     }
// }