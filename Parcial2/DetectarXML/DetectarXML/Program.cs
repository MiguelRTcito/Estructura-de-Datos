using DetectarXML;

internal class Program
{
    private static void Main(string[] args)
    {
        // Variable para almacenar el texto XML
        string xml;

       
        Cola<string> unaCola = new Cola<string>(); // Cola -> para guardar las etiquetas extraídas del XML
        Pila<string> unaPila = new Pila<string>(); // Pila -> para comprobar el correcto anidamiento

        Console.WriteLine("Inserte el XML: ");
        xml = Console.ReadLine(); 

        
        for (int i = 0; i < xml.Length; i++)  // Recorre toda la cadena carácter por carácter para detectar etiquetas 
        {
            if (xml[i] == '<') // Si se encuentra un '<', se asume que inicia una etiqueta.
            {
                string token = ""; // Acumulará los caracteres de la etiqueta encontrada

                for (int j = i; j < xml.Length; j++) //Recorre desde el '<' para encontrar uno de cierre '>'
                {
                    token += xml[j]; // Se van agregando los caracteres al token

                    if (xml[j] == '>') //Indica que se cierra la etiqueta
                    {
                      
                        unaCola.AgregarNodo(token);  // Se agrega el token a la cola

                        i = j; //Se asigna el valor de j a i para continuar desde ese punto

                        break; //Romper ciclo al acabar con la etiqueta
                    }
                }
            }
        }

       
        while (!unaCola.Vacia) //Se guardan las colas en el orden en que llegaron
        {
            string token = unaCola.Eliminar(); //Se obtiene y quita el primer valor de la cola

            
            if (token[1] != '/') // Si la segunda posición del token NO es '/', entonces es una etiqueta de apertura
            {
                // Se obtiene el nombre de la etiqueta sin los símbolos '<' y '>'
                string nombre = token.Substring(1, token.Length - 2);

                // Se apila el nombre de la etiqueta (se guarda para verificar su cierre después)
                unaPila.Push(nombre);
            }
            else
            {
                
                string nombre = token.Substring(2, token.Length - 3);

                
                if (unaPila.Vacia || unaPila.Peek() != nombre )// Verifica si la pila está vacía o si la última etiqueta no coincide con la que se intenta cerrar
                {
                    Console.WriteLine("El XML está mal formado");
                    return;
                }
                else
                {
                  
                    unaPila.Pop();
                }
            }
        }

       
       
        if (unaPila.Vacia) // Si la pila está vacía, las etiquetas se abrieron y cerraron correctamente
        {
            Console.WriteLine("El XML está bien formado.");
        }
        else
        {
            Console.WriteLine("El XML está mal formado (faltan cierres).");
        }

        Console.ReadKey(); 
    }

}

