using System;

namespace ListasCirculares
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista
            Lista lista = new Lista();

            // Agregar algunos nodos a la lista
            lista.Agregar("Nodo 1");
            lista.Agregar("Nodo 2");
            lista.Agregar("Nodo 3");

            // Imprimir el contenido de la lista
            Console.WriteLine("Contenido de la lista:");
            Console.WriteLine(lista.Recorrer());

            // Buscar un nodo en la lista
            Nodo nodoBuscado = lista.Buscar("Nodo 2");
            if (nodoBuscado != null)
            {
                Console.WriteLine("Se encontró el nodo con valor '{0}'", nodoBuscado.Valor);
            }
            else
            {
                Console.WriteLine("No se encontró el nodo buscado");
            }

            // Agregar un nodo al inicio de la lista
            lista.AgregarNodoInicio("Nodo inicio");
            Console.WriteLine("Contenido de la lista después de agregar un nodo al inicio:");
            Console.WriteLine(lista.Recorrer());

            // Eliminar un nodo de la lista
            lista.BorrarNodo("Nodo 3");
            Console.WriteLine("Contenido de la lista después de eliminar un nodo:");
            Console.WriteLine(lista.Recorrer());

            // Vaciar la lista
            lista.VaciarLista();
            Console.WriteLine("Contenido de la lista después de vaciarla:");
            Console.WriteLine(lista.Recorrer());
        }
    }
}
