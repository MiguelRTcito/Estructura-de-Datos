using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DetectarXML
{
    internal class Nodo<Tipo>
    {
        private Tipo _objetoConDatos;

        public Tipo ObjetoConDatos
        {
            get { return _objetoConDatos; }
            set { _objetoConDatos = value; }
        }

        private Nodo<Tipo> _siguiente;

        public Nodo<Tipo> Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        ~Nodo()
        {
            ObjetoConDatos = default(Tipo);
        }
    }
}


