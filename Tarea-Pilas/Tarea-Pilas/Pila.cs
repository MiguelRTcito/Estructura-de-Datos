using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;

namespace Tarea_Pilas
{
    internal class Pila
    {
        private int intIndiceTope = -1;   // índice que apunta al tope de la pila
        private char[] victor;            // arreglo que almacena los elementos de la pila

        // Constructor: el tamaño dependerá de la longitud de la palabra del usuario
        public Pila(int tamaño)
        {
            victor = new char[tamaño]; // se crea un arreglo de caracteres con el tamaño especificado
        }

        // Método para apilar un caracter
        public bool Apilar(char caracter)
        {
            if (EstaLlena()) // se verifica si la pila está llena
                return false;

            intIndiceTope++; // se incrementa el índice
            victor[intIndiceTope] = caracter; // se agrega el caracter al tope
            return true;
        }

        // Método para desapilar (quitar) el caracter del tope
        public char Desapilar()
        {
            if (EstaVacia())
                throw new InvalidOperationException("Pila vacía");

            char caracter = victor[intIndiceTope];
            victor[intIndiceTope] = '\0'; // elimina el caracter (lo deja vacío)
            intIndiceTope--;
            return caracter;
        }

        // Muestra el contenido de la pila
        public string Mostrar()
        {
            if (EstaVacia())
                return "Pila vacía";

            string resultado = "Elementos en la pila:\n";
            for (int i = 0; i <= intIndiceTope; i++)
            {
                resultado += victor[i] + "\n";
            }
            return resultado;
        }

        // Verifica si la pila está vacía
        public bool EstaVacia()
        {
            return intIndiceTope == -1;
        }

        // Verifica si la pila está llena
        public bool EstaLlena()
        {
            return intIndiceTope == victor.Length - 1;
        }
    }
}
