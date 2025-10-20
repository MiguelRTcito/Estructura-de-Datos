using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuitaRepetidos
{
    internal class Cola
    {
        private int intIndice = -1;
        private int[] victor;

        public Cola(int tamaño)
        {
            victor = new int[tamaño]; // se crea un arreglo de enteros con el tamaño especificado
        }

        public bool Agregar(int Num)
        {
            if (intIndice == victor.Length - 1)
                return false; // retorna false si la cola está llena
            intIndice++; // se incrementa el índice para agregar un nuevo elemento
            victor[intIndice] = Num; // se agrega el nuevo elemento en la posición del índice
            return true;
        }

        public int Eliminar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("La cola está vacía"); // lanza una excepción si la cola está vacía

            int intNumero = victor[0]; // se guarda el primer elemento de la cola
            for (int i = 0; i < intIndice; i++) // se recorre el arreglo desde la posición 0 hasta el índice actual
            {
                victor[i] = victor[i + 1];
            }
            victor[intIndice] = 0; // se elimina el último elemento (ahora vale 0)
            intIndice--; // se decrementa el índice ya que se eliminó un elemento
            return intNumero; // se retorna el número eliminado
        }

        public string Mostrar()
        {
           if (EstaVacia())
                return "La cola está vacía"; // mensaje si la cola está vacía

            string resultado = "";
            for (int i = 0; i <= intIndice; i++) // se recorre el arreglo hasta el índice actual
            {
                resultado += victor[i].ToString() + "\n"; // se concatena el valor del arreglo en la posición i
            }
            return resultado;
        }
        public bool EstaVacia()
        {
            return intIndice == -1; // retorna true si la cola está vacía, false en caso contrario
        }
    }
}
