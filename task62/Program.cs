// See https://aka.ms/new-console-template for more information
Console.WriteLine("task62");

/*Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
Например, на выходе получается вот такой массив:
01 02 03 04
12 13 14 05
11 16 15 06
10 09 08 07*/

int[,] easyWay(){
    int[,] myArray = new int[4,4];
    myArray[0,0] = 1;
    myArray[0,1] = 2;
    myArray[0,2] = 3;
    myArray[0,3] = 4;
    myArray[1,3] = 5;
    myArray[2,3] = 6;
    myArray[3,3] = 7;
    myArray[3,2] = 8;
    myArray[3,1] = 9;
    myArray[3,0] = 10;
    myArray[2,0] = 11;
    myArray[1,0] = 12;
    myArray[1,1] = 13;
    myArray[1,2] = 14;
    myArray[2,2] = 15;
    myArray[2,1] = 16;
        
    return myArray;
}

int[,] adequateWay(int n=4)        
{
    int[,] result = new int[n, n];
    int num = 1;
    for (int layer=0; layer<n/2; layer++){
        for (int j=layer; j<n-layer; j++){
            result[layer, j] = num;
            num++;
        }
        for (int i=layer+1; i<n-layer; i++){
            result[i, n-layer-1] = num;
            num++;
        }
        for (int j=n-layer-2; j>=layer; j--){
            result[n-layer-1, j] = num;
            num++;
        }
        for (int i=n-layer-2; i>layer; i--){
            result[i, layer] = num;
            num++;
        }
    }
    return result;
}

void printArray(int[,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            Console.Write($"{array[i,j]:d02} ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
}

printArray(easyWay());
printArray(adequateWay(6));