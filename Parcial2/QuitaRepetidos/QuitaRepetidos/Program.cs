using System;
using System.Runtime.CompilerServices;

namespace QuitaRepetidos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese una cadena de texto:");
            string cadena = Console.ReadLine();

            Cola cola = new Cola(cadena.Length);

            foreach (char c in cadena)
            {
                cola.Agregar((int)c); // Agregar el valor ASCII del carácter a la cola
            }
            string resultado = QuitarRepetidos(cola);
            Console.WriteLine("Cadena sin caracteres repetidos:");
            Console.WriteLine(resultado);
            Console.ReadKey();
        }
        static string QuitarRepetidos(Cola cola)
        {
           string resultado = "";
              while (!cola.EstaVacia())
              {
                int num = cola.Eliminar();
                if (!resultado.Contains((char)num))
                {
                     resultado += (char)num;
                }
            }
              return resultado;
        }
    }
}
