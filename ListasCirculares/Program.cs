using System;

namespace ListasCirculares
{
    class Program
    {

        
        static void Main(string[] args)
        {

            Lista lista = new Lista();

            // Agregar nodos a la lista
            lista.Agregar("nodo 1");
            lista.Agregar("nodo 2");
            lista.Agregar("nodo 3");

            // Imprimir la lista
            Console.WriteLine("Elementos de la lista:");
            Console.WriteLine(lista.Recorrer());

            // Buscar un nodo en la lista
            Nodo nodoBuscado = lista.Buscar("nodo 2");
            if (nodoBuscado != null)
            {
                Console.WriteLine("El nodo con valor 'nodo 2' fue encontrado");
            }
            else
            {
                Console.WriteLine("El nodo con valor 'nodo 2' no fue encontrado");
            }

            // Agregar un nodo al inicio de la lista
            lista.AgregarNodoInicio("nodo 0");
            Console.WriteLine("nodo de la lista después de agregar un nodo al inicio:");
            Console.WriteLine(lista.Recorrer());
          

            // Borrar un nodo de la lista
            lista.BorrarNodo("nodo 2");
            Console.WriteLine("Elementos de la lista después de borrar un nodo:");
            Console.WriteLine(lista.Recorrer());
            

            // Vaciar la lista
            lista.VaciarLista();
            Console.WriteLine("nodo de la lista después de vaciarla:");
            Console.WriteLine(lista.Recorrer());

           
        }
        
        
    }
     

}

