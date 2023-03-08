// ... которая задает массив из 8 элементов и выводит их а экран

//int[] array = new Random[8];
//Console.WriteLine(array);

int[] array = new int[8];

for (int index = 0; index < 8; index++) {
    array[index] = new Random().Next();
    Console.WriteLine(array[index]);
}

