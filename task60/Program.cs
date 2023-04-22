// See https://aka.ms/new-console-template for more information
Console.WriteLine("task60");

/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)*/

Boolean checkNewNumber(int[] usedNumbers, int number){
    for(int i=0; i<usedNumbers.Length; i++){
        if (number==usedNumbers[i]){
            return false;
        }
    }
    return true;
}

int[,,] generateArray(int N, int M, int O){
    Random random = new Random();
    int[,,] myArray = new int[N, M, O];
    List<int> usedNumbers = new List<int>();
    for(int i=0; i<N; i++){
        for(int j=0; j<M; j++){
            for(int k=0; k<O; k++){
                while (true) {
                    int newNumber = random.Next(100);
                    if (checkNewNumber(usedNumbers.ToArray(), newNumber)) {
                        myArray[i,j,k] = newNumber;
                        usedNumbers.Add(newNumber);
                        break;
                    }
                }
            }
        }
    }
    return myArray;
}

void printArray(int[,,] array){
    for(int i=0; i<array.GetLength(0); i++){
        for(int j=0; j<array.GetLength(1); j++){
            for(int k=0; k<array.GetLength(2); k++){
                Console.Write($"{array[i,j, k]} ({i}, {j}, {k}) ");
            }
            Console.WriteLine();
        }
    }
    Console.WriteLine();
}

int[,,] myArray = generateArray(2,2,2);
printArray(myArray);