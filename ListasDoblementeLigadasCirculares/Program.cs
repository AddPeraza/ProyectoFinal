using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadasCirculares
{
    class Program
    {
        static void Main(string[] args)
        {
            Lista lista = new Lista();
            lista.AgregarFinal("Nodo 1");
            lista.AgregarFinal("Nodo 2");
            lista.AgregarFinal("Nodo 3");

            
            Console.WriteLine(lista.Recorrer());

            
            Console.WriteLine("Presione cualquier tecla para cerrar la consola...");
            Console.ReadKey();
        }
    }
}
    

