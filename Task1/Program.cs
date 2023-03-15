// Задача 34: Задайте массив заполненный случайными 
// положительными трёхзначными числами. 
// Напишите программу, которая покажет 
// количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] resArr = NewArray(10, 100, 999);
Console.WriteLine($"[ {String.Join("; ", resArr)} ]");
int[] NewArray(int size, int min, int max)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = new Random().Next(min, max+1);
    }
    return array;
}
int count = 0;
for (int i = 0; i < resArr.Length; i++)
{
    if(resArr[i]%2==0)
    {
        count++;
    }
}
Console.WriteLine($"В этом массиве найдено {count} чётных чисел");
