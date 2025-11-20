using System;

public class Ordenamiento
{
    public void Burbuja(int[] arreglo)
    {
        int n = arreglo.Length;

        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arreglo[j] > arreglo[j + 1])
                {
                    int temp = arreglo[j];
                    arreglo[j] = arreglo[j + 1];
                    arreglo[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Arreglo ordenado:");
        foreach (int num in arreglo)
        {
            Console.Write(num + " ");
        }
    }
}

class Program
{
    static void Main()
    {
        Console.Write("Ingrese el tamaño del arreglo: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int[] arreglo = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Ingrese el valor del elemento {i + 1}: ");
            arreglo[i] = Convert.ToInt32(Console.ReadLine());
        }

        Ordenamiento ord = new Ordenamiento();
        ord.Burbuja(arreglo);

        Console.WriteLine();
        Console.ReadKey();
    }
}
