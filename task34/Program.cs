// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами (длина массива 5 элементов). 
// Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

Console.Write("массив из 5 трехзначных чисел:  ");
int[] randomArray = new int[5];

for (int i = 0; i < randomArray.Length; i++)
    {
        randomArray[i] = new Random().Next(100,1000);
        Console.Write(randomArray[i] + " ");
    }
int count = 0;
for (int x = 0; x < randomArray.Length; x++)
    {
        if (randomArray[x] % 2 == 0)
        count++;
    }
Console.WriteLine($"количество чётных чисел в массиве:  {count}");

