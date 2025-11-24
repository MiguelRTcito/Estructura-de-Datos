using System;

public class QuickSort
{
    public static void QuickSortArray(int[] array, int pivotIndex)
    {
        if (array.Length <= 1)
            return;

        int piv = array[pivotIndex]; // Valor del pivote

        int leftCount = 0;
        int rightCount = 0;

        // Contar cuantos van a left o right para dimensionar los arreglos
        for (int i = 0; i < array.Length; i++)
        {
            if (i == pivotIndex)
                continue; // Saltar el pivote

            if (array[i] < piv)
                leftCount++;
            else
                rightCount++;
        }

        // Crear subarreglos para left y right en los cuales se guardarán los valores correspondientes
        int[] left = new int[leftCount];
        int[] right = new int[rightCount];

        int l = 0, r = 0;

        // Llenar left y right
        for (int i = 0; i < array.Length; i++)
        {
            if (i == pivotIndex)
                continue;

            if (array[i] < piv)
                left[l++] = array[i];
            else
                right[r++] = array[i];
        }

        // Recursión
        QuickSortArray(left, left.Length > 0 ? 0 : 0);
        QuickSortArray(right, right.Length > 0 ? 0 : 0);

        // Reconstruir resultado en array original
        int index = 0;

        for (int i = 0; i < left.Length; i++)
            array[index++] = left[i];

        array[index++] = piv;

        for (int i = 0; i < right.Length; i++)
            array[index++] = right[i];
    }

    public static void Main(string[] args)
    {
        Console.Write("¿Cuántos valores deseas ingresar? ");
        int n = int.Parse(Console.ReadLine());

        int[] array = new int[n];

        Console.WriteLine("\nEscribe los valores:");
        for (int i = 0; i < n; i++)
        {
            Console.Write($"Valor {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }

        Console.Write("\nElige la posición del pivote (0 a " + (n - 1) + "): ");
        int pivotIndex = int.Parse(Console.ReadLine());

        Console.WriteLine("\nOrdenando...\n");

        QuickSortArray(array, pivotIndex);

        Console.WriteLine("Arreglo ordenado:");
        Console.WriteLine(string.Join(", ", array));

        Console.ReadKey();
    }
}
