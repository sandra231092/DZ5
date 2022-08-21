//Задайте массив вещественных чисел. Найдите разницу между максимальным 
//и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double [] array = { 8, 5, 4, 10, 2, 6, 7, 3, 2 };
double min = array[0];
double max = 0;
double res = 0;

for (int i = 0; i < array.Length; i++)
{
    if (array[i] > max)
    {
        max = array[i];
    }
    if (array[i] < min)
    {
        min = array[i];
    }
}

res = max - min;

Console.WriteLine(string.Join(",", array));
Console.WriteLine($"Разница между максимальным и минимальным значением равна {res}");
