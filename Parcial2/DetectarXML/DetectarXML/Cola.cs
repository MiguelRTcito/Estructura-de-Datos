using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectarXML
{
    internal class Cola<Tipo>
    {
        private Nodo<Tipo> _frente;

        private Nodo<Tipo> Frente
        {
            get { return _frente; }
            set { _frente = value; }
        }

        private Nodo<Tipo> _final;

        private Nodo<Tipo> Final
        {
            get { return _final; }
            set { _final = value; }
        }

        public Cola()
        {
            this.Frente = null;
            this.Final = null;
        }

        public bool Vacia
        {
            get
            {
                if (this.Frente == null)
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
            nodoActual = this.Frente;

            do
            {
                yield return (nodoActual.ObjetoConDatos);

                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);

            yield break;
        }

        public void AgregarNodo(Tipo objeto)
        {
            Nodo<Tipo> nodoNuevo;

            //Cuando está vacía
            if (Vacia)
            {
                nodoNuevo = new Nodo<Tipo>();
                nodoNuevo.ObjetoConDatos = objeto;
                nodoNuevo.Siguiente = null;
                this.Frente = nodoNuevo;
                this.Final = nodoNuevo;
                return;
            }

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Frente;
            Nodo<Tipo> nodoPrevio = new Nodo<Tipo>();

            do
            {
                nodoPrevio = nodoActual;
                nodoActual = nodoActual.Siguiente;
            } while (nodoActual != null);

            //Agrego un datos después del quien está en frente
            nodoNuevo = new Nodo<Tipo>();
            nodoNuevo.ObjetoConDatos = objeto;
            nodoPrevio.Siguiente = nodoNuevo;
            nodoNuevo.Siguiente = null;
            this.Final = nodoNuevo;
        }

        public Tipo Eliminar()
        {
            if (Vacia)
                throw new Exception("La cola está vacía");

            Nodo<Tipo> nodoEliminado = new Nodo<Tipo>();

            Nodo<Tipo> nodoActual = new Nodo<Tipo>();
            nodoActual = this.Frente;

            Frente = nodoActual.Siguiente;

            //Guardo y elimino el dato que se encuentra en el frente
            nodoEliminado = nodoActual;
            nodoActual = null;
            return (nodoEliminado.ObjetoConDatos);
        }
    }
}
 


