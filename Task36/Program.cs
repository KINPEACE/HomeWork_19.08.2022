/* Задайте одномерный массив, заполненный случайными числами. 
Найдите суму элементов, состоящих на нечетных позициях.*/

Console.Write("Введите колличество элементов массива: ");
int numbers = Convert.ToInt32(Console.ReadLine());
int RandomNumbers(int numbers, int minValue, int maxValue)
{
    int[] random = new int[numbers];
    int summa = 0;
    Console.Write("Рандомный массив: ");
    for(int i = 0; i < random.Length; i++)
    {
        random[i] = new Random().Next(minValue, maxValue);
        Console.Write(random[i] + " ");
        if(i % 2 != 1)
        {
            summa = summa + random[i];
        }
    }
    return summa;
}

int random = RandomNumbers(numbers, 1, 10);
Console.WriteLine();
Console.WriteLine($"Сумма элементов, стоящих на нечетных позициях: {random}");