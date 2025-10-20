using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectarXML
{
    internal class Pila<Tipo>
    {
        private Nodo<Tipo> _top;

        private Nodo<Tipo> Top
        {
            get { return _top; }
            set { _top = value; }
        }

        public Pila()
        {
            this.Top = null;
        }

        public bool Vacia
        {
            get
            {
                if (this.Top == null)
                    return (true);
                else
                    return (false);
            }
        }

        public IEnumerator<Tipo> GetEnumerator()
        {
            if (Vacia)
                yield break;

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;

            do
            {
                yield return (nodoActual.ObjetoConDatos);
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);

            yield break;
        }

        public void Push(Tipo objeto)
        {
            Nodo<Tipo> nodoNuevo;

            //Cuando está vacía
            if (Vacia)
            {
                nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                this.Top = nodoNuevo;
                return;
            }

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;

            //Lo agrega encima de otro dato
            nodoNuevo = new Nodo<Tipo>();
            nodoNuevo.ObjetoConDatos = objeto;
            nodoNuevo.Siguiente = this.Top;
            this.Top = nodoNuevo;
        }



        public Tipo Pop()
        {
            if (Vacia)
                throw new Exception("La pila está vacía");

            Nodo<Tipo> nodoEliminado = new Nodo<Tipo>();
            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Top;

            this.Top = nodoActual.Siguiente;

            //Elimino y guardo el dato que se encuentra en el tope
            nodoEliminado = nodoActual;
            nodoActual = null;
            return (nodoEliminado.ObjetoConDatos);
        }

        public Tipo Peek()
        {
            if (Vacia)
                throw new Exception("La pila está vacía");

            return (this.Top.ObjetoConDatos);
        }
    }
}


