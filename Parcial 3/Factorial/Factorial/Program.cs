using System;

public class Recurisividad //Factorial
{
    public static int Factorial(int n)
    {
        int res = 1;
        for(int i = 2; i <= n; i++)
        {
            res = res * i;
        }
        return res;
    }

    public static void Main(string[] args)
    {
        Console.Write("Ingrese el valor: ");
        int n = int.Parse(Console.ReadLine());
        int resultado = Factorial(n);
        Console.WriteLine("El factorial de " + n + " es: " + resultado);
        Console.ReadKey();
    }
}