// Задача 38: Задайте массив вещественных чисел от -100 до 100 (длина массива 5 элементов). 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


Console.Write("массив вещественных чисел: ");

double[] numbers = new double[5];
FillArrayRandomNumbers(numbers);
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
}

void PrintArray(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write( numbers[i] + " ");
        }
    Console.WriteLine();
}
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int z = 0; z < numbers.Length; z++)
{
    if (numbers[z] > max)
        {
            max = numbers[z];
        }
    if (numbers[z] < min)
        {
            min = numbers[z];
        }
}

Console.WriteLine ($"максимальное значение:  {max}");
Console.WriteLine ($"минимальное значение:  {min}");
Console.WriteLine ($"разница между максимальным и минимальным значением:  {max - min}");

