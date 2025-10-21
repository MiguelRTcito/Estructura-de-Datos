# Estructura de datos

Un tipo de **dato abstracto** es un modelo que define un conjunto de datos y las operaciones que estos pueden generar.
Sus clasificaciones mas comunes son:

- Pilas
- Colas
- Listas enlazadas: simplemente y doblemente enlazadas

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
![Listas](https://www.google.com/imgres?q=tda%20listas%20enlazadas&imgurl=https%3A%2F%2Fblogger.googleusercontent.com%2Fimg%2Fb%2FR29vZ2xl%2FAVvXsEi4FqR29Kzx81lecfLJJPnnwSRvjqRQEVmey1Ylfj6EAzHzinVVm13aBFVa-gdSFNpG2wBosOkJ6zelL-S4yk_49BI9zf2R07T70ZvEYzkFGPfgpoi8HolUaBaZBmiNcDQZkH1xeVuVeLI%2Fs1600%2Flista.png&imgrefurl=http%3A%2F%2Fprogramacionparacoccidio.blogspot.com%2F2013%2F01%2Flistas-enlazadas-en-c-orientado-objetos.html&docid=XsKdINp1vYmlHM&tbnid=87xeUH4f2owIfM&vet=12ahUKEwiBhfO3praQAxW6sGoFHaZJKh4QM3oECB4QAA..i&w=304&h=225&hcb=2&ved=2ahUKEwiBhfO3praQAxW6sGoFHaZJKh4QM3oECB4QAA)
