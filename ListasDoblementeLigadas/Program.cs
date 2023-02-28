using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Lista miLista = new Lista();

            Console.WriteLine("Lista vacía: " + miLista.ValidaVacio()); // debería imprimir true

            miLista.AgregarFinal("Nodo 1");
            miLista.AgregarFinal("Nodo 2");
            miLista.AgregarFinal("Nodo 3");

            Console.WriteLine(miLista.Recorrer()); // debería imprimir "nodo 1\nodo 2\nodo 3\n"

            miLista.AgregarInicio("Nodo 0");

            Console.WriteLine(miLista.Recorrer()); // debería imprimir nodo 0\nodo 1\nodo 2\nodo 3\n

            Console.WriteLine("Buscar 'Nodo 2': " + miLista.Buscar("Nodo 2")); 

            miLista.EliminarNodo("Nodo 1");

            Console.WriteLine(miLista.Recorrer()); // debería imprimir los nodos 

            miLista.VaciarLista();

            Console.WriteLine("Lista vacía: " + miLista.ValidaVacio()); // debería imprimir true

            Console.ReadKey();
        }
    }
    
}

