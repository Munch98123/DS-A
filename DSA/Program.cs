// See https://aka.ms/new-console-template for more information
using DSA.Algorithms;

Console.WriteLine("Hello, World!");

//QuickSort Method
int[] array = { 11, 6, 3, 8, 2, 9, 4, 7 };

QuickSort.QS(array, 0, array.Length - 1);

foreach (int i in array)
{
    Console.WriteLine($"{i}, ");
}

array = [11, 6, 3, 8, 2, 9, 4, 7];

MergeSort.Sort(array, 0, array.Length - 1);

foreach (int i in array)
{
    Console.WriteLine($"{i}, ");
}