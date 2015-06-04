using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Procesos_Listas
{
    class Lista
    {
        private Proceso _inicio;
        private int _count;

        public int Count
        {
            get { return _count; }
            set { _count = value; }
        }

        public Proceso Inicio
        {
            get { return _inicio; }
        }

        public void agregar(Proceso nuevo)
        {
            if (_inicio == null)
            {
                _inicio = nuevo;
                nuevo.Siguiente = _inicio;
                nuevo.Anterior = _inicio;
            }
            else
            {
                Proceso tem = _inicio;
                while (tem.Siguiente != _inicio)
                    tem = tem.Siguiente;

                nuevo.Siguiente = tem.Siguiente;
                nuevo.Anterior = tem;
                tem.Siguiente.Anterior = nuevo;
                tem.Siguiente = nuevo;
            }
            _count++;
        }

        public void eliminar(Proceso eli)
        {
            if (eli == _inicio)
                _inicio = eli.Siguiente;

            eli.Anterior.Siguiente = eli.Siguiente;
            eli.Siguiente.Anterior = eli.Anterior;
            _count--;
        }
    }
}
