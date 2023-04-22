// See https://aka.ms/new-console-template for more information
Console.WriteLine("task58");

/*Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
Например, даны 2 матрицы:
2 4 | 3 4
3 2 | 3 3
Результирующая матрица будет:
18 20
15 18*/

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
    Console.WriteLine();
}

int[] getVector(int[,] array, int index, int horizontal){
    int[] vector = new int[array.GetLength(horizontal)];
    for(int i=0; i<vector.Length; i++){
        if (horizontal==0) {
            vector[i] = array[i, index];
        } else {
            vector[i] = array[index, i];
        } 
    }
    return vector;
}

int vectorMultiply(int[] A, int[] B){
    int summ = 0;
    for(int i=0; i<A.Length; i++){
        summ+=A[i]*B[i];
    }
    return summ;
}

int[,] matrixMultiply(int[,] A, int[,] B){
    if(A.GetLength(1)!=B.GetLength(0)){
        Console.WriteLine("Wrong input");
        int[,] error = new int[1,1];
        return error;
    }
    
    int[,] C = new int[A.GetLength(0), B.GetLength(1)];
    for (int i=0; i<C.GetLength(0); i++){
        for (int j=0; j<C.GetLength(1); j++){
            C[i,j] = vectorMultiply(getVector(A,i,1), getVector(B,j,0));
        }
    }
    return C;
}

int[,] A = generateArray(2,3);
int[,] B = generateArray(3,4);

printArray(A);
printArray(B);

int[,] C = matrixMultiply(A,B);

printArray(C);