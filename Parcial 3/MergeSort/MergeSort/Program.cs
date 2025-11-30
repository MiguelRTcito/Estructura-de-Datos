using System;

public class MergeSort //merge sort en C#
{
    public static void MergeSortArray(int[] array)
    {
        if (array.Length <= 1)
            return;

        int mid = array.Length / 2;

        int[] left = new int[mid];
        int[] right = new int[array.Length - mid];

        // Llenar left
        for (int i = 0; i < mid; i++)
            left[i] = array[i];

        // Llenar right
        for (int j = mid; j < array.Length; j++)
            right[j - mid] = array[j];

        // Recursión
        MergeSortArray(left);
        MergeSortArray(right);

        // Mezclar
        int leftIndex = 0, rightIndex = 0, mergedIndex = 0;

        // Mientras haya elementos en ambos subarreglos
        while (leftIndex < left.Length && rightIndex < right.Length)
        {
            if (left[leftIndex] <= right[rightIndex])
            {
                array[mergedIndex] = left[leftIndex];
                leftIndex++;
            }
            else
            {
                array[mergedIndex] = right[rightIndex];
                rightIndex++;
            }

            mergedIndex++;
        }

        // Copiar lo que queda en left (si queda)
        while (leftIndex < left.Length)
        {
            array[mergedIndex] = left[leftIndex];
            leftIndex++;
            mergedIndex++;
        }

        // Copiar lo que queda en right (si queda)
        while (rightIndex < right.Length)
        {
            array[mergedIndex] = right[rightIndex];
            rightIndex++;
            mergedIndex++;
        }
    }
public static void Main(string[] args)
{
    Console.Write("¿Cuántos valores deseas ingresar? ");
    int n = int.Parse(Console.ReadLine());

    int[] array = new int[n];

    Console.WriteLine("\nIngresa los valores:");
    for (int i = 0; i < n; i++)
    {
        Console.Write($"Valor {i + 1}: ");
        array[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("\nOrdenando el arreglo con MergeSort...\n");

    MergeSort.MergeSortArray(array);

    Console.WriteLine("Arreglo ordenado:");
    Console.WriteLine(string.Join(", ", array));

    Console.ReadKey();
}


}