using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    public class ArbolBinario<T>
    {
        public class Nodo<T>
        {
            public T value;
            public Nodo<T>[] nodos = new Nodo<T>[2];
            public Nodo<T> HijoDer;
            public Nodo<T> HijoIzq;

        }
        Nodo<T> raiz;
        public ArbolBinario()
        {
            raiz = null;
        }

        public void Insertar(T obj, Nodo<T> Padre, int donde)
        {
            //donde: 0 izq, 1 der
            Nodo<T> n = new Nodo<T>();
            n.HijoIzq = null;
            n.HijoDer = null;
            n.value = obj;
            n.nodos[1] = n.HijoIzq;
            n.nodos[2] = n.HijoDer;
            if (Padre.nodos[donde] == null)
            {
                Padre.nodos[donde] = n;
            }
            else if (donde == 0 && Padre == null)
            {
                raiz = n;
            }
            else
            {
                Console.WriteLine("El nodo se encuentra ocupado");
            }
            
        }
    }
}
