using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laboratorio7
{
    class Program
    {
        static void Main(string[] args)
        {
            int w = 0;

            while (w == 0)
            {
                Console.WriteLine("Ingrese el tipo de su arbol generico");
                string tipo = Console.ReadLine();


                Console.WriteLine("Ingrese el obj de su nodo");
                string obj = Console.ReadLine();
                Console.WriteLine("Ingrese el padre de su nodo");
                string padre = Console.ReadLine();
                Console.WriteLine("Ingrese si lo quiere a la izquierda (0) o derecha (1) de este");
                int posicion = Convert.ToInt32(Console.ReadLine());

                ArbolBinario<string> t = new ArbolBinario<string>();
                t.Insertar(obj, padre, posicion);


            }
        }
    }
}
