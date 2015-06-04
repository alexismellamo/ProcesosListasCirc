using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_Listas
{
    class Proceso
    {
        static private Random ran = new Random();
        private short _ciclos;
        private Proceso _siguiente;
        private Proceso _anterior;

        internal Proceso Anterior
        {
            get { return _anterior; }
            set { _anterior = value; }
        }

        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }

        public short Ciclos
        {
            get { return _ciclos; }
            set { _ciclos = value; }
        }

        public Proceso()
        {
            _ciclos = (short)ran.Next(4, 13);
        }
    }
}
