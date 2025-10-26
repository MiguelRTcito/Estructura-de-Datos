# Estructura de datos

Una estructura de datos es una forma organizada de almacenar y gestionar información dentro de un programa para que pueda ser utilizada de manera eficiente.
Un tipo de dato abstracto (TDA) define un conjunto de datos y las operaciones que se pueden realizar sobre ellos, sin preocuparse por cómo están implementados internamente.

## Clasificación de las estructuras de datos

## Lineales
Los datos se organizan de manera secuencial, donde cada elemento tiene un predecesor y un sucesor (excepto el primero y el último).

- **Arreglos** 
- **Pilas**
- **Colas**
- **Listas enlazadas**

## Arreglos
Un arreglo (array) es una colección de elementos del mismo tipo, almacenados de forma contigua en memoria.
Los elementos se acceden mediante índices.

- **Unidimensional (vector/array)**
 Es una estructura de datos que almacena una colección ordenada de elementos del mismo tipo, accesibles a través de un solo índice. Se puede visualizar como una fila con casillas, donde cada casilla (posición) contiene un dato y es identificada por un número de índice. 

 ```c#
 using System;

class Program
{
    static void Main()
    {
        int[] numeros = { 10, 20, 30, 40, 50 };

        Console.WriteLine("Elementos del arreglo:");
        for (int i = 0; i < numeros.Length; i++)
        {
            Console.WriteLine($"Índice {i}: {numeros[i]}");
        }
    }
}
 ```
 ![Unidimensionales](./Unidimensional.png)

 - **Multidimensional (matriz, etc)**
Un arreglo multidimensional es una estructura de datos que almacena elementos organizados en más de una dimensión, como una tabla con filas y columnas.
```c#
using System;

class Program
{
    static void Main()
    {
        int[,] matriz = { { 1, 2 }, { 3, 4 }, { 5, 6 } };

        Console.WriteLine("Elementos de la matriz:");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 2; j++)
            {
                Console.Write(matriz[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}
```
![Multidimensional](./Multidimensional.png)
## Pilas
Estructura de datos que sigue el principio LIFO (Last In - First Out), lo que indica que el ultimo en entrar sera el primero
en salir. 
Donde las operaciones tipicas son: 
- **Push** agregar elemento  
- **Pop** eliminar elemento.
- **Peek** → ver el elemento superior sin eliminarlo.

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
}
```
![Pilas](./Pilas.png)


## Cola
Una Cola es una estructura de datos que sigue el principio FIFO (First In, First Out).
Esto significa que el primer elemento en entrar es el primero en salir.
Las operaciones tipicas son:
- **Enqueue** agregar un elemento al final de la cola.
- **Dequeue** eliminar el primer elemento.
- **Peek** devuelve el primer elemento sin eliminarlo.

```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Cola de enteros
        Queue<int> cola = new Queue<int>();

        // Agregar elementos (Enqueue)
        cola.Enqueue(10);
        cola.Enqueue(20);
        cola.Enqueue(30);

        Console.WriteLine("Contenido actual de la cola:");
        foreach (int elemento in cola)
        {
            Console.WriteLine(elemento);
        }

        // Consultar el elemento superior (Peek)
        Console.WriteLine($"\nElemento en la cima: {cola.Peek()}");

        // Eliminar el elemento superior (Enqueue)
        cola.Dequeue();

        Console.WriteLine("\nCola después de eliminar un elemento:");
        foreach (int elemento in cola)
        {
            Console.WriteLine(elemento);
        }
    }
}
```
![Colas](./Colas.png)

## Listas enlazadas
Una Lista Enlazada es una colección de nodos, donde cada nodo contiene un valor y una referencia al siguiente nodo.
Permite *insertar* y *eliminar* elementos, sin necesidad de mover otros elementos como en los arreglos.
Existen dos tipos principales:
- Lista simplemente enlazada: cada nodo apunta solo al siguiente.
- Lista doblemente enlazada: cada nodo apunta al siguiente y al anterior.
Las listas enlazadas se utilizan cuando se requiere inserción y eliminación eficiente en posiciones arbitrarias.
```c#
using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // Lista enlazada de cadenas
        LinkedList<string> lista = new LinkedList<string>();

        // Agregar elementos al final
        lista.AddLast("A");
        lista.AddLast("B");
        lista.AddLast("C");

        Console.WriteLine("Lista enlazada actual:");
        foreach (var elemento in lista)
        {
            Console.WriteLine(elemento);
        }

        // Agregar un elemento al inicio
        lista.AddFirst("Inicio");

        // Eliminar un elemento
        lista.Remove("B");

        Console.WriteLine("\nLista después de modificaciones:");
        foreach (var elemento in lista)
        {
            Console.WriteLine(elemento);
        }
    }
}
```
![Listas](./ListasEnlazada.png)
