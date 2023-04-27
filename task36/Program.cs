// Задача 36: Задайте одномерный массив, заполненный случайными числами (длина массива 5 элементов). Найдите сумму элементов, стоящих на нечётных индексах (индексы с нуля).

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

Console.Write("массив из четырех чисел:  ");
int[] numbers = new int[4];

for (int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(-100,100);
        Console.Write(numbers[i] + " ");
    }
    Console.WriteLine();

int sum = 0;

for (int x = 1; x < numbers.Length; x+=2)
    {
        sum = sum + numbers[x];
    }
    Console.Write($"сумма элементов на нечётных позициях равна: {sum}");

