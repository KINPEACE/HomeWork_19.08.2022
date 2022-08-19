/* Задайте массив вещественных чисел.
Найдите разницу между максимальным и минимальным элементов массива.*/

double[] Num = new double[10];
for(int i = 0; i < Num.Length; i++)
{
    Num[i] = new Random().Next(1, 10);
    Console.Write(Num[i] + " ");
}
Console.WriteLine();

double Max = Num[0];
double Min = Num[0];

for(int i =1; i < Num.Length; i++)
{
    if(Max < Num[i])
    {
        Max = Num[i];
    }
    if(Min > Num[i])
    {
        Min = Num[i];
    }
}

double Diff = Max - Min;
Console.WriteLine($"Разница между: Max ({Max}) и Min ({Min}) = {Diff}");