// Задача 34: Задайте массив, заполненный случайными положительными трехзначными числами. Напишите программу, которая покажет кол-во четных чисел в массиве.

int capacity = 5;
int minValue = 100;
int maxValue = 999;

int[] myArray = generateRandomIntArray(capacity, minValue, maxValue);
int count = 0;
for (int index = 0; index < capacity; index++) {
    Console.WriteLine("Сгенерированный массив: " + myArray[index]);                       
    if (checkEvenNumber(myArray[index])) {
        count++;
    }
}

Console.WriteLine("Количество четных чисел: " + count);                       
 
int[] generateRandomIntArray(int capacity, int minValue, int maxValue)
{
    int[] myArray = new int[capacity];
    for (int i = 0; i < capacity; i++)
    {
        myArray[i] = new Random().Next(minValue, maxValue);
    }
    return myArray;
}

bool checkEvenNumber(int number) {
    bool result = false;
    if (number % 2 == 0) {
         result = true;
    }
    return result;
}










