// See https://aka.ms/new-console-template for more information
Console.WriteLine("Task54");

/*Задача 54: Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
7 4 2 1
9 5 3 2
8 4 4 2*/

int[,] generateArray(int N, int M){
    Random random = new Random();
    int[,] myArray = new int[N, M];
    for(int i=0; i<N; i++){
        for(int j=0; j<M; j++){
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
}

int[,] sort2D(int[,] inArray){
    for(int i=0; i<inArray.GetLength(0); i++){
        int swaps = 1;
        while (swaps>0) {
            swaps = 0;
            for(int j=0; j<(inArray.GetLength(1)-1); j++){
                if (inArray[i,j]<inArray[i,j+1]){
                    int tmp = inArray[i,j];
                    inArray[i,j] = inArray[i,j+1];
                    inArray[i,j+1] = tmp;
                    swaps++;
                }
            }
        }
    }
    return inArray;
}

int[,] newArray = generateArray(3, 4);
printArray(newArray);
Console.WriteLine();
printArray(sort2D(newArray));