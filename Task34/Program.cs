/* Задайте массив заполненый случайными положительными трехзначными числами.
Напишите программу, которая покажет колличество четных чисел в массиве.*/

int[] numbers = new int[10];
void Array(int[] array, int minValue, int maxValue)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(minValue, maxValue);
    }
}

void WriteArray(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
    Console.WriteLine(); 
}
int PositiveNum(int[] array)
{
    int positive = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(array[i] % 2 == 1)
        {
            positive++;
        }
    }
    return positive;
}
Array(numbers, 100, 1000);
WriteArray(numbers);
Console.WriteLine();
int positive = PositiveNum(numbers);
Console.WriteLine($"Колличество Четных чисел в массиве: {positive}");