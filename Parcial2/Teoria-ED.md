# Estructura de datos

Un tipo de **dato abstracto** es un modelo que define un conjunto de datos y las operaciones que estos pueden generar.
Sus clasificaciones mas comunes son:

- Pilas
- Colas
- Listas: enlazadas y doblemente enlazadas

## Pilas
Estructura de datos que sigue el principio LIFO. Donde las operaciones tipicas son **push** agregar elemento y 
**push** eliminar elemento.

```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Pila de enteros
        Stack<int> pila = new Stack<int>();

        // Agregar elementos (Push)
        pila.Push(10);
        pila.Push(20);
        pila.Push(30);

        Console.WriteLine("Contenido actual de la pila:");
        foreach (int elemento in pila)
        {
            Console.WriteLine(elemento);
        }

        // Consultar el elemento superior (Peek)
        Console.WriteLine($"\nElemento en la cima: {pila.Peek()}");

        // Eliminar el elemento superior (Pop)
        pila.Pop();

        Console.WriteLine("\nPila después de eliminar un elemento:");
        foreach (int elemento in pila)
        {
            Console.WriteLine(elemento);
        }
    }
}```