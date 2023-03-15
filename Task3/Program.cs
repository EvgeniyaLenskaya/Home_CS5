// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76


double[]  myArray= GetArray (10,0,100);
double[] GetArray (int size, int min, int max)
{
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(new Random().NextDouble() *100, 2 );
    }
    return array;
}
Console.WriteLine ($"[{String.Join("; ", myArray)}]");

double min = myArray[0];
double max = myArray[0];

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] < min)
    {
        min = myArray[i];
    }
}
Console.WriteLine ($"Минимальное число в массиве: {min}");

for (int i = 0; i < myArray.Length; i++)
{
    if (myArray[i] > max)
    {
        max = myArray[i];
    }
}
Console.WriteLine ($"Максимальное число в массиве: {max}");
Console.WriteLine ($"Разность между максимальным и минимальным числами в массиве: {max - min}");

