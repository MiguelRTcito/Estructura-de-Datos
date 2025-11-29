using System;

public class Inserccion
{
    public void Agregar(int[] array)
    {
        for (int i = 1; i < array.Length; i++)
        {
            int llave = array[i];
            int j = i - 1;

            while (j >= 0 && array[j] > llave)
            {
                array[j + 1] = array[j];
                j--;
            }

            array[j + 1] = llave;
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
            Inserccion insercion = new Inserccion();
            int[] array = arreglo;
            Console.WriteLine("Array original: " + string.Join(", ", array));
            insercion.Agregar(array);
            Console.WriteLine("Array ordenado: " + string.Join(", ", array));
            Console.ReadKey();
        }
    }
}
