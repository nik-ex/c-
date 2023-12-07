// Задача 2: Задайте массив заполненный случайными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

int[] array = new int[10];
for (int i = 0; i < array.Length; i++)
{
    array[i] = new Random().Next(100, 999);
    Console.Write($"{array[i],4}");
}
Console.WriteLine();

int count = 0;
for (int i = 0; i < array.Length; i++)
{
    if (array[i]%2==0)
        count++;
}
System.Console.WriteLine();
System.Console.WriteLine(count);