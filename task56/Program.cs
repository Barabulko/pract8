// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task56");

/*Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.

Например, задан массив:

1 4 7 2

5 9 2 3

8 4 2 4

5 2 6 7

Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка*/

int[,] generateArray(int N){
    Random random = new Random();
    int[,] myArray = new int[N, N];
    for(int i=0; i<N; i++){
        for(int j=0; j<N; j++){
            myArray[i,j] = random.Next(10);
        }
    }
    return myArray;
}

void printArray(int[,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

int summString(int[,] array, int strNumber){
    int summ = 0;
    for(int j=0; j<array.GetLength(1); j++){
        summ+=array[strNumber, j];
    }
    return summ;
}

int findMin(int[,] array){
    int imin = 0;
    int min = summString(array, 0);
    for(int i=1; i<array.GetLength(0); i++){
        int summ = summString(array, i);
        if(summ<min){
             min = summ;
             imin = i;
        }
    }
    return imin;
}

int[,] myArray = generateArray(4);
printArray(myArray);
Console.WriteLine($"smallest line = {findMin(myArray)}");